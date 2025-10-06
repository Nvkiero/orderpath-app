namespace BTT3_RegForm
{
    partial class OrderPath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txb_name = new TextBox();
            txb_email = new TextBox();
            txb_sdt = new TextBox();
            txb_pass = new TextBox();
            groupBox1 = new GroupBox();
            rdbtn_female = new RadioButton();
            rdbtn_male = new RadioButton();
            groupBox2 = new GroupBox();
            cbbox_day = new ComboBox();
            cbbox_month = new ComboBox();
            cbbox_year = new ComboBox();
            txb_pass2 = new TextBox();
            txb_user = new TextBox();
            txb_address = new TextBox();
            btn_signup = new Button();
            llabel_login = new LinkLabel();
            label2 = new Label();
            btn_showp1 = new Button();
            btn_showp2 = new Button();
            btn_hidep1 = new Button();
            btn_hidep2 = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            groupBox8 = new GroupBox();
            groupBox9 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(353, 9);
            label1.Name = "label1";
            label1.Size = new Size(363, 54);
            label1.TabIndex = 0;
            label1.Text = "Tạo tài khoản mới";
            // 
            // txb_name
            // 
            txb_name.Location = new Point(0, 29);
            txb_name.Margin = new Padding(3, 2, 3, 2);
            txb_name.Name = "txb_name";
            txb_name.Size = new Size(651, 31);
            txb_name.TabIndex = 1;
            txb_name.TextChanged += txb_name_TextChanged;
            // 
            // txb_email
            // 
            txb_email.Location = new Point(7, 29);
            txb_email.Margin = new Padding(3, 2, 3, 2);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(651, 31);
            txb_email.TabIndex = 2;
            txb_email.TextChanged += txb_email_TextChanged;
            // 
            // txb_sdt
            // 
            txb_sdt.Location = new Point(6, 32);
            txb_sdt.Margin = new Padding(3, 2, 3, 2);
            txb_sdt.Name = "txb_sdt";
            txb_sdt.Size = new Size(651, 31);
            txb_sdt.TabIndex = 3;
            txb_sdt.TextChanged += txb_sdt_TextChanged;
            // 
            // txb_pass
            // 
            txb_pass.Location = new Point(0, 29);
            txb_pass.Margin = new Padding(3, 2, 3, 2);
            txb_pass.Name = "txb_pass";
            txb_pass.PasswordChar = '*';
            txb_pass.Size = new Size(651, 31);
            txb_pass.TabIndex = 5;
            txb_pass.TextChanged += txb_pass_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbtn_female);
            groupBox1.Controls.Add(rdbtn_male);
            groupBox1.Location = new Point(681, 138);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(177, 67);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // rdbtn_female
            // 
            rdbtn_female.AutoSize = true;
            rdbtn_female.Font = new Font("Segoe UI", 9F);
            rdbtn_female.Location = new Point(101, 29);
            rdbtn_female.Margin = new Padding(3, 2, 3, 2);
            rdbtn_female.Name = "rdbtn_female";
            rdbtn_female.Size = new Size(61, 29);
            rdbtn_female.TabIndex = 1;
            rdbtn_female.TabStop = true;
            rdbtn_female.Text = "Nữ";
            rdbtn_female.UseVisualStyleBackColor = true;
            rdbtn_female.CheckedChanged += rdbtn_female_CheckedChanged;
            // 
            // rdbtn_male
            // 
            rdbtn_male.AutoSize = true;
            rdbtn_male.Font = new Font("Segoe UI", 9F);
            rdbtn_male.Location = new Point(7, 29);
            rdbtn_male.Margin = new Padding(3, 2, 3, 2);
            rdbtn_male.Name = "rdbtn_male";
            rdbtn_male.Size = new Size(75, 29);
            rdbtn_male.TabIndex = 0;
            rdbtn_male.TabStop = true;
            rdbtn_male.Text = "Nam";
            rdbtn_male.UseVisualStyleBackColor = true;
            rdbtn_male.CheckedChanged += rdbtn_male_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbox_day);
            groupBox2.Controls.Add(cbbox_month);
            groupBox2.Controls.Add(cbbox_year);
            groupBox2.Location = new Point(207, 130);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(452, 75);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ngày sinh";
            // 
            // cbbox_day
            // 
            cbbox_day.FormattingEnabled = true;
            cbbox_day.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cbbox_day.Location = new Point(7, 29);
            cbbox_day.Margin = new Padding(3, 2, 3, 2);
            cbbox_day.Name = "cbbox_day";
            cbbox_day.Size = new Size(129, 33);
            cbbox_day.TabIndex = 14;
            cbbox_day.SelectedIndexChanged += cbbox_day_SelectedIndexChanged;
            // 
            // cbbox_month
            // 
            cbbox_month.FormattingEnabled = true;
            cbbox_month.Items.AddRange(new object[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" });
            cbbox_month.Location = new Point(157, 28);
            cbbox_month.Margin = new Padding(3, 2, 3, 2);
            cbbox_month.Name = "cbbox_month";
            cbbox_month.Size = new Size(129, 33);
            cbbox_month.TabIndex = 13;
            cbbox_month.SelectedIndexChanged += cbbox_month_SelectedIndexChanged;
            // 
            // cbbox_year
            // 
            cbbox_year.FormattingEnabled = true;
            cbbox_year.Items.AddRange(new object[] { "2025", "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909", "1908", "1907", "1906", "1905" });
            cbbox_year.Location = new Point(306, 28);
            cbbox_year.Margin = new Padding(3, 2, 3, 2);
            cbbox_year.Name = "cbbox_year";
            cbbox_year.Size = new Size(129, 33);
            cbbox_year.TabIndex = 12;
            cbbox_year.SelectedIndexChanged += cbbox_year_SelectedIndexChanged;
            // 
            // txb_pass2
            // 
            txb_pass2.Location = new Point(0, 29);
            txb_pass2.Margin = new Padding(3, 2, 3, 2);
            txb_pass2.Name = "txb_pass2";
            txb_pass2.PasswordChar = '*';
            txb_pass2.Size = new Size(651, 31);
            txb_pass2.TabIndex = 9;
            txb_pass2.TextChanged += txb_pass2_TextChanged;
            // 
            // txb_user
            // 
            txb_user.Location = new Point(0, 29);
            txb_user.Margin = new Padding(3, 2, 3, 2);
            txb_user.Name = "txb_user";
            txb_user.Size = new Size(651, 31);
            txb_user.TabIndex = 6;
            txb_user.TextChanged += txb_user_TextChanged;
            // 
            // txb_address
            // 
            txb_address.Location = new Point(0, 29);
            txb_address.Margin = new Padding(3, 2, 3, 2);
            txb_address.Name = "txb_address";
            txb_address.Size = new Size(651, 31);
            txb_address.TabIndex = 10;
            txb_address.TextChanged += txb_address_TextChanged;
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(426, 586);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(207, 44);
            btn_signup.TabIndex = 11;
            btn_signup.Text = "Đăng ký";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // llabel_login
            // 
            llabel_login.AutoSize = true;
            llabel_login.LinkColor = Color.Black;
            llabel_login.Location = new Point(559, 644);
            llabel_login.Name = "llabel_login";
            llabel_login.Size = new Size(100, 25);
            llabel_login.TabIndex = 12;
            llabel_login.TabStop = true;
            llabel_login.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 644);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 13;
            label2.Text = "Đã có tài khoản?";
            // 
            // btn_showp1
            // 
            btn_showp1.FlatStyle = FlatStyle.Flat;
            btn_showp1.Location = new Point(573, 29);
            btn_showp1.Name = "btn_showp1";
            btn_showp1.Size = new Size(78, 31);
            btn_showp1.TabIndex = 14;
            btn_showp1.Text = "Show";
            btn_showp1.UseVisualStyleBackColor = true;
            btn_showp1.Click += btn_showp1_Click;
            // 
            // btn_showp2
            // 
            btn_showp2.FlatStyle = FlatStyle.Flat;
            btn_showp2.Location = new Point(575, 29);
            btn_showp2.Name = "btn_showp2";
            btn_showp2.Size = new Size(78, 31);
            btn_showp2.TabIndex = 15;
            btn_showp2.Text = "Show";
            btn_showp2.UseVisualStyleBackColor = true;
            btn_showp2.Click += btn_showp2_Click;
            // 
            // btn_hidep1
            // 
            btn_hidep1.FlatStyle = FlatStyle.Flat;
            btn_hidep1.Location = new Point(573, 29);
            btn_hidep1.Name = "btn_hidep1";
            btn_hidep1.Size = new Size(78, 31);
            btn_hidep1.TabIndex = 16;
            btn_hidep1.Text = "Hide";
            btn_hidep1.UseVisualStyleBackColor = true;
            btn_hidep1.Click += btn_hidep1_Click;
            // 
            // btn_hidep2
            // 
            btn_hidep2.FlatStyle = FlatStyle.Flat;
            btn_hidep2.Location = new Point(575, 29);
            btn_hidep2.Name = "btn_hidep2";
            btn_hidep2.Size = new Size(78, 31);
            btn_hidep2.TabIndex = 17;
            btn_hidep2.Text = "Hide";
            btn_hidep2.UseVisualStyleBackColor = true;
            btn_hidep2.Click += btn_hidep2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txb_email);
            groupBox3.Location = new Point(207, 210);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(651, 71);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txb_name);
            groupBox4.Location = new Point(207, 54);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(651, 71);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Họ và tên";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txb_sdt);
            groupBox5.Location = new Point(207, 290);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(651, 71);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            groupBox5.Text = "Số điện thoại";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txb_user);
            groupBox6.Location = new Point(425, 65);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(651, 71);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tên đăng nhập";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(btn_showp1);
            groupBox7.Controls.Add(btn_hidep1);
            groupBox7.Controls.Add(txb_pass);
            groupBox7.Location = new Point(207, 432);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(651, 71);
            groupBox7.TabIndex = 20;
            groupBox7.TabStop = false;
            groupBox7.Text = "Password";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(btn_showp2);
            groupBox8.Controls.Add(btn_hidep2);
            groupBox8.Controls.Add(txb_pass2);
            groupBox8.Location = new Point(207, 509);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(651, 71);
            groupBox8.TabIndex = 21;
            groupBox8.TabStop = false;
            groupBox8.Text = "Xác thực password";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txb_address);
            groupBox9.Controls.Add(groupBox6);
            groupBox9.Location = new Point(207, 367);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(651, 71);
            groupBox9.TabIndex = 21;
            groupBox9.TabStop = false;
            groupBox9.Text = "Địa chỉ";
            // 
            // OrderPath
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 675);
            Controls.Add(groupBox9);
            Controls.Add(label1);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(llabel_login);
            Controls.Add(btn_signup);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrderPath";
            Text = "OrderPath";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txb_name;
        private TextBox txb_email;
        private TextBox txb_sdt;
        private TextBox txb_pass;
        private GroupBox groupBox1;
        private RadioButton rdbtn_male;
        private RadioButton rdbtn_female;
        private GroupBox groupBox2;
        private ComboBox cbbox_year;
        private ComboBox cbbox_day;
        private ComboBox cbbox_month;
        private TextBox txb_pass2;
        private TextBox txb_user;
        private TextBox txb_address;
        private Button btn_signup;
        private LinkLabel llabel_login;
        private Label label2;
        private Button btn_showp1;
        private Button btn_showp2;
        private Button btn_hidep1;
        private Button btn_hidep2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private GroupBox groupBox9;
    }
}