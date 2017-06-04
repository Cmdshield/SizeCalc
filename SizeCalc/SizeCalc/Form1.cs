using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizeCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "HI";
            label2.Text = "Nope";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.Text = "HIHIHIHIIHI";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Text = "NAHAHAHAHAHAh";
        }
    }
}
