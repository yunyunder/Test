namespace hw1
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(numBox1.Text);
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            sumBox.Text = Convert.ToString(num1 + num2);
        }

        private void numBox2_TextChanged(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(numBox2.Text);
        }

        private void sumBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}