-- =============================================================
-- Skrypt struktury bazy danych dla projektu WarsztatSamochodowy
-- Kompatybilny z MS SQL Server 2016+ oraz MSSQLLocalDB
-- Zoptymalizowany pod kątem wydajności (indeksy) i ról (RBAC)
-- =============================================================

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'WarsztatDB')
BEGIN
    CREATE DATABASE [WarsztatDB];
END
GO

USE [WarsztatDB];
GO

-- -------------------------------------------------------------
-- Tabela: Uzytkownicy
-- -------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Uzytkownicy]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Uzytkownicy] (
        [Id]              INT IDENTITY(1,1) NOT NULL,
        [Imie]            NVARCHAR(50)      NOT NULL,
        [Nazwisko]        NVARCHAR(50)      NOT NULL,
        [Email]           NVARCHAR(100)     NULL,
        [Telefon]         NVARCHAR(20)      NULL,
        [Login]           NVARCHAR(50)      NOT NULL,
        [PasswordHash]    NVARCHAR(256)     NOT NULL,
        [Rola]            NVARCHAR(50)      DEFAULT (N'Klient') NOT NULL,
        [Adres]           NVARCHAR(200)     NULL,
        [DataRejestracji] DATETIME          DEFAULT (GETDATE()) NOT NULL,
        CONSTRAINT [PK_Uzytkownicy] PRIMARY KEY CLUSTERED ([Id] ASC),
        CONSTRAINT [UQ_Uzytkownicy_Login] UNIQUE NONCLUSTERED ([Login] ASC)
    );
END
GO

-- -------------------------------------------------------------
-- Tabela: Samochody
-- -------------------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Samochody]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Samochody] (
        [Id]              INT IDENTITY(1,1) NOT NULL,
        [KlientId]        INT               NOT NULL,
        [PracownikId]     INT               NULL,
        [Marka]           NVARCHAR(50)      NOT NULL,
        [Model]           NVARCHAR(50)      NOT NULL,
        [RokProdukcji]    NVARCHAR(10)      NULL,
        [NrRejestracyjny] NVARCHAR(20)      NOT NULL,
        [VIN]             NVARCHAR(50)      NULL,
        [OpisUszkodzen]   NVARCHAR(MAX)     NULL,
        [Uwagi]           NVARCHAR(MAX)     NULL,
        [DataPrzyjecia]   DATETIME          DEFAULT (GETDATE()) NULL,
        [DataWydania]     DATETIME          NULL,
        [Status]          NVARCHAR(50)      DEFAULT (N'Przyjęty') NULL,
        [KosztNaprawy]    DECIMAL(18,2)     DEFAULT (0.00) NULL,
        [KosztCzesci]     DECIMAL(18,2)     DEFAULT (0.00) NULL,
        [KosztRobocizny]  DECIMAL(18,2)     DEFAULT (0.00) NULL,
        CONSTRAINT [PK_Samochody] PRIMARY KEY CLUSTERED ([Id] ASC),
        CONSTRAINT [FK_Samochody_Uzytkownicy] FOREIGN KEY ([KlientId])
            REFERENCES [dbo].[Uzytkownicy] ([Id])
            ON DELETE CASCADE,
        CONSTRAINT [FK_Samochody_Pracownicy] FOREIGN KEY ([PracownikId])
            REFERENCES [dbo].[Uzytkownicy] ([Id])
    );
END
GO

-- -------------------------------------------------------------
-- Indeksy wydajnościowe (Performance Indexes)
-- -------------------------------------------------------------
IF NOT EXISTS (SELECT name FROM sys.indexes WHERE name = N'IX_Samochody_Status')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Samochody_Status] 
    ON [dbo].[Samochody] ([Status]) 
    INCLUDE ([KosztNaprawy], [Marka], [Model], [NrRejestracyjny]);
END
GO

IF NOT EXISTS (SELECT name FROM sys.indexes WHERE name = N'IX_Samochody_KlientId')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Samochody_KlientId] 
    ON [dbo].[Samochody] ([KlientId]);
END
GO

IF NOT EXISTS (SELECT name FROM sys.indexes WHERE name = N'IX_Uzytkownicy_Rola')
BEGIN
    CREATE NONCLUSTERED INDEX [IX_Uzytkownicy_Rola] 
    ON [dbo].[Uzytkownicy] ([Rola]);
END
GO

-- -------------------------------------------------------------
-- Dane początkowe (Administrator oraz Mechanik)
-- Hasła domyślne: admin123, mechanik123 (hash SHA-256)
-- -------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM [dbo].[Uzytkownicy] WHERE [Login] = N'admin')
BEGIN
    INSERT INTO [dbo].[Uzytkownicy] 
        ([Imie], [Nazwisko], [Email], [Telefon], [Login], [PasswordHash], [Rola], [Adres], [DataRejestracji])
    VALUES 
        (N'Jan', N'Kowalski', N'admin@warsztat.pl', N'123-456-789', N'admin', 
         N'240be518fabd2724ddb6f04eeb1da5967448d7e831c08c8fa822809f74c720a9', 
         N'Administrator', N'ul. Warsztatowa 1, Warszawa', GETDATE());
END
GO

IF NOT EXISTS (SELECT 1 FROM [dbo].[Uzytkownicy] WHERE [Login] = N'mechanik')
BEGIN
    INSERT INTO [dbo].[Uzytkownicy] 
        ([Imie], [Nazwisko], [Email], [Telefon], [Login], [PasswordHash], [Rola], [Adres], [DataRejestracji])
    VALUES 
        (N'Piotr', N'Nowak', N'mechanik@warsztat.pl', N'987-654-321', N'mechanik', 
         N'a38a4a1668a377fbcdde5335e34f7d73e79effbb7caebd3f7422ecaaf069f346', 
         N'Pracownik', N'ul. Serwisowa 5, Warszawa', GETDATE());
END
GO

-- -------------------------------------------------------------
-- Pojazdy demonstracyjne (Seed Data)
-- -------------------------------------------------------------
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
    END
END
GO
