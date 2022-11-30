using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    internal class WordLists
    {
        #region Fields
        private List<string> _wordlist;
        private List<IHash> _hashList;
        private string _cipherText;
        private int _format = -1;
        #endregion
        #region Properties
        public List<string> Wordlist { get { return _wordlist; } }
        public List<IHash> Hashlist { get { return _hashList; } }
        public string CipherText { get { return _cipherText; } }
        public int Format { get { return _format; } }
        #endregion
        #region Constructors
        public WordLists(string[] words, int format, string cipherText)
        {
            _wordlist = new List<string>();
            _hashList = new List<IHash>();  
            _wordlist.AddRange(words);  
            _format = format;
            _cipherText = cipherText;   
        }
        #endregion
        #region Methods
        public void createHashList()
        {
            switch (Format)
            {
                case 1:
                    foreach (string word in Wordlist)
                    {
                        MD5Hash md5Hash = new MD5Hash(word);
                        _hashList.Add(md5Hash);
                    }
                    break;
                case 2:
                    foreach (string word in Wordlist)
                    {
                        SHA128Hash sha128Hash = new SHA128Hash(word);
                        _hashList.Add(sha128Hash);
                    }
                    break;
                case 3:
                    foreach (string word in Wordlist)
                    {
                        SHA256Hash sha256Hash = new SHA256Hash(word);
                        _hashList.Add(sha256Hash);
                    }
                    break;
                case 4:
                    foreach (string word in Wordlist)
                    {
                        SHA512Hash sha512Hash = new SHA512Hash(word);
                        _hashList.Add(sha512Hash);
                    }
                    break;
            }
        }
        public string crackCipherText()
        {
            foreach (Hash hash in Hashlist)
            {
                if (hash.hash() == CipherText) return hash.ClearText;
            }
            return "Not found!";
        }
        #endregion
    }
}
