using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReciPicker.Controllers.Helper
{
    public class UserService
    {
        public string SaltPasswordWithSalt(string pass, string salt)
        {
            byte[] passBytes = Encoding.UTF8.GetBytes(pass);
            byte[] saltBytes = Convert.FromBase64String(salt);

            byte[] combiedBytes = new byte[passBytes.Length + saltBytes.Length];
            Buffer.BlockCopy(passBytes, 0, combiedBytes, 0, passBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, combiedBytes, passBytes.Length, saltBytes.Length);

            HashAlgorithm hashAlgo = new SHA256Managed();
            byte[] hash = hashAlgo.ComputeHash(combiedBytes);

            string result = Convert.ToBase64String(hash);

            return result;
        }
        public (string, string) SaltPassword(string pass)
        {
            byte[] saltBytes = new byte[32];
            RNGCryptoServiceProvider.Create().GetBytes(saltBytes);
            string salt = Convert.ToBase64String(saltBytes);

            byte[] passBytes = Encoding.UTF8.GetBytes(pass);
            
            byte[] combiedBytes = new byte[passBytes.Length + saltBytes.Length];
            Buffer.BlockCopy(passBytes, 0, combiedBytes, 0, passBytes.Length);
            Buffer.BlockCopy(saltBytes, 0, combiedBytes, passBytes.Length, saltBytes.Length);

            HashAlgorithm hashAlgo = new SHA256Managed();
            byte[] hash = hashAlgo.ComputeHash(combiedBytes);

            string result = Convert.ToBase64String(hash);
            return (result, salt);
        }
        public bool ComparePassword(string passToCompare, string salt, string saltedPass)
        {
            return saltedPass == SaltPasswordWithSalt(passToCompare, salt);
        }
    }
}
