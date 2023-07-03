using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Implementation
{
    internal class OTPGenerator
    {
        private const int ValidityPeriod = 30;

        public static string GenerateOneTimePassword(string userId, DateTime dateTime)
        {
            string seed = $"{userId}{dateTime.ToString("yyyyMMddHHmmss")}";

            string hash = seed.GetHashCode().ToString();

            string password = hash.Substring(0, 8);

            return password;
        }

        public static bool IsPasswordValid(string password, DateTime dateTime)
        {
            DateTime currentDateTime = DateTime.Now;
            TimeSpan elapsedTime = currentDateTime - dateTime;

            return elapsedTime.TotalSeconds <= ValidityPeriod;
        }
    }
}
