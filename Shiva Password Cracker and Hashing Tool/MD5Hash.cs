using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    internal class MD5Hash : Hash, IHash
    {
        private byte[] _inputBytes;
        public byte[] InputBytes { get { return _inputBytes; } set { _inputBytes = value; } }

        public MD5Hash(string clearText) : base(clearText)
        {
        }
        public MD5Hash(string clearText, string CipherText) : base(clearText, CipherText)
        {
        }

        public override string hash()
        {
            using (MD5 md5 = MD5.Create())
            {
                InputBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(ClearText));
                CipherText = calculateHash(InputBytes);

                return CipherText;
            }
        }
        
        private string calculateHash(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
