using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    internal class MD5 : Hash, IHash
    {
        private byte[] _inputBytes;
        private byte[] _hashBytes;
        public byte[] InputBytes { get { return _inputBytes; } set { _inputBytes = value; } }
        public byte[] HashBytes { get { return _hashBytes; } set { _hashBytes = value; } }
        public MD5(string clearText, string CipherText) : base(clearText, CipherText)
        {
        }

        public override string hash()
        {
            InputBytes = Encoding.ASCII.GetBytes(ClearText);
            HashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(InputBytes);

            return Convert.ToString(HashBytes);
            
        }  
    }
}
