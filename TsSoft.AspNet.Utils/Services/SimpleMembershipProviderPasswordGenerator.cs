using System;
using System.Security.Cryptography;

namespace TsSoft.AspNet.Utils.Services
{
    public class SimpleMembershipProviderPasswordGenerator : IPasswordGenerator
    {
        private const int Pbkdf2IterCount = 1000;
        private const int Pbkdf2SubkeyLength = 256 / 8;
        private const int SaltSize = 128 / 8;

        public string Generate(string password, string providerTypeName = "")
        {
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] salt;
            byte[] subkey;
            using (var deriveBytes = new Rfc2898DeriveBytes(password, SaltSize, Pbkdf2IterCount))
            {
                salt = deriveBytes.Salt;
                subkey = deriveBytes.GetBytes(Pbkdf2SubkeyLength);
            }
            var outputBytes = new byte[1 + SaltSize + Pbkdf2SubkeyLength];
            Buffer.BlockCopy(salt, 0, outputBytes, 1, SaltSize);
            Buffer.BlockCopy(subkey, 0, outputBytes, 1 + SaltSize, Pbkdf2SubkeyLength);
            return Convert.ToBase64String(outputBytes);
        }
    }
}
