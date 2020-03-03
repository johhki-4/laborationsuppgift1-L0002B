// Johannes Håkansson 931011-5119   L0002B

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Inlamingsuppgift3.Person;

namespace Inlamingsuppgift3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //allting sker när man trycker på "submit"-knappen.
        private void button1_Click(object sender, EventArgs e)
        {
            String fNamn = textBox1.Text.ToString();
            String eNamn = textBox2.Text.ToString();
            String ssn = textBox3.Text.ToString();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();

            richTextBox1.AppendText(fNamn + " ");
            richTextBox1.AppendText(eNamn + ", ");
            richTextBox1.AppendText(ssn + ". ");

            //en ny instans av klassen person skapas, med all data som skrevs in nyss.
            Person person = new Person(fNamn, eNamn, ssn);

            richTextBox1.AppendText(System.Environment.NewLine);
            richTextBox1.AppendText(person.ControlNumber());
            richTextBox1.AppendText(System.Environment.NewLine);
            richTextBox1.AppendText(person.DetermineSex());
        }
    }
}
