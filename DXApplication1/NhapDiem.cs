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
    public partial class NhapDiem : Form
    {
        sNhapDiem diem = new sNhapDiem();
        public NhapDiem()
        {
            InitializeComponent();
            LoadCondition();
        }

        private void LoadCondition()
        {
            DataTable cbbtenmh = GetData.cbbDiem1();
            cbbTenMH.Items.Clear();
            cbbTenMH.Text = "";
            foreach(DataRow row in cbbtenmh.Rows)
            {
                string tenmon = row["sTenMH"].ToString();
                if(!cbbTenMH.Items.Contains(tenmon))
                {
                    cbbTenMH.Items.Add(tenmon);
                }
            }
        }
        private void cbbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemselected = cbbTenMH.SelectedItem.ToString();
            DataTable cbbmahk = GetData.cbbDiem2(itemselected);
            cbbMaHK.Items.Clear();
            cbbMaHK.Text = "";
            foreach(DataRow row in cbbmahk.Rows)
            {
                string mahk = row["sMaHocKy"].ToString();
                if(!cbbMaHK.Items.Contains(mahk))
                {
                    cbbMaHK.Items.Add(mahk);
                }
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                diem.sTenMH = cbbTenMH.Text;
                diem.sMaHocKy = cbbMaHK.Text;
                if (cbbTenMH.Text == "" || cbbMaHK.Text == "")
                {
                    MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgvDiem.DataSource = GetData.NHAPDIEM(diem);
                    MessageBox.Show("Thêm thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi CSDL", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                txtMaSV.Text = dgvDiem.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHovaTen.Text = dgvDiem.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLop.Text = dgvDiem.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiemCC.Text = dgvDiem.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiemBT.Text = dgvDiem.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiemGK.Text = dgvDiem.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDiemCK.Text = dgvDiem.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDiemTB.Text = dgvDiem.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }
        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaSV.Text = dgvDiem.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHovaTen.Text = dgvDiem.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLop.Text = dgvDiem.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiemCC.Text = dgvDiem.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiemBT.Text = dgvDiem.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiemGK.Text = dgvDiem.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDiemCK.Text = dgvDiem.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtDiemTB.Text = dgvDiem.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvDiem.Rows)
            {
                string DiemCC = row.Cells[4].Value.ToString();
                string DiemBT = row.Cells[5].Value.ToString();
                string DiemGK = row.Cells[6].Value.ToString();
                string DiemCK = row.Cells[7].Value.ToString();
            }
        }

        private void txtDiemCC_TextChanged(object sender, EventArgs e)
        {
            updatedgv(txtDiemCC.Text, 4);
        }
        private void updatedgv(object a,int b)
        {
            if(dgvDiem.SelectedRows.Count > 0)
            {
                int rowIndex = dgvDiem.SelectedRows[2].Index;
                dgvDiem.Rows[rowIndex].Cells[b].Value = a;
            }
        }
    }
}
