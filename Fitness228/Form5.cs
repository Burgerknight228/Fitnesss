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
    public partial class Form5 : Form
    {
        static string pathBack = Path.GetFullPath("back.txt");
        static string pathBreast = Path.GetFullPath("breast.txt");
        static string pathArms = Path.GetFullPath("arms.txt");
        static string pathPress = Path.GetFullPath("press.txt");
        static string pathLegs = Path.GetFullPath("legs.txt");
        static string pathClicks = Path.GetFullPath("clicks.txt");
        static string pathClik = Path.GetFullPath("clik.txt");
        string[] back = { Convert.ToString(0.1) };
        string[] breast = { Convert.ToString(0.1) };
        string[] arms = { Convert.ToString(0.1) };
        string[] press = { Convert.ToString(0.1) };
        string[] legs = { Convert.ToString(0.1) };
        string[] clicks = { Convert.ToString(0) };
        string[] clik = { Convert.ToString(0.001) };

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(pathBack, back);
            File.WriteAllLines(pathBreast, breast);
            File.WriteAllLines(pathArms, arms);
            File.WriteAllLines(pathPress, press);
            File.WriteAllLines(pathLegs, legs);
            File.WriteAllLines(pathClicks, clicks);
            File.WriteAllLines(pathClik, clik);
            this.Close();
        }
    }
}
