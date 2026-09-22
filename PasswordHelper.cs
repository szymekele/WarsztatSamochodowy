using System;
using System.Security.Cryptography;
using System.Text;

namespace WarsztatSamochodowy
{
    public static class PasswordHelper
    {
        private const int SaltByteSize = 16;

        /// <summary>
        /// Generuje kryptograficznie bezpieczną sól.
        /// </summary>
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[SaltByteSize];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        /// <summary>
        /// Haszuje hasło z podaną solą i zwraca ciąg formatu SALT:HASH.
        /// </summary>
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return string.Empty;

            string salt = GenerateSalt();
            string hash = ComputeHashWithSalt(password, salt);
            return string.Format("{0}:{1}", salt, hash);
        }

        /// <summary>
        /// Oblicza skrót SHA-256 dla hasła z dołączoną solą.
        /// </summary>
        private static string ComputeHashWithSalt(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] combinedBytes = Encoding.UTF8.GetBytes(salt + password);
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Oblicza prosty skrót SHA-256 (bez soli - dla zachowania wstecznej zgodności).
        /// </summary>
        public static string ComputePlainSha256(string password)
        {
            if (string.IsNullOrEmpty(password))
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Weryfikuje hasło z zapisanym hashem.
        /// Obsługuje format solony (SALT:HASH), prosty SHA-256 oraz czysty tekst.
        /// Wykorzystuje porównywanie w stałym czasie (ochrona przed Timing Attacks).
        /// </summary>
        public static bool VerifyPassword(string inputPassword, string storedPasswordOrHash)
        {
            if (string.IsNullOrEmpty(inputPassword) || string.IsNullOrEmpty(storedPasswordOrHash))
                return false;

            // 1. Sprawdzenie formatu z solą: SALT:HASH
            if (storedPasswordOrHash.Contains(":"))
            {
                string[] parts = storedPasswordOrHash.Split(':');
                if (parts.Length == 2)
                {
                    string salt = parts[0];
                    string expectedHash = parts[1];
                    string computedHash = ComputeHashWithSalt(inputPassword, salt);
                    return SlowEquals(computedHash, expectedHash);
                }
            }

            // 2. Sprawdzenie formatu SHA-256 bez soli
            string plainSha = ComputePlainSha256(inputPassword);
            if (SlowEquals(plainSha, storedPasswordOrHash))
                return true;

            // 3. Wsteczna kompatybilność dla haseł zapisanych jako czysty tekst
            if (SlowEquals(inputPassword, storedPasswordOrHash))
                return true;

            return false;
        }

        /// <summary>
        /// Porównanie dwóch ciągów w stałym czasie dla zapobiegania atakom typu Timing Attack.
        /// </summary>
        private static bool SlowEquals(string a, string b)
        {
            if (a == null || b == null)
                return false;

            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }
            return diff == 0;
        }
    }
}
