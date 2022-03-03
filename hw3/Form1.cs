using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3
{
    public partial class Form1 : Form
    {
        int age;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //age = Convert.ToInt32(hScrollBar1.Maximum) - Convert.ToInt32(hScrollBar1.LargeChange) + 1;
            age = hScrollBar1.Value;
            textBox1.Text = age.ToString();
            if (age >= 20)
            {
                textBox2.Text = "Congratulation! You have voting right!";
                textBox2.ForeColor = Color.Blue;
            }
            else
            {
                textBox2.Text = "Sorry! You don't have voting right";
                textBox2.ForeColor = Color.Red;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
