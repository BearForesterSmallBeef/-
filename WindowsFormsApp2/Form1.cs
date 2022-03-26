using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int n = 1, place_cost = 0, eat_cost = 0, summa = 0, b = 0;
        bool iscoef = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                place_cost = 1000;
                iscoef = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) n = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) n = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) n = 5;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) n = 10;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                place_cost = 0;
                iscoef = false;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                place_cost = 10000;
                iscoef = false;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                place_cost = 500;
                iscoef = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) eat_cost += 100;
            else eat_cost -= 100;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) eat_cost += 150;
            else eat_cost -= 150;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) eat_cost += 50;
            else eat_cost -= 50;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) eat_cost += 75;
            else eat_cost -= 75;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) eat_cost += 100;
            else eat_cost -= 100;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked) eat_cost += 80;
            else eat_cost -= 80;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked) eat_cost += 25;
            else eat_cost -= 25;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked) eat_cost += 70;
            else eat_cost -= 70;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked) eat_cost += 60;
            else eat_cost -= 60;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) eat_cost += 40;
            else eat_cost -= 40;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            summa = place_cost * ((iscoef) ? n:1) + eat_cost * n;
            label3.Text = Convert.ToString(summa);
            if (!(summa <= b))
            {
                pictureBox1.Image = Properties.Resources.kartinki_gifki_humoraf_ru_58;
            }
            else pictureBox1.Image = Properties.Resources.Btl;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                place_cost = 20000;
                iscoef = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) n = 100;
        }
    }
}
