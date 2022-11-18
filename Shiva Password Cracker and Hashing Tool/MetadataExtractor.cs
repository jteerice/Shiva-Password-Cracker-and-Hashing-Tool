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
    public partial class Metadata_Extractor : Form
    {
        public Metadata_Extractor()
        {
            InitializeComponent();
        }

        private void Metadata_Extractor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowse = new OpenFileDialog();
            fileBrowse.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG"; // Only show txt files
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

        private void btnExtract_Click(object sender, EventArgs e)
        {
            resultsText.Clear();
            ImageFile image = new ImageFile(pathText.Text);
            image.extractData();
            foreach (String property in image.Results)
            {
                resultsText.AppendText($"{property}\n");
            }
        }
    }
}
