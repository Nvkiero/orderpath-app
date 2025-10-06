using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
    

namespace BTT3_RegForm
{
    public partial class OrderPath : Form
    {
        public OrderPath()
        {
            InitializeComponent();
        }

        private void OrderPath_Load(object sender, EventArgs e)
        {
            txb_name.MaxLength = 30;
            txb_email.MaxLength = 50;
            txb_sdt.MaxLength = 11;
            txb_user.MaxLength = 20;
            txb_pass.MaxLength = 50;
            txb_pass2.MaxLength = 30;
            txb_address.MaxLength = 30;
        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbox_day_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbox_month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbox_year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbtn_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtn_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_pass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_showp1_Click(object sender, EventArgs e)
        {
            if (txb_pass.PasswordChar == '*')
            {
                btn_hidep1.BringToFront();
                txb_pass.PasswordChar = '\0';
            }
        }

        private void btn_showp2_Click(object sender, EventArgs e)
        {
            if (txb_pass2.PasswordChar == '*')
            {
                btn_hidep2.BringToFront();
                txb_pass2.PasswordChar = '\0';
            }
        }

        private void btn_hidep1_Click(object sender, EventArgs e)
        {
            if (txb_pass.PasswordChar == '\0')
            {
                btn_showp1.BringToFront();
                txb_pass.PasswordChar = '*';
            }
        }

        private void btn_hidep2_Click(object sender, EventArgs e)
        {
            if (txb_pass2.PasswordChar == '\0')
            {
                btn_showp2.BringToFront();
                txb_pass2.PasswordChar = '*';
            }
        }


        private void btn_signup_Click(object sender, EventArgs e)
        {

        }
    }
}
