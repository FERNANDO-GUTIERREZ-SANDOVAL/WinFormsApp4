namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        int sum, num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);
            int sum = num1 + num2;
            label3.Text = "sum = " + sum;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}