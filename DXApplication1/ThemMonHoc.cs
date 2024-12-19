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
    public partial class ThemMonHoc : Form
    {
        MonHoc monhoc = new MonHoc();
        float firstWidth;
        float firstHeight;
        public ThemMonHoc()
        {
            InitializeComponent();
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
            dgvMonHoc.DataSource = GetData.MONHOC();
            LoadCbbMaGV();
            cbbMaGV.SelectedIndexChanged += new EventHandler(cbbMaGV_SelectedIndexChanged);
            LoadCbbTenGV();
            cbbTenGV.SelectedIndexChanged += new EventHandler(cbbTenGV_SelectedIndexChanged);
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
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            
                monhoc.PK_sMaMonHoc = txtMaMH.Text;
                monhoc.sTenMonHoc = txtTenMH.Text;
                monhoc.SMaGiangVien = cbbMaGV.Text;
                monhoc.sTenGiangVien = cbbTenGV.Text;

                if(txtMaMH.Text == "" || txtTenMH.Text == "" || cbbMaGV.Text == "" || cbbTenGV.Text == "")
                {
                    MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MonHocBLL.ThemMH(monhoc);
                    dgvMonHoc.DataSource = GetData.MONHOC();
                    MessageBox.Show("Thêm thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
        }

        Dictionary<string, string> giangVienDictMaSV = new Dictionary<string, string>();
        Dictionary<string, string> giangVienDictTenSV = new Dictionary<string, string>();

        //Load Combobox Mã Giảng Viên và, ánh xạ đén combobox Tên Giảng Viên
        private void LoadCbbMaGV() {
            DataTable cbbGiangVien = GetData.cbbGIANGVIEN();
            cbbMaGV.Items.Clear();
            cbbMaGV.Text = "";
            foreach (DataRow row in cbbGiangVien.Rows)
            {              
                giangVienDictMaSV[row["PK_sMaGiangVien"].ToString()] = row["sTenGiangVien"].ToString();
                cbbMaGV.Items.Add(row["PK_sMaGiangVien"].ToString());
            }
        }
        private void cbbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaGV = cbbMaGV.SelectedItem.ToString();
            if (giangVienDictMaSV.ContainsKey(selectedMaGV))
            {
                cbbTenGV.SelectedIndexChanged -= cbbTenGV_SelectedIndexChanged;
                cbbTenGV.Text = giangVienDictMaSV[selectedMaGV];
                cbbTenGV.SelectedIndexChanged += cbbTenGV_SelectedIndexChanged;
            }
        }

        //Load Combobox Tên Giảng Viên và, ánh xạ đén combobox Mã Giảng Viên
        private void LoadCbbTenGV()
        {
            DataTable cbbGiangVien = GetData.cbbGIANGVIEN();
            cbbTenGV.Items.Clear();
            cbbTenGV.Text = "";
            foreach (DataRow row in cbbGiangVien.Rows)
            {
                giangVienDictTenSV[row["sTenGiangVien"].ToString()] = row["PK_sMaGiangVien"].ToString();
                cbbTenGV.Items.Add(row["sTenGiangVien"].ToString());
            }
        }

        private void cbbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectTenGV = cbbTenGV.SelectedItem.ToString();
            if(giangVienDictTenSV.ContainsKey(selectTenGV))
            {
                cbbMaGV.SelectedIndexChanged -= cbbMaGV_SelectedIndexChanged;
                cbbMaGV.Text = giangVienDictTenSV[selectTenGV];
                cbbMaGV.SelectedIndexChanged += cbbMaGV_SelectedIndexChanged;
            }
        }

        private void RefreshIcon_Click(object sender, EventArgs e)
        {
            LoadCbbMaGV();
            LoadCbbTenGV();
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

        private void ThemMonHoc_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
        }
    }
}
