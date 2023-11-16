using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16kasimokul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double fiyat, yenif;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt64(textBox1.Text);
            yenif = fiyat * 1.30;
            label3.Text = Convert.ToString(yenif);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt64(textBox1.Text);
            yenif = fiyat * 0.75;
            label3.Text = Convert.ToString(yenif);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt64(textBox1.Text);
            yenif = fiyat * 0.70;
            label3.Text = Convert.ToString(yenif);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt64(textBox1.Text);
            yenif = fiyat * 1.25;
            label3.Text = Convert.ToString(yenif);
        }
    }
}
