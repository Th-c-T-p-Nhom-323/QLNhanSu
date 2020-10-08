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
    public partial class frmphongBan : Form
    {
        PhongBanEntity obj = new PhongBanEntity();
        PhongbanBus Bus = new PhongbanBus();
        private int fluu = 1;
        public static string Ma;
        public frmphongBan()
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
            txtMaPB.Enabled = e;
            txtTenPB.Enabled = e;
            txtDiaChi.Enabled = e;
            cmbMaTP.Enabled = e;
            txtSdt.Enabled = e;
        }
        private void clearData()
        {
            txtMaPB.Text = "";
            txtTenPB.Text = "";
            cmbMaTP.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
        }

        private void HienThi()
        {
            dgvPhongBan.DataSource = Bus.GetData();
        }
        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (fluu == 0)
            {
                txtTenPB.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["TenPB"].Value);
                txtDiaChi.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["DiaChi"].Value);
                txtSdt.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["SDT"].Value);
                cmbMaTP.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["MaTP"].Value);
            }
            else
            {
                txtMaPB.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["MaPb"].Value);
                txtTenPB.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["TenPB"].Value);
                txtDiaChi.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["DiaChi"].Value);
                txtSdt.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["SDT"].Value);
                cmbMaTP.Text = Convert.ToString(dgvPhongBan.CurrentRow.Cells["MaTP"].Value);
            }      
        }
        private void frmphongBan_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);
            
        }
        private void dgvPhongBan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPhongBan.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Bus.DeleteData(txtMaPB.Text);
                    MessageBox.Show("Xóa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    DisEnl(false);
                    HienThi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có Lỗi Không thể xóa !" + ex.Message);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            fluu = 1;
            DisEnl(true);
            txtMaPB.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
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
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTTPB_Click(object sender, EventArgs e)
        {
            
        }
    }
}
