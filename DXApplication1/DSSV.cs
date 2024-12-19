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
using Excel = Microsoft.Office.Interop.Excel;

namespace DXApplication1
{
    public partial class DSSV : Form
    {
        float firstWidth;
        float firstHeight;
        public DSSV()
        {
            InitializeComponent();
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
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtlsh.Checked == true)
                {
                    SinhVien sv = new SinhVien();
                    sv.sLop = cbbnameless.Text;
                    dgvDSSV.DataSource = GetData.DSSV1(sv);
                }
                if(rbtlhp.Checked == true)
                {
                    sNhapDiem diem = new sNhapDiem();
                    diem.sTenMH = cbbnameless.Text;
                    dgvDSSV.DataSource = GetData.DSSVDiem(diem);
                }
                if(rbtk.Checked == true)
                {
                    SinhVien sv = new SinhVien();
                    sv.sKhoa = cbbnameless.Text;
                    dgvDSSV.DataSource = GetData.DSSVKhoa(sv);
                }
            }
            catch
            {
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save as Excel File";
                saveFileDialog.FileName = "ExportedData.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                    worksheet.Name = "Exported Data";

                    for (int i = 1; i <= dgvDSSV.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i] = dgvDSSV.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgvDSSV.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvDSSV.Columns.Count; j++)
                        {
                            if (dgvDSSV.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dgvDSSV.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void rbtlhp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtlhp.Checked)
            {
                cbbnameless.DropDownStyle = ComboBoxStyle.DropDown;
                DataTable cbb = GetData.DSSV2();
                cbbnameless.Items.Clear();
                cbbnameless.Text = "";
                foreach(DataRow row in cbb.Rows)
                {
                    string name = row["sTenMH"].ToString();
                    if(!cbbnameless.Items.Contains(name))
                    {
                        cbbnameless.Items.Add(name);
                    }
                }

            }
        }

        private void rbtk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtk.Checked)
            {
                cbbnameless.DropDownStyle = ComboBoxStyle.DropDown;
                DataTable cbb = GetData.DSSV3();
                cbbnameless.Items.Clear();
                cbbnameless.Text = "";
                foreach (DataRow row in cbb.Rows)
                {
                    string name = row["sKhoa"].ToString();
                    if (!cbbnameless.Items.Contains(name))
                    {
                        cbbnameless.Items.Add(name);
                    }
                }

            }
        }

        private void rbtlsh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtlsh.Checked)
            {
                cbbnameless.DropDownStyle = ComboBoxStyle.DropDown;
                DataTable cbb = GetData.DSSV3();
                cbbnameless.Items.Clear();
                cbbnameless.Text = "";
                foreach (DataRow row in cbb.Rows)
                {
                    string name = row["slop"].ToString();
                    if (!cbbnameless.Items.Contains(name))
                    {
                        cbbnameless.Items.Add(name);
                    }
                }

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult rs;
            rs = MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DSSV_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
        }
    }
}
