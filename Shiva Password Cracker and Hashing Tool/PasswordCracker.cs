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

namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    public partial class Password_Cracker : Form
    {
        private int _format = -1;
        public int Format { get { return _format; } set { _format = value; } }
        public Password_Cracker()
        {
            InitializeComponent();
        }

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
                throw new Exception("Please enter a hash to crack.");
            }
            else
            {
                string path = pathText.Text;
                string[] words = File.ReadAllLines($@"{path}");
                WordLists lists = new WordLists(words, Format, CipherText.Text);
                lists.createHashList();
                
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
    }
}
