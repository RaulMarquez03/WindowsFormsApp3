using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int result_1 = number1 * 2;

            textBox3.Text = result_1.ToString();
            int result_2 = number1 /2;
            textBox4.Text = result_2.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            float number2 = float.Parse(textBox2.Text);
            float result_1 = number2 * 2;
            textBox3.Text = result_1.ToString();
            float result_2 = number2 /2;
            textBox4.Text = result_2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
