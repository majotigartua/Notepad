using System.Security.Cryptography;
using System.Text;

namespace Notepad.Utilities
{
    public static class Utilities
    {
        public static string ComputeSHA256Hash(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hashedPassword = new StringBuilder();
                for (int bit = 0; bit < (bytes.Length); bit++)
                {
                    hashedPassword.Append(bytes[bit].ToString("x2"));
                }
                return hashedPassword.ToString();
            }
        }
    }
}