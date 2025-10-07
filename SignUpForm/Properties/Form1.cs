using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
using BTT3_RegForm;
namespace ProjectTuan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string HashSHA256(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool KiemTraDangNhap(string TenDangNhap, string matKhau)
        {
            // tao chuoi la 1 ket noi
            string connectionString = "Server=localhost;Database=QUANLYKHACHHANG;Integrated Security=True;";
            // tao chuoi la 1 querry
            string query = "SELECT COUNT(*) FROM khachhang WHERE username = @TenDangNhap AND matKhau = @matKhau";
            // tao ket noi dong voi sql
            using (SqlConnection connection = new SqlConnection(connectionString))
            // goi ham de ket noi voi sql va thuc hien querry
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                command.Parameters.AddWithValue("@matKhau", HashSHA256(matKhau));

                try
                {
                    // kiem tra xem co tai khoan nao khop trong sql khong
                    connection.Open();
                    // thuc hien querry dem va gan vao bien count
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
                    return false;
                }
            }
        }
        private void tb_tendangnhap_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = tb_tendangnhap.Text;
            string password = tb_passwd.Text;
            // kiem tra da nhap du textbox chua
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
                return;
            }
            // neu co tai khoan khop o SQL thi tra ve
            if (KiemTraDangNhap(username, password))
            {
                MessageBox.Show("Đăng nhập thành công");
                return;
            }
            // khong thi xuat loi 
            else
            {
                MessageBox.Show("Lỗi đăng nhập, kiểm tra lại tên tài khoản hoặc mật khẩu của bạn");
                return;
            }
        }



        private void ConnectToDatabase()
        {
            string connectionString = "Server=localhost;Database=QUANLYKHACHHANG;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Kết nối thành công!");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btn3_formDangKy_Click(object sender, EventArgs e)
        {
            Form formDangKy = new OrderPath();
            formDangKy.Show();
        }
    }
}
