namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = "0";
            this.textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "OK";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            
            int num1 = Convert.ToInt32(this.textBox1.Text);
            int num2 = Convert.ToInt32(this.textBox2.Text);
            int result = num1 + num2;
            this.label2.Text = Convert.ToString(result);
        }
    }
}
