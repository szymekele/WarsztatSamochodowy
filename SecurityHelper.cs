using System;
using System.Collections.Concurrent;

namespace WarsztatSamochodowy
{
    public static class SecurityHelper
    {
        public const int MaxFailedAttempts = 5;
        public static readonly TimeSpan LockoutDuration = TimeSpan.FromMinutes(3);

        private class AttemptRecord
        {
            public int FailedCount { get; set; }
            public DateTime? LockoutUntil { get; set; }
        }

        private static readonly ConcurrentDictionary<string, AttemptRecord> LoginAttempts = 
            new ConcurrentDictionary<string, AttemptRecord>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Sprawdza, czy konto dla danego loginu jest zablokowane z powodu zbyt wielu nieudanych prób logowania.
        /// </summary>
        public static bool IsAccountLocked(string login, out int remainingSeconds)
        {
            remainingSeconds = 0;
            if (string.IsNullOrWhiteSpace(login))
                return false;

            AttemptRecord record;
            if (LoginAttempts.TryGetValue(login, out record))
            {
                if (record.LockoutUntil.HasValue)
                {
                    if (DateTime.UtcNow < record.LockoutUntil.Value)
                    {
                        remainingSeconds = (int)Math.Ceiling((record.LockoutUntil.Value - DateTime.UtcNow).TotalSeconds);
                        return true;
                    }
                    else
                    {
                        // Blokada wygasła - reset
                        record.LockoutUntil = null;
                        record.FailedCount = 0;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Zapisuje nieudaną próbę logowania. Jeśli osiągnięto limit, aktywuje blokadę konta.
        /// </summary>
        public static int RecordFailedAttempt(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return 0;

            AttemptRecord record = LoginAttempts.GetOrAdd(login, (k) => new AttemptRecord());
            record.FailedCount++;

            if (record.FailedCount >= MaxFailedAttempts)
            {
                record.LockoutUntil = DateTime.UtcNow.Add(LockoutDuration);
            }

            return record.FailedCount;
        }

        /// <summary>
        /// Resetuje licznik nieudanych prób logowania po pomyślnym zalogowaniu.
        /// </summary>
        public static void ResetFailedAttempts(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return;

            AttemptRecord ignored;
            LoginAttempts.TryRemove(login, out ignored);
        }

        /// <summary>
        /// Weryfikuje, czy użytkownik w sesji posiada jedną z dozwolonych ról (RBAC).
        /// </summary>
        public static bool HasPermission(UserSession session, params string[] allowedRoles)
        {
            if (session == null || string.IsNullOrWhiteSpace(session.Rola))
                return false;

            foreach (string role in allowedRoles)
            {
                if (string.Equals(session.Rola, role, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }
    }
}
