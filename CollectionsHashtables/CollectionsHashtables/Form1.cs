using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsHashtables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Subjects { English, IT, Science, Design, Math };

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable students = new Hashtable();
            students.Add("Jenny", 87);
            students.Add("Peter", "No score");
            students.Add("Mary Jane", 64);
            students.Add("Azhar", 79);

            foreach (DictionaryEntry child in students)
            {
                listBox1.Items.Add("Student: " + child.Key + " - " + child.Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subjects newSubject = Subjects.Science;
        }
    }
}
