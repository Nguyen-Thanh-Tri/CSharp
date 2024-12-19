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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DXApplication1
{
    public partial class NhapDiem : Form
    {
        sNhapDiem diem = new sNhapDiem();
        float firstWidth;
        float firstHeight;
        public NhapDiem()
        {
            InitializeComponent();
            LoadCondition();
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
                    MessageBox.Show("Tải thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            diem.sTenMH = cbbTenMH.Text;
            diem.sMaHocKy = cbbMaHK.Text;
            foreach (DataGridViewRow row in dgvDiem.Rows)
            {
                diem.sMaSV = row.Cells[1].Value != null 
                    ? row.Cells[1].Value.ToString() : string.Empty;
                diem.sDiemCC = row.Cells[4].Value == null || row.Cells[4].Value == DBNull.Value
                    ? (float?)null : Convert.ToSingle(row.Cells[4].Value);
                diem.sDiemBT = row.Cells[5].Value == null || row.Cells[5].Value == DBNull.Value
                    ? (float?)null : Convert.ToSingle(row.Cells[5].Value);
                diem.sDiemGK = row.Cells[6].Value == null || row.Cells[6].Value == DBNull.Value
                    ? (float?)null : Convert.ToSingle(row.Cells[6].Value);
                diem.sDiemCK = row.Cells[7].Value == null || row.Cells[7].Value == DBNull.Value
                    ? (float?)null : Convert.ToSingle(row.Cells[7].Value);
                diem.sDiemTB = row.Cells[8].Value == null || row.Cells[8].Value == DBNull.Value
                    ? (decimal?)null : (decimal)Math.Round(Convert.ToDecimal(row.Cells[8].Value), 1);

                NhapDiemBLL.UpdateDiem(diem);
            }
            MessageBox.Show("Thêm thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvDiem.DataSource = GetData.NHAPDIEM(diem);
            txtDiemCC.TextChanged -= txtDiemCC_TextChanged;
            txtDiemBT.TextChanged -= txtDiemBT_TextChanged;
            txtDiemGK.TextChanged -= txtDiemGK_TextChanged;
            txtDiemCK.TextChanged -= txtDiemCK_TextChanged;
            txtMaSV.Clear();
            txtHovaTen.Clear();
            txtLop.Clear();
            txtDiemCC.Clear();
            txtDiemBT.Clear();
            txtDiemGK.Clear();
            txtDiemCK.Clear();
            txtDiemTB.Clear();
            txtDiemCC.TextChanged += txtDiemCC_TextChanged;
            txtDiemBT.TextChanged += txtDiemBT_TextChanged;
            txtDiemGK.TextChanged += txtDiemGK_TextChanged;
            txtDiemCK.TextChanged += txtDiemCK_TextChanged;
        }

        private void txtDiemCC_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDiemCC.Text))
            {
                updatedgv(DBNull.Value, 4);
            }
            else
            {
                updatedgv1(txtDiemCC.Text, 4);
            }
            AcgDiemTB();
        }

        private void txtDiemBT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiemBT.Text))
            {
                updatedgv(DBNull.Value, 5);
            }
            else
            {
                updatedgv1(txtDiemBT.Text, 5);
            }
            AcgDiemTB();
        }

        private void txtDiemGK_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiemGK.Text))
            {
                updatedgv(DBNull.Value, 6);
            }
            else
            {
                updatedgv1(txtDiemGK.Text, 6);
            }
            AcgDiemTB();
        }

        private void txtDiemCK_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiemCK.Text))
            {
                updatedgv(DBNull.Value, 7);
            }
            else
            {
                updatedgv1(txtDiemCK.Text, 7);
            }
            AcgDiemTB();
        }

        private void updatedgv(object a, int b)
        {
            try
            {
                if (dgvDiem.CurrentRow != null)
                {

                    dgvDiem.CurrentRow.Cells[b].Value = a;
                }
            }
            catch { }

        }
        private void updatedgv1(string a, int b)
        {
            try
            {
                if (dgvDiem.CurrentRow != null)
                {

                    dgvDiem.CurrentRow.Cells[b].Value = a;
                }
            }
            catch { }

        }

        private void AcgDiemTB()
        {
            if (!string.IsNullOrEmpty(txtDiemCC.Text) &&
                !string.IsNullOrEmpty(txtDiemBT.Text) &&
                !string.IsNullOrEmpty(txtDiemGK.Text) &&
                !string.IsNullOrEmpty(txtDiemCK.Text))
            {
                try
                {
                    double diemcc = Convert.ToDouble(txtDiemCC.Text);
                    double diembt = Convert.ToDouble(txtDiemBT.Text);
                    double diemgk = Convert.ToDouble(txtDiemGK.Text);
                    double diemck = Convert.ToDouble(txtDiemCK.Text);

                    double diemtb = 0.15 * diemcc + 0.15 * diembt + 0.25 * diemgk + 0.45 * diemck;
                    txtDiemTB.Text = diemtb.ToString("F1");
                    updatedgv1(txtDiemTB.Text, 8);
                }
                catch
                {

                }
            }
            else
            {
                txtDiemCK.Text = string.Empty;
            }   
        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
        }
    }
}
