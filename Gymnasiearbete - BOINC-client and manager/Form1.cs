using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gymnasiearbete___BOINC_client_and_manager
{
    public partial class oliversBoincManagerForm : Form
    {
        public oliversBoincManagerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dedicatedResourcesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oliversBoincManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to quit BOINC manager? \nIf there are any active transfers currently taking place then BOINC manager will wait for those transfers to finish and only then close.", "Exit?", MessageBoxButtons.YesNo);

            if(dialog == DialogResult.Yes)
            {
                // here goes line of code to quit the program after all transfers have been completed
                // all transfers should complete and only then should the program close

                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
                
            }
        }

        private void oliversBoincManagerForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
