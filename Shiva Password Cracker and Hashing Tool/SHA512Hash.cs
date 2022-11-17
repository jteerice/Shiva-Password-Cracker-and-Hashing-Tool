﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    internal class SHA512Hash : Hash, IHash
    {
        private byte[] _inputBytes;
        public byte[] InputBytes { get { return _inputBytes; } set { _inputBytes = value; } }

        public SHA512Hash(string clearText) : base(clearText)
        {
        }
        public SHA512Hash(string clearText, string CipherText) : base(clearText, CipherText)
        {
        }

        public override string hash()
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                InputBytes = sha512.ComputeHash(Encoding.ASCII.GetBytes(ClearText));
                CipherText = createHash(InputBytes);

                return CipherText;
            }
        }

        private string createHash(byte[] bytes)
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
