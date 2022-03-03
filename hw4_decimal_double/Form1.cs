using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4_decimal_double
{
    public partial class Form1 : Form
    {

        System.Diagnostics.Stopwatch stopWatch1 = new System.Diagnostics.Stopwatch();
        System.Diagnostics.Stopwatch stopWatch2 = new System.Diagnostics.Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal deci = Convert.ToDecimal(textBox1.Text);
            double doub = Convert.ToDouble(textBox1.Text);
            stopWatch1.Start();
            for (int i = 0; i < deci; i++) ;
            stopWatch1.Stop();
            double tdeci = stopWatch1.ElapsedMilliseconds;
            labelDeci.Text = tdeci.ToString()+" ms";

            stopWatch2.Start();
            for (int i = 0; i < doub; i++) ;
            stopWatch2.Stop();
            double tdoub = stopWatch2.ElapsedMilliseconds;
            labelDoub.Text = tdoub.ToString() + " ms";

            if (tdeci < tdoub)
                pictureBox1.Image = Properties.Resources.Left;
            else
                pictureBox3.Image = Properties.Resources.Right;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
