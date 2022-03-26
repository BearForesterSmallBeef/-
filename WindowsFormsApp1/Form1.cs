using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int trash;
        long a = 0, b = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 1000;
            if (textBox2.Text.Length == 0) b = 0;
            else if (int.TryParse(textBox2.Text, out trash)) b = int.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.MaxLength = 1001;
            textBox3.Text = Convert.ToString(a + b);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 1000;
            if (textBox1.Text.Length == 0) a = 0;
            else if (int.TryParse(textBox1.Text, out trash)) a = int.Parse(textBox1.Text);
        }
    }
}
