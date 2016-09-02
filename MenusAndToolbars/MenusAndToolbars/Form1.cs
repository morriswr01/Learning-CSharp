using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenusAndToolbars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you really like to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
            
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            textBox2.Paste();
        }
    }
}
