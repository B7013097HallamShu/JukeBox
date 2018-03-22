using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JukeBox
{
    public partial class JukeBox_frm : Form
    {
        public JukeBox_frm()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            //opens the setup form when the setup is clicked on the menu 
            Setup_Frm SetupForm2 = new Setup_Frm();
            SetupForm2.ShowDialog();

        }

        private void About_txtBoxMenu_Click(object sender, EventArgs e)
        {
            About_Frm AboutForm2 = new About_Frm();
            AboutForm2.ShowDialog();
        }
    }
}
