using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysAndLoopsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Size can be set at runtime and therefoe3 can be a variable.
            int[] lotteryNumbers = new int[4] { 1, 2, 3, 4 };
            foreach (int number in lotteryNumbers)
            {
                listBox1.Items.Add(number);
            }
        }
    }
}
