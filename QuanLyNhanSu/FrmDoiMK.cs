using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmDoiMK : Form
    {
        string con = @"Data Source=DESKTOP-EJJ3P12;Initial Catalog=QLNhanSu;Integrated Security=True";
        public FrmDoiMK()
        {
            InitializeComponent();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("Sua_ND", conn);
            // Khai báo kiểu thực thi là Thực thi thủ tục
            cmd.CommandType = CommandType.StoredProcedure;
            // Khai báo và gán giá trị cho các tham số đầu vào của thủ tục
            // Khai báo tham số thứ nhất @Ma - là tên tham số được tạo trong thủ tục
            SqlParameter p = new SqlParameter();

            // Khởi tạo tham số thứ 2 trong thủ tục là @Ten
            p = new SqlParameter("@ten",txtTaiKhoan.Text); cmd.Parameters.Add(p);
            p = new SqlParameter("@mk", txtMatKhau.Text); cmd.Parameters.Add(p);

            // Thực thi thủ tục
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Đôi mật khẩu mới thành công");
                frmMain fm = new frmMain();
                fm.Show();
                this.Hide();
            }
            else MessageBox.Show("Không thể thêm mới");
        }
    }
}
