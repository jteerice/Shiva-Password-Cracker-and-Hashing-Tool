using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    public partial class Hashing_Tool : Form
    {
        private int _format;

        public int Format { get { return _format; } set { _format = value; } } 
        public Hashing_Tool()
        {
            InitializeComponent();
        }

        private void Hashing_Tool_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clearText = ClearText.Text;
            string cipherText;

            switch (Format)
            {
                case 1:
                    MD5Hash md5hash = new MD5Hash(clearText);
                    cipherText = md5hash.hash();
                    CipherText.Text = cipherText;
                    break;
                case 2:
                    SHA128Hash sha128hash = new SHA128Hash(clearText);
                    cipherText = sha128hash.hash();
                    CipherText.Text = cipherText;
                    break;
                case 3:
                    SHA256Hash sha256hash = new SHA256Hash(clearText);
                    cipherText = sha256hash.hash();
                    CipherText.Text = cipherText;
                    break;
                case 4:
                    SHA512Hash sha512hash = new SHA512Hash(clearText);
                    cipherText = sha512hash.hash();
                    CipherText.Text = cipherText;
                    break;
            }
            ClearText.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Format = 1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Format = 4;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Format = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Format = 2;
        }
    }
}
