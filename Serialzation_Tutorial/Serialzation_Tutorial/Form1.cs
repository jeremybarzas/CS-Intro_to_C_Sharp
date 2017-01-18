using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialzation_Tutorial
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student currentStudent = new Student(this.textBox1.Text, (int)this.numericUpDown1.Value, this.textBox2.Text);

            DataManagement<Student>.Serialize("Student", currentStudent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student lastStudent = DataManagement<Student>.Deserialize("Student");
            this.textBox1.Text = lastStudent.Name;
            this.numericUpDown1.Value = lastStudent.Age;
            this.textBox2.Text = lastStudent.ID;
        }
    }
}