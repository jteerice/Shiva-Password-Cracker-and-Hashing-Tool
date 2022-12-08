using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WordList;

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    public partial class Password_Cracker : Form
    {
        #region Fields
        private int _format = -1;
        #endregion
        #region Properties
        public int Format { get { return _format; } set { _format = value; } }
        #endregion
        #region Constructor
        public Password_Cracker()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void Password_Cracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowse = new OpenFileDialog();
            fileBrowse.Filter = "Text files (*.txt)|*.txt"; // Only show txt files
            if (fileBrowse.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pathText.Text = fileBrowse.FileName; 
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: Please select a valid file");
                }
            }
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            if (CipherText.Text == "")
            {
                MessageBox.Show("Please enter a hash to crack.");
            }
            else if (pathText.Text == "")
            {
                MessageBox.Show("Please select a word list.");
            }
            else
            {
                string path = pathText.Text;
                string[] words = File.ReadAllLines($@"{path}");
                WordLists lists = new WordLists(words, Format, CipherText.Text);
                lists.createHashList();
                ClearText.Text = lists.crackCipherText();  
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Format = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Format = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Format = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Format = 4;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/brannondorsey/naive-hashcat/releases/download/data/rockyou.txt");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/danielmiessler/SecLists/tree/master/Passwords");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CipherText.Text = "";
            pathText.Text = "";
            ClearText.Text = "";
        }
        #endregion
    }
}
