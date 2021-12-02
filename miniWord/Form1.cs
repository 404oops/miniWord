using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zanimljivi_projekat
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }
        float size = 12;
        private void button1_Click(object sender, EventArgs e)
        {
            size = size + 4;
            Font fnt = new Font(textBox1.Font.FontFamily, size);
            textBox1.Font = fnt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            size = size - 4;
            Font fnt = new Font(textBox1.Font.FontFamily, size);
            textBox1.Font = fnt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Left;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button6.Text = colorDialog1.Color.Name;
            textBox1.ForeColor = colorDialog1.Color;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Font fnt = new Font(fontDialog1.Font.Name, size);
            textBox1.Font = fnt;
            label1.Text = fontDialog1.Font.Name;
        }
    }
}
