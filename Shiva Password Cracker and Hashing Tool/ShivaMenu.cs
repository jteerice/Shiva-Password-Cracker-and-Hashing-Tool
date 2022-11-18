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
    public partial class Shiva_Menu : Form
    {
        public Shiva_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Password_Cracker pc = new Password_Cracker();
            pc.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hashing_Tool ht = new Hashing_Tool();
            ht.ShowDialog();
        }

        private void btnMetaDataExtractor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Metadata_Extractor mde = new Metadata_Extractor();
            mde.ShowDialog();
        }
    }
}
