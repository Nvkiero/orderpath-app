namespace ProjectTuan3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_dangnhap = new Label();
            lb_tendangnhap = new Label();
            lb_passwd = new Label();
            btn_dangnhap = new Button();
            btn_quenmatkhau = new Button();
            button3 = new Button();
            tb_tendangnhap = new MaskedTextBox();
            tb_passwd = new MaskedTextBox();
            SuspendLayout();
            // 
            // lb_dangnhap
            // 
            lb_dangnhap.AutoSize = true;
            lb_dangnhap.BackColor = SystemColors.ControlLight;
            lb_dangnhap.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb_dangnhap.ForeColor = Color.Red;
            lb_dangnhap.Location = new Point(415, 13);
            lb_dangnhap.Margin = new Padding(4, 0, 4, 0);
            lb_dangnhap.Name = "lb_dangnhap";
            lb_dangnhap.Size = new Size(205, 48);
            lb_dangnhap.TabIndex = 0;
            lb_dangnhap.Text = "Đăng nhập";
            lb_dangnhap.Click += label1_Click;
            // 
            // lb_tendangnhap
            // 
            lb_tendangnhap.AutoSize = true;
            lb_tendangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb_tendangnhap.Location = new Point(249, 95);
            lb_tendangnhap.Margin = new Padding(4, 0, 4, 0);
            lb_tendangnhap.Name = "lb_tendangnhap";
            lb_tendangnhap.Size = new Size(275, 32);
            lb_tendangnhap.TabIndex = 1;
            lb_tendangnhap.Text = "Username/ Gmail/ SĐT";
            lb_tendangnhap.Click += label2_Click;
            // 
            // lb_passwd
            // 
            lb_passwd.AutoSize = true;
            lb_passwd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lb_passwd.Location = new Point(249, 219);
            lb_passwd.Margin = new Padding(4, 0, 4, 0);
            lb_passwd.Name = "lb_passwd";
            lb_passwd.Size = new Size(122, 32);
            lb_passwd.TabIndex = 2;
            lb_passwd.Text = "Password";
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_dangnhap.Location = new Point(249, 341);
            btn_dangnhap.Margin = new Padding(4, 5, 4, 5);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(290, 73);
            btn_dangnhap.TabIndex = 3;
            btn_dangnhap.Text = ">Đăng Nhập<";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // btn_quenmatkhau
            // 
            btn_quenmatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btn_quenmatkhau.ForeColor = Color.FromArgb(128, 128, 255);
            btn_quenmatkhau.Location = new Point(249, 423);
            btn_quenmatkhau.Margin = new Padding(4, 5, 4, 5);
            btn_quenmatkhau.Name = "btn_quenmatkhau";
            btn_quenmatkhau.Size = new Size(244, 56);
            btn_quenmatkhau.TabIndex = 4;
            btn_quenmatkhau.Text = "Quên mật khẩu?";
            btn_quenmatkhau.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(249, 504);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(403, 61);
            button3.TabIndex = 5;
            button3.Text = "Chưa có tài khoản? -> Đăng kí";
            button3.UseVisualStyleBackColor = true;
            // 
            // tb_tendangnhap
            // 
            tb_tendangnhap.Location = new Point(249, 158);
            tb_tendangnhap.Margin = new Padding(4, 5, 4, 5);
            tb_tendangnhap.Name = "tb_tendangnhap";
            tb_tendangnhap.Size = new Size(314, 39);
            tb_tendangnhap.TabIndex = 6;
            tb_tendangnhap.MaskInputRejected += tb_tendangnhap_MaskInputRejected;
            // 
            // tb_passwd
            // 
            tb_passwd.Location = new Point(249, 283);
            tb_passwd.Margin = new Padding(4, 5, 4, 5);
            tb_passwd.Name = "tb_passwd";
            tb_passwd.Size = new Size(314, 39);
            tb_passwd.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tb_passwd);
            Controls.Add(tb_tendangnhap);
            Controls.Add(button3);
            Controls.Add(btn_quenmatkhau);
            Controls.Add(btn_dangnhap);
            Controls.Add(lb_passwd);
            Controls.Add(lb_tendangnhap);
            Controls.Add(lb_dangnhap);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "OrderPath";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_dangnhap;
        private Label lb_tendangnhap;
        private Label lb_passwd;
        private Button btn_dangnhap;
        private Button btn_quenmatkhau;
        private Button button3;
        private MaskedTextBox tb_tendangnhap;
        private MaskedTextBox tb_passwd;
    }
}
