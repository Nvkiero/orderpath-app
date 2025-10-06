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
using System.Net.WebSockets;


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
            rdbtn_female.Checked = false;
            rdbtn_male.Checked = false;
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

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string condition = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, condition, RegexOptions.IgnoreCase);
        }
        private DateTime? GetDoB()
        {
            int d, m, y;
            if (int.TryParse(cbbox_day.Text, out d) &&
                int.TryParse(cbbox_month.Text, out m) &&
                int.TryParse(cbbox_year.Text, out y))
            {
                try { return new DateTime(y, m, d); }
                catch { return null; }
            }
            return null;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string fullName = txb_name.Text.Trim();
            DateTime? dob = GetDoB();
            string gender = rdbtn_male.Checked ? "Nam" : rdbtn_female.Checked ? "Nữ" : null;
            string email = txb_email.Text.Trim();
            string phone = txb_sdt.Text.Trim();
            string address = txb_address.Text.Trim();
            string username = txb_user.Text.Trim();
            string pass = txb_pass.Text;
            string pass2 = txb_pass2.Text;

            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(fullName)) errors.Add("Họ và tên không được để trống");
            if (!dob.HasValue) errors.Add("Ngày sinh không hợp lệ");
            if (string.IsNullOrWhiteSpace(gender)) errors.Add("Chưa chọn giới tính");
            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email)) errors.Add("Email không hợp lệ");
            if (string.IsNullOrWhiteSpace(username)) errors.Add("Username không được để trống");
            if (string.IsNullOrWhiteSpace(pass)) errors.Add("Mật khẩu không được để trống");
            if (pass != pass2) errors.Add("Xác nhận mật khẩu sai");

            if (errors.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, errors), "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

        }

        private void llabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ok
        }
    }
}
