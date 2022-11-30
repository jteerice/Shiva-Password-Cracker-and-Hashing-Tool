using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    internal abstract class Hash
    {
        #region Fields
        private string _clearText;
        private string _cipherText;
        #endregion
        #region Constructors
        protected Hash(string clearText)
        {
            _clearText = clearText;
        }
        protected Hash(string clearText, string cipherText)
        {
            _clearText = clearText;
            _cipherText = cipherText;
        }
        #endregion
        #region Properties
        public string ClearText { get { return _clearText; } set { _clearText = value; } }
        public string CipherText { get { return _cipherText; } set { _cipherText = value; } }
        #endregion
        #region Methods
        public abstract string hash();
        #endregion
    }
}
