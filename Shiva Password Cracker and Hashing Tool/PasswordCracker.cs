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
    }
}
