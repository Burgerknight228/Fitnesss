using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace Fitness228
{
    public partial class Form3 : Form
    {
        static string pathClicks = Path.GetFullPath("clicks.txt");
        static string pathClik = Path.GetFullPath("clik.txt");
        double clicks = Convert.ToDouble(File.ReadAllText(pathClicks));
        double clik = Convert.ToDouble(File.ReadAllText(pathClik));

        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            clicks = Convert.ToDouble(File.ReadAllText(pathClicks));
            clik = Convert.ToDouble(File.ReadAllText(pathClik));
            label1.Text = $"Мышцы: {Math.Round(this.clicks, 4)}";
            label2.Text = $"Вы делаете: {Math.Round(clik, 4)} за повторение";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = { Convert.ToString(clicks) };
            File.WriteAllLines(pathClicks,lines);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Size = new Size(button2.Size.Width + 10, button2.Size.Height + 10);
            button2.Location = new Point(265,115);
            this.clicks += this.clik;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Size = new Size(button2.Size.Width - 10, button2.Size.Height - 10);
            button2.Location = new Point(270, 120);
            label1.Text = $"Мышцы: {Math.Round(this.clicks,4)}";
        }
    }
}
