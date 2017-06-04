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
        
        public Form1()
        {
            InitializeComponent();
            rad_settime_week.Checked = true;
        }
        void clear_input_grp()
        {
            grp_input_static.Visible = false;
            grp_input_acc_static.Visible = false;
            grp_input_exp.Visible = false;
            grp_input_acc_exp.Visible = false;
        }

        private void lbl_titel_Click(object sender, EventArgs e)
        {
            
        }

        private void rad_mode_static_CheckedChanged(object sender, EventArgs e)
        {
            clear_input_grp();
            grp_input_static.Visible = true;
        }

        private void rad_mode_acc_static_CheckedChanged(object sender, EventArgs e)
        {
            clear_input_grp();
            grp_input_acc_static.Visible = true;
        }

        private void rad_mode_exp_CheckedChanged(object sender, EventArgs e)
        {
            clear_input_grp();
            grp_input_exp.Visible = true;

        }
        private void rad_mode_acc_exp_CheckedChanged(object sender, EventArgs e)
        {
            clear_input_grp();
            grp_input_acc_exp.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_input_static_startsize_TextChanged(object sender, EventArgs e)
        {

        }

        private void grp_input_static_Enter(object sender, EventArgs e)
        {

        }

        private void rad_settime_hour_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_settime_week_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {

        }
    }
}
