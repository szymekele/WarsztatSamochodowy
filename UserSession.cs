namespace WarsztatSamochodowy
{
    public class UserSession
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Rola { get; set; }
        public string Login { get; set; }

        public UserSession()
        {
        }

        public UserSession(string imie, string nazwisko, string rola, string login, int id = -1)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Rola = rola;
            Login = login;
        }

        public string PelnaNazwa
        {
            get { return string.Format("{0} {1}", Imie, Nazwisko).Trim(); }
        }

        public string OpisRoli
        {
            get { return string.Format("{0} | {1}", Login, Rola); }
        }

        public bool CzyPracownikLubAdmin
        {
            get
            {
                return !string.IsNullOrEmpty(Rola) &&
                       (Rola.Equals("Administrator", System.StringComparison.OrdinalIgnoreCase) ||
                        Rola.Equals("Admin", System.StringComparison.OrdinalIgnoreCase) ||
                        Rola.Equals("Pracownik", System.StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
