using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            label1.Text = "Вы нажали: " + e.KeyChar.ToString();
            if (e.KeyChar.ToString() == "w" || e.KeyChar.ToString() == "W"){
                label1.Text = "1";
                Random rnd = new Random();
                Button this.some_bottone = new System.Windows.Forms.Button();
                some_bottone.Width = rnd.Next(10, this.Width - 100);
                some_bottone.Height = rnd.Next(10, this.Height - 100);
                some_bottone.Location = new Point(rnd.Next(10, this.Width - some_bottone.Width - 10), rnd.Next(10, this.Height - some_bottone.Height - 10));
                some_bottone.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                some_bottone.Text = "теневое клонирование";
            }
        }
    }
}
