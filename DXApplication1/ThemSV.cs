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
    public partial class ThemSV : Form
    {
        SinhVien sinhvien = new SinhVien();
        float firstWidth;
        float firstHeight;
        public ThemSV()
        {
            InitializeComponent();
            dgvSinhVien.DataSource = GetData.SINHVIEN();
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

        public object DAL { get; private set; }

        private void btnThem_Click(object sender, EventArgs e)

        {
            try
            {
                sinhvien.PK_sMaSv = txtMaSV.Text;
                sinhvien.sHovaTen = txtHovaTen.Text;
                sinhvien.sNgaySinh = dtpNgaySinh.Text;
                sinhvien.sLop = txtLop.Text;
                sinhvien.sKhoa = txtKhoa.Text;
                sinhvien.sSoDienThoai = txtSoDienThoai.Text;
                sinhvien.sDiaChi = txtDiaChi.Text;


                if (txtMaSV.Text == "" || txtHovaTen.Text == "" || txtDiaChi.Text == "" || txtLop.Text == "" || txtKhoa.Text == "")
                {
                    MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int GioiTinh = 1;
                    if (RbtnNam.Checked == true)
                    {
                        GioiTinh = 1;
                    }
                    else
                    {
                        GioiTinh = 0;
                    }
                    sinhvien.sGioiTinh = GioiTinh;
                    SinhVienBLL.ThemSV(sinhvien);
                    dgvSinhVien.DataSource = GetData.SINHVIEN();
                    MessageBox.Show("Thêm thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;
            rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ThemSV_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
        }
    }
}
