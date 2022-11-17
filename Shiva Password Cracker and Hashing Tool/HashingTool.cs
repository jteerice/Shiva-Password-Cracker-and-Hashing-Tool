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
                    MD5Hash hash = new MD5Hash(clearText);
                    cipherText = hash.hash();
                    CipherText.Text = cipherText;
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
            ClearText.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Format = 1;
        }
    }
}
