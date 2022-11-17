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
    }
}
