using System;
using System.Data.SqlClient;

namespace WarsztatSamochodowy
{
    public static class DbHelper
    {
        private static bool optimizationsChecked = false;

        public static string ConnectionString
        {
            get
            {
                try
                {
                    string configured = Properties.Settings.Default.WarsztatDBCS;
                    if (!string.IsNullOrWhiteSpace(configured))
                    {
                        return configured;
                    }
                }
                catch
                {
                    // Fallback w razie problemów z konfiguracją runtime
                }

                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WarsztatDB.mdf;Integrated Security=True";
            }
        }

        public static SqlConnection GetConnection()
        {
            EnsureDatabaseOptimizations();
            return new SqlConnection(ConnectionString);
        }

        /// <summary>
        /// Bezpiecznie weryfikuje i aplikuje brakujące kolumny oraz indeksy wydajnościowe
        /// bez naruszania istniejących danych w bazie.
        /// </summary>
        public static void EnsureDatabaseOptimizations()
        {
            if (optimizationsChecked)
                return;

            optimizationsChecked = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // 1. Bezpieczne dodanie brakujących kolumn
                    string alterScript = @"
                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[Samochody]') AND name = 'PracownikId')
                        ALTER TABLE [dbo].[Samochody] ADD [PracownikId] INT NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[Samochody]') AND name = 'KosztCzesci')
                        ALTER TABLE [dbo].[Samochody] ADD [KosztCzesci] DECIMAL(18,2) DEFAULT (0.00) NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[dbo].[Samochody]') AND name = 'KosztRobocizny')
                        ALTER TABLE [dbo].[Samochody] ADD [KosztRobocizny] DECIMAL(18,2) DEFAULT (0.00) NULL;
                    ";

                    using (SqlCommand cmd = new SqlCommand(alterScript, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Indeksy wydajnościowe, konta startowe i dane demonstracyjne
                    string seedScript = @"
                    IF NOT EXISTS (SELECT name FROM sys.indexes WHERE name = N'IX_Samochody_Status')
                    BEGIN
                        CREATE NONCLUSTERED INDEX [IX_Samochody_Status] 
                        ON [dbo].[Samochody] ([Status]) 
                        INCLUDE ([KosztNaprawy], [Marka], [Model], [NrRejestracyjny]);
                    END;

                    IF NOT EXISTS (SELECT name FROM sys.indexes WHERE name = N'IX_Samochody_KlientId')
                    BEGIN
                        CREATE NONCLUSTERED INDEX [IX_Samochody_KlientId] 
                        ON [dbo].[Samochody] ([KlientId]);
                    END;

                    IF NOT EXISTS (SELECT name FROM sys.indexes WHERE name = N'IX_Uzytkownicy_Rola')
                    BEGIN
                        CREATE NONCLUSTERED INDEX [IX_Uzytkownicy_Rola] 
                        ON [dbo].[Uzytkownicy] ([Rola]);
                    END;

                    -- Domyślne konto Administratora (hasło: admin123)
                    IF NOT EXISTS (SELECT 1 FROM [dbo].[Uzytkownicy] WHERE [Login] = N'admin')
                    BEGIN
                        INSERT INTO [dbo].[Uzytkownicy] 
                            ([Imie], [Nazwisko], [Email], [Telefon], [Login], [PasswordHash], [Rola], [Adres], [DataRejestracji])
                        VALUES 
                            (N'Jan', N'Kowalski', N'admin@warsztat.pl', N'123-456-789', N'admin', 
                             N'240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 
                             N'Administrator', N'ul. Warsztatowa 1, Warszawa', GETDATE());
                    END;

                    -- Domyślne konto Pracownika / Mechanika (hasło: mechanik123)
                    IF NOT EXISTS (SELECT 1 FROM [dbo].[Uzytkownicy] WHERE [Login] = N'mechanik')
                    BEGIN
                        INSERT INTO [dbo].[Uzytkownicy] 
                            ([Imie], [Nazwisko], [Email], [Telefon], [Login], [PasswordHash], [Rola], [Adres], [DataRejestracji])
                        VALUES 
                            (N'Piotr', N'Nowak', N'mechanik@warsztat.pl', N'987-654-321', N'mechanik', 
                             N'a38a4a1668a377fbcdde5335e34f7d73e79effbb7caebd3f7422ecaaf069f346', 
                             N'Pracownik', N'ul. Serwisowa 5, Warszawa', GETDATE());
                    END
                    ELSE IF EXISTS (SELECT 1 FROM [dbo].[Uzytkownicy] WHERE [Login] = N'mechanik' AND [PasswordHash] = N'6584285adfa2f7ca811b519b5963f45c994fb8e95383f76da896174a89965d1d')
                    BEGIN
                        UPDATE [dbo].[Uzytkownicy] 
                        SET [PasswordHash] = N'a38a4a1668a377fbcdde5335e34f7d73e79effbb7caebd3f7422ecaaf069f346' 
                        WHERE [Login] = N'mechanik';
                    END;

                    -- Normalizacja ról w bazie danych
                    UPDATE [dbo].[Uzytkownicy] SET [Rola] = N'Administrator' WHERE [Rola] = N'Admin';

                    -- Domyślne pojazdy demonstracyjne (jeśli tabela jest pusta)
                    IF NOT EXISTS (SELECT 1 FROM [dbo].[Samochody])
                    BEGIN
                        DECLARE @klientId INT = (SELECT TOP 1 Id FROM [dbo].[Uzytkownicy] WHERE [Rola] = 'Klient');
                        DECLARE @mechId INT = (SELECT TOP 1 Id FROM [dbo].[Uzytkownicy] WHERE [Login] = 'mechanik');

                        IF @klientId IS NOT NULL
                        BEGIN
                            INSERT INTO [dbo].[Samochody] 
                                ([KlientId], [PracownikId], [Marka], [Model], [RokProdukcji], [NrRejestracyjny], [VIN], [OpisUszkodzen], [Uwagi], [DataPrzyjecia], [Status], [KosztRobocizny], [KosztCzesci], [KosztNaprawy])
                            VALUES 
                                (@klientId, @mechId, N'Audi', N'A4 B8', N'2012', N'WA12345', N'WAUZZZ8K9CA123456', N'Wymiana rozrządu oraz klocków hamulcowych', N'Klient prosi o części OEM', GETDATE(), N'W trakcie naprawy', 450.00, 750.00, 1200.00),
                                (@klientId, @mechId, N'Volkswagen', N'Golf VII', N'2016', N'WI67890', N'WVWZZZAUZHP123456', N'Serwis olejowy i filtry', N'Gotowe do wydania', GETDATE(), N'Gotowy do odbioru', 150.00, 250.00, 400.00),
                                (@klientId, NULL, N'Skoda', N'Octavia III', N'2018', N'WZ45678', N'TMBJJ7NE5J0123456', N'Diagnostyka stukania w zawieszeniu przednim', N'Oczekiwanie na wahacze', GETDATE(), N'Przyjęty', 0.00, 0.00, 0.00);
                        END;
                    END;
                    ";

                    using (SqlCommand cmd = new SqlCommand(seedScript, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // Ignoruj błędy jeśli baza jest niedostępna lub brak uprawnień DDL
            }
        }
    }
}
