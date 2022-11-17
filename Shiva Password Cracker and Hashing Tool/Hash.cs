using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    internal abstract class Hash
    {
        private string _clearText;
        private string _cipherText;

        protected Hash(string clearText)
        {
            _clearText = clearText;
        }
        protected Hash(string clearText, string cipherText)
        {
            _clearText = clearText;
            _cipherText = cipherText;
        }
        
        public string ClearText { get { return _clearText; } set { _clearText = value; } }
        public string CipherText { get { return _cipherText; } set { _cipherText = value; } }

        public abstract string hash();
    }
}
