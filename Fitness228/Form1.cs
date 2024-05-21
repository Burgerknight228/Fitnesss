namespace Fitness228
{
    public partial class Form1 : Form
    {

        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        public Form1()
        {
            InitializeComponent();
        }

        private void icon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form5.ShowDialog();
        }
    }
}
