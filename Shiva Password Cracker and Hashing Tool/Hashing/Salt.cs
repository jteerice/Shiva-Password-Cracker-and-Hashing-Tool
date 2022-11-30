using System;
using System.Linq;
using System.Text;

namespace Shiva_Password_Cracker_and_Hashing_Tool.HashClasses
{
    internal class Salt
    {
        #region Fields
        private static readonly char[] characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
        private int _size;
        private string _asciiSalt;
        #endregion
        #region Properties
        public char[] Characters { get { return characters; } }
        public int Size { get { return _size; } }
        public string AsciiSalt { get { return _asciiSalt; } set { _asciiSalt = value; } }
        #endregion
        #region Constructors
        public Salt(int size)
        {
            _size = size;
            _asciiSalt = "";
        }
        #endregion
        #region Methods
        public void GenerateSalt()
        {
            Random rng = new Random();
            StringBuilder sb = new StringBuilder(Size);

            for (int i = 0; i < Size; i++)
            {
                sb.Append(Characters[rng.Next(Characters.Length)]);
            }

            AsciiSalt = sb.ToString();
        }
        #endregion
    }
}
