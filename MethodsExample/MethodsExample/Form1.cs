using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int answer = Add(int.Parse(num1.Text), int.Parse(num2.Text));
        }
        private int Add(int firstNumber, int secondNumber)
        {
            int total = firstNumber + secondNumber;
            MessageBox.Show(total.ToString());
            return total;
        }






    }
}
