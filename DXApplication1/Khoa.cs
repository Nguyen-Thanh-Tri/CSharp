﻿using System;
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
    public partial class Khoa : Form
    {
        sKhoa khoa = new sKhoa();
        float firstWidth;
        float firstHeight;
        public Khoa()
        {
            InitializeComponent();
            dgvKhoa.DataSource = GetData.KHOA();

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
        private void btnThem_Click(object sender, EventArgs e)
        {
            try 
            {
                khoa.PK_sMaKhoa = txtMakhoa.Text;
                khoa.sTenKhoa = txtTenkhoa.Text;

                if (txtMakhoa.Text == "" || txtTenkhoa.Text == "")
                {
                    MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                {
                    KhoaBLL.ThemKhoa(khoa);
                    dgvKhoa.DataSource = GetData.KHOA();
                    MessageBox.Show("Thêm thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMakhoa.ResetText();
                    txtTenkhoa.ResetText();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            khoa.PK_sMaKhoa = txtMakhoa.Text;
            KhoaBLL.XoaKhoa(khoa);
            dgvKhoa.DataSource = GetData.KHOA();
            MessageBox.Show("Xóa thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMakhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenkhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtMakhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenkhoa.Text= dgvKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();
            }    
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
        }
    }
}
