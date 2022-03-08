namespace ChangeMoney
{
    public partial class Form1 : Form
    {
        // coin types
        int[] m_coinTypeArray = new int[] { 50, 20, 10, 5 };
        List<TextBox> listTextBoxesChange = new List<TextBox>();
        List<CheckBox> listCheckBoxesChange = new List<CheckBox>();
        public Form1()
        {
            InitializeComponent();
            listTextBoxesChange.Add(textBoxTo50);
            listTextBoxesChange.Add(textBoxTo20);
            listTextBoxesChange.Add(textBoxTo10);
            listTextBoxesChange.Add(textBoxTo5);
            listCheckBoxesChange.Add(checkBox50);
            listCheckBoxesChange.Add(checkBox20);
            listCheckBoxesChange.Add(checkBox10);
            listCheckBoxesChange.Add(checkBox5);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            //int changetotal = Convert.ToInt32(textBoxChangeTotal.Text);
            int changetotal;
            bool isChangeInt = int.TryParse(textBoxChangeTotal.Text, out changetotal);
            if (isChangeInt == false || changetotal <= 0)
            {
                MessageBox.Show("Input should be positive integer!");
            }
            CoinChanger coinchanger = new CoinChanger();
            for (int i = 0; i < m_coinTypeArray.Length; i++)
            {
                if (listCheckBoxesChange[i].Checked)
                {
                    int coinnum = coinchanger.CalculateChangeNumber(m_coinTypeArray[i], changetotal);
                    listTextBoxesChange[i].Text = coinnum.ToString();
                    changetotal = changetotal - coinnum * m_coinTypeArray[i];
                }
                else
                {
                    listTextBoxesChange[i].Text = "0";
                }
            }
            textBoxTo1.Text = changetotal.ToString();
        }
    }
}