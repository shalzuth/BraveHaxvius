using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BraveHaxvius
{
    public class Crypto
    {
        public static String Decrypt(String data, String key)
        {
            return Crypt(data, key, false);
        }
        public static String Encrypt(String data, String key)
        {
            return Crypt(data, key, true);
        }
        public static String Crypt(String data, String key, Boolean encrypt)
        {
            var keyBytes = new Byte[16];
            Array.Copy(Encoding.UTF8.GetBytes(key), keyBytes, key.Length);
            var aes = new AesManaged { Mode = CipherMode.ECB, Key = keyBytes, Padding = PaddingMode.PKCS7 };
            Byte[] uncryptedBytes = encrypt ? Encoding.UTF8.GetBytes(data) : Convert.FromBase64String(data);
            ICryptoTransform transform = encrypt ? aes.CreateEncryptor() : aes.CreateDecryptor();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                    cryptoStream.Write(uncryptedBytes, 0, uncryptedBytes.Length);
                return encrypt ? Convert.ToBase64String(memoryStream.ToArray()) : Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
    }
}
