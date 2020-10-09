using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu_Entity;
using QuanLyNhanSu_BUS;

namespace QuanLyNhanSu
{
    public partial class frmLuong : Form
    {
        LuongEntity obj = new LuongEntity();
        LuongBus Bus = new LuongBus();
        private int fluu = 1;
        public frmLuong()
        {
            InitializeComponent();
        }

        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtBacLuong.Enabled = e;
            txtLuongCoBan.Enabled = e;
            txtHeSoPhuCap.Enabled = e;
            txtHeSoLuong.Enabled = e;         
        }
        private void clearData()
        {
            txtBacLuong.Text = "";
            txtLuongCoBan.Text = "";
            txtHeSoLuong.Text = "";
            txtHeSoPhuCap.Text = "";          
        }
        private void HienThi()
        {
            dgvLuong.DataSource = Bus.GetData();
        }

        private void frmLuong_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(fluu == 0)
            {
                //txtBacLuong.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["BacLuong"].Value);
                txtLuongCoBan.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["LuongCoBan"].Value);
                txtHeSoLuong.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["HeSoLuong"].Value);
                txtHeSoPhuCap.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["HeSoPhuCap"].Value);
            }
            else
            {
                txtBacLuong.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["BacLuong"].Value);
                txtLuongCoBan.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["LuongCoBan"].Value);
                txtHeSoLuong.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["HeSoLuong"].Value);
                txtHeSoPhuCap.Text = Convert.ToString(dgvLuong.CurrentRow.Cells["HeSoPhuCap"].Value);
            }
            
        }

        private void dgvLuong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvLuong.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;           
            DisEnl(true);
            txtBacLuong.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();
            }
            else
                HienThi();
        }

          }
}
