using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu_BUS;
using QuanLyNhanSu_Entity;
namespace QuanLyNhanSu
{
    public partial class frmTDHV : Form
    {
        TrinhDoHocVan obj = new TrinhDoHocVan();
        TrinhDoHocVanBUS bus = new TrinhDoHocVanBUS();

        private int fluu = 1;
        public frmTDHV()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác Nhận Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                frmMain m = new frmMain();
                m.Show();
                this.Close();

            }
            else
            {
                HienThi();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn hủy thao tác đang làm?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                HienThi();
                DisEnl(false);
                fluu = 1;
            }
            else
                return;
        }
        private void DisEnl(bool e)
        {
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            txtMaTDHV.Enabled = e;
            txtTenTDHV.Enabled = e;
            txtCN.Enabled = e;
        }
        private void clearData()
        {
            
        }
        private void HienThi()
        {
            dgvTrinhDoHocVan.DataSource = bus.GetData();
        }

        private void frmTDHV_Load(object sender, EventArgs e)
        {
            HienThi();
            DisEnl(false);

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            fluu = 0;
            txtMaTDHV.Text = bus.TangMa();
            DisEnl(true);
            txtMaTDHV.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvTrinhDoHocVan_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvTrinhDoHocVan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
           
        }
    }
}
