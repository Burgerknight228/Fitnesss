using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness228
{
    public partial class Form4 : Form
    {
        static string pathBack = Path.GetFullPath("back.txt");
        static string pathBreast = Path.GetFullPath("breast.txt");
        static string pathArms = Path.GetFullPath("arms.txt");
        static string pathPress = Path.GetFullPath("press.txt");
        static string pathLegs = Path.GetFullPath("legs.txt");
        static string pathClicks = Path.GetFullPath("clicks.txt");
        static string pathClik = Path.GetFullPath("clik.txt");
        double back = Convert.ToDouble(File.ReadAllText(pathBack));
        double breast = Convert.ToDouble(File.ReadAllText(pathBreast));
        double arms = Convert.ToDouble(File.ReadAllText(pathArms));
        double press = Convert.ToDouble(File.ReadAllText(pathPress));
        double legs = Convert.ToDouble(File.ReadAllText(pathLegs));
        double clicks = Convert.ToDouble(File.ReadAllText(pathClicks));
        double clik = Convert.ToDouble(File.ReadAllText(pathClik));

        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            label6.Text = $"Стоимость: {Math.Round(back, 7)}";
            label7.Text = $"Стоимость: {Math.Round(breast, 7)}";
            label8.Text = $"Стоимость: {Math.Round(arms, 7)}";
            label9.Text = $"Стоимость: {Math.Round(press, 7)}";
            label10.Text = $"Стоимость: {Math.Round(legs, 7)}";
            back = Convert.ToDouble(File.ReadAllText(pathBack));
            breast = Convert.ToDouble(File.ReadAllText(pathBreast));
            arms = Convert.ToDouble(File.ReadAllText(pathArms));
            press = Convert.ToDouble(File.ReadAllText(pathPress));
            legs = Convert.ToDouble(File.ReadAllText(pathLegs));
            clicks = Convert.ToDouble(File.ReadAllText(pathClicks));
            clik = Convert.ToDouble(File.ReadAllText(pathClik));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.clicks - this.back <= 0) { }
            else
            {
                this.clicks -= this.back;
                this.clik *= 1.2;
                this.back *= 1.2;
                string[] lines = { Convert.ToString(this.clik) };
                File.WriteAllLines(pathClik, lines);
                string[] lines1 = { Convert.ToString(this.back) };
                File.WriteAllLines(pathBack, lines1);
                string[] lines2 = { Convert.ToString(this.clicks) };
                File.WriteAllLines(pathClicks, lines2);
                label6.Text = $"Стоимость: {Math.Round(Math.Round(back, 7))}";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.clicks - this.breast <= 0) { }
            else
            {
                this.clicks -= this.breast;
                this.clik *= 1.2;
                this.breast *= 1.2;
                string[] lines = { Convert.ToString(this.clik) };
                File.WriteAllLines(pathClik, lines);
                string[] lines1 = { Convert.ToString(this.breast) };
                File.WriteAllLines(pathBreast, lines1);
                string[] lines2 = { Convert.ToString(this.clicks) };
                File.WriteAllLines(pathClicks, lines2);
                label7.Text = $"Стоимость: {Math.Round(breast, 7)}";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.clicks - this.arms <= 0) { }
            else
            {

                this.clicks -= this.arms;
                this.clik *= 1.2;
                this.arms *= 1.2;
                string[] lines = { Convert.ToString(this.clik) };
                File.WriteAllLines(pathClik, lines);
                string[] lines1 = { Convert.ToString(this.arms) };
                File.WriteAllLines(pathArms, lines1);
                string[] lines2 = { Convert.ToString(this.clicks) };
                File.WriteAllLines(pathClicks, lines2);
                label8.Text = $"Стоимость: {Math.Round(arms, 7)}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.clicks - this.press <= 0) { }
            else
            {

                this.clicks -= this.press;
                this.clik *= 1.2;
                this.press *= 1.2;
                string[] lines = { Convert.ToString(this.clik) };
                File.WriteAllLines(pathClik, lines);
                string[] lines1 = { Convert.ToString(this.press) };
                File.WriteAllLines(pathPress, lines1);
                string[] lines2 = { Convert.ToString(this.clicks) };
                File.WriteAllLines(pathClicks, lines2);
                label9.Text = $"Стоимость: {Math.Round(press, 7)}";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.clicks - this.legs <= 0) { }
            else
            {

                this.clicks -= this.legs;
                this.clik *= 1.2;
                this.legs *= 1.2;
                string[] lines = { Convert.ToString(this.clik) };
                File.WriteAllLines(pathClik, lines);
                string[] lines1 = { Convert.ToString(this.legs) };
                File.WriteAllLines(pathLegs, lines1);
                string[] lines2 = { Convert.ToString(this.clicks) };
                File.WriteAllLines(pathClicks, lines);
                label10.Text = $"Стоимость: {Math.Round(legs, 7)}";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
