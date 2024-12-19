using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
namespace DXApplication1
{
    public partial class Sua_XoaSV : Form
    {
        SinhVien sinhvien = new SinhVien();
        float firstWidth;
        float firstHeight;
        public Sua_XoaSV()
        {
            InitializeComponent();
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
        }
        private void AnaMenu_SizeChanged(object sender, EventArgs e)
        {
            float size1 = firstWidth > 0 ? this.Size.Width / firstWidth : 1;
            float size2 = firstHeight > 0 ? this.Size.Height / firstHeight : 1;
            SizeF scale = new SizeF(size1, size2);

            // Lưu lại kích thước mới
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;

            foreach (Control control in this.Controls)
            {
                float newFontSize = control.Font.Size * ((size1 + size2) / 2);
                if (newFontSize > 0) // Đảm bảo kích thước phông chữ hợp lệ
                {
                    control.Font = new Font(control.Font.FontFamily, newFontSize);
                }
                control.Scale(scale);
            }
        }

        private void DgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSV.Text = dgvSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHovaTen.Text = dgvSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (dgvSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
                {
                    RBtnNam.Checked = true;
                }
                else
                {
                    RBtnNu.Checked = true;
                }
                txtLop.Text = dgvSinhVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtKhoa.Text = dgvSinhVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSoDienThoai.Text = dgvSinhVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDiaChi.Text = dgvSinhVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void LoadDS_SinhVien_Click(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = GetData.SINHVIEN();
        }

        private void SuaSV_Click(object sender, EventArgs e)
        {
            sinhvien.PK_sMaSv = txtMaSV.Text;
            sinhvien.sHovaTen = txtHovaTen.Text;
            sinhvien.sLop = txtLop.Text;
            sinhvien.sKhoa = txtKhoa.Text;
            sinhvien.sSoDienThoai = txtSoDienThoai.Text;
            sinhvien.sDiaChi = txtDiaChi.Text;
            int GioiTinh = 1;
            if (RBtnNam.Checked == true)
            {
                GioiTinh = 1;
            }
            else
            {
                GioiTinh = 0;
            }
            sinhvien.sGioiTinh = GioiTinh;
            SinhVienBLL.SuaSV(sinhvien);
            dgvSinhVien.DataSource = GetData.SINHVIEN();
            MessageBox.Show("Sửa thông tin thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
            txtMaSV.Text = dgvSinhVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHovaTen.Text = dgvSinhVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dgvSinhVien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
            {
                RBtnNam.Checked = true;
            }
            else
            {
                RBtnNu.Checked = true;
            }
            txtLop.Text = dgvSinhVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtKhoa.Text = dgvSinhVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSoDienThoai.Text = dgvSinhVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvSinhVien.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
        }

        private void XoaSV_Click(object sender, EventArgs e)
        {
            sinhvien.PK_sMaSv = txtMaSV.Text;
            SinhVienBLL.XoaSV(sinhvien);
            dgvSinhVien.DataSource = GetData.SINHVIEN();
            MessageBox.Show("Xóa thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;
            rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Sua_XoaSV_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
        }
    }
}
