using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> students = new List<string>() { "Jenny", "Peter", "Mary Jane" };
            students.Sort();
            foreach (string name in students)
            {
                listBox1.Items.Add(name);
            }
        }
    }
}
