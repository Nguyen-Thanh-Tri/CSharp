using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class ThemGV : Form
    {
        GiangVien giangvien = new GiangVien();
        float firstWidth;
        float firstHeight;
        public ThemGV()
        {
            InitializeComponent();
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
            dgvGiangVien.DataSource = GetData.GIANGVIEN();
        }
        private void AnaMenu_SizeChanged(object sender, EventArgs e)
        {
            float size1 = this.Size.Width / firstWidth;
            float size2 = this.Size.Height / firstHeight;
            SizeF scale = new SizeF(size1, size2);
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;

            foreach (Control control in this.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * ((size1 + size2) / 2));
                control.Scale(scale);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                giangvien.PK_sMaGiangVien = txtMaGiangVien.Text;
                giangvien.sTenGiangVien = txtTenGiangVien.Text;
                
                if(txtMaGiangVien.Text == "" || txtTenGiangVien.Text == "")
                {
                    MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    GiangVienBLL.ThemGV(giangvien);
                    dgvGiangVien.DataSource = GetData.GIANGVIEN();
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
    }
}
