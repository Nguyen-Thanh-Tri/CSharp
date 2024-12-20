﻿using BLL;
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
    public partial class Lop : Form
    {
        sLop lop = new sLop();
        float firstWidth;
        float firstHeight;
        public Lop()
        {
            InitializeComponent();
            dgvLop.DataSource = GetData.LOP();
            LoadCbbKhoa();
            LoadCbbGV();
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
            lop.PK_sMaLop = txtMaLop.Text;
            lop.sTenLop = txtTenLop.Text;
            lop.sKhoa = cbbMaKhoa.Text;
            lop.sGiangVien = cbbGiangVien.Text;

            if (txtMaLop.Text == "" || txtTenLop.Text == "" || cbbMaKhoa.Text == "" || cbbGiangVien.Text == "")
            {
                MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LopBLL.Themlop(lop);
                dgvLop.DataSource = GetData.LOP();
                MessageBox.Show("Thêm thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LoadCbbKhoa()
        {
            DataTable cbbKhoa = GetData.cbbLop();
            cbbMaKhoa.Items.Clear();
            cbbMaKhoa.Text = "";
            foreach(DataRow row in cbbKhoa.Rows)
            {
                string tenKhoa = row["sTenKhoa"].ToString();

                if (!cbbMaKhoa.Items.Contains(tenKhoa))
                {
                    cbbMaKhoa.Items.Add(tenKhoa); // Thêm vào ComboBox
                }
            }

        }

        private void LoadCbbGV()
        {
            DataTable cbbGV = GetData.cbbLop();
            cbbGiangVien.Items.Clear();
            cbbGiangVien.Text = "";
            foreach(DataRow row in cbbGV.Rows)
            {
                string tenGV = row["sTenGiangvien"].ToString();

                if(!cbbGiangVien.Items.Contains(tenGV))
                {
                    cbbGiangVien.Items.Add(tenGV);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lop.PK_sMaLop = txtMaLop.Text;
            LopBLL.XoaLop(lop);
            dgvLop.DataSource = GetData.LOP();
            MessageBox.Show("Xóa thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                txtMaLop.Text = dgvLop.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLop.Text = dgvLop.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbMaKhoa.Text = dgvLop.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbGiangVien.Text = dgvLop.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaLop.Text = dgvLop.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLop.Text = dgvLop.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbMaKhoa.Text = dgvLop.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbGiangVien.Text = dgvLop.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
        }
    }
}
