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
    public partial class DangKyMonHoc : Form
    {
        sNhapDiem diem = new sNhapDiem();
        public DangKyMonHoc()
        {
            InitializeComponent();
            dgvDKMH.DataSource = GetData.DANGKYMONHOC();
            LoadcbbSV();
            LoadcbbMaMH();
            cbbMaMH.SelectedIndexChanged += new EventHandler(cbbMaMH_SelectedIndexChanged);
            LoadcbbTenMH();
            cbbTenMH.SelectedIndexChanged += new EventHandler(cbbTenMH_SelectedIndexChanged);
            LoadcbbMaHK();
            cbbGV.SelectedIndexChanged += new EventHandler(cbbGV_SelectedIndexChanged);
            LoadcbbMaGV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                diem.sMaSV = cbbMaSV.Text;
                diem.sHovaTen = txtHovaTen.Text;
                diem.sLop = txtLop.Text;
                diem.sMaGiangVien = cbbGV.Text;
                diem.sMaHocKy = cbbMaHK.Text;
                diem.sMaMH = cbbMaMH.Text;
                diem.sTenMH = cbbTenMH.Text;
                
                if (cbbMaSV.Text == "" || txtHovaTen.Text == "" || cbbGV.Text == "" || txtLop.Text == "" || cbbMaMH.Text == "" || cbbTenMH.Text == "" || cbbMaHK.Text == "")
                {
                    MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DangKyMonHocBLL.DangKy(diem);
                    dgvDKMH.DataSource = GetData.DANGKYMONHOC();
                    MessageBox.Show("Thêm thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbMaSV.ResetText();
                    txtHovaTen.ResetText();
                    cbbGV.ResetText();
                    txtLop.ResetText();
                    cbbMaMH.ResetText();
                    cbbTenMH.ResetText();
                    cbbMaHK.ResetText();
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

        Dictionary<string, string> KmasvVhovaten = new Dictionary<string, string>();
        Dictionary<string, string> KmasvVlop = new Dictionary<string, string>();

        private void LoadcbbSV ()
        {
            DataTable cbbSV = GetData.cbbSV();
            cbbMaSV.Items.Clear();
            cbbMaSV.Text = "";
            foreach( DataRow row in  cbbSV.Rows)
            {
                cbbMaSV.Items.Add(row["PK_sMaSv"].ToString());
                KmasvVhovaten[row["PK_sMaSv"].ToString()] = row["sHovaTen"].ToString();
                KmasvVlop[row["PK_sMaSv"].ToString()] = row["sLop"].ToString();
            }
        }

        private void cbbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaSV = cbbMaSV.SelectedItem.ToString();
            if (KmasvVhovaten.ContainsKey(selectedMaSV) && KmasvVlop.ContainsKey(selectedMaSV))
            {
                txtHovaTen.Text = KmasvVhovaten[selectedMaSV];
                txtLop.Text = KmasvVlop[selectedMaSV];
            }
        }

        Dictionary<string, string> KmamhVtenmh = new Dictionary<string, string>();
        Dictionary<string, string> KmamhVmagv = new Dictionary<string, string>();
        Dictionary<string, string> KtenmhVmamh = new Dictionary<string, string>();
        Dictionary<string, string> KtenmhVmagv = new Dictionary<string, string>();

        private void LoadcbbMaMH()
        {
            DataTable cbbMH = GetData.cbbSV1();
            cbbMaMH.Items.Clear();
            cbbMaMH.Text = "";
            foreach (DataRow row in cbbMH.Rows)
            {
                string mamonhoc = row["PK_sMaMonHoc"].ToString();

                if (!cbbMaMH.Items.Contains(mamonhoc))
                {
                    KmamhVmagv[mamonhoc] = row["sMaGiangVien"].ToString();
                    KmamhVtenmh[mamonhoc] = row["sTenMonHoc"].ToString();
                    cbbMaMH.Items.Add(mamonhoc); // Thêm vào ComboBox
                }
            }
        }
        private void cbbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaMH = cbbMaMH.SelectedItem.ToString();
            if(KmamhVtenmh.ContainsKey(selectedMaMH) && KmamhVmagv.ContainsKey(selectedMaMH))
            {
                cbbTenMH.SelectedIndexChanged -= cbbTenMH_SelectedIndexChanged;
                cbbGV.SelectedIndexChanged -= cbbGV_SelectedIndexChanged;
                cbbTenMH.Text = KmamhVtenmh[selectedMaMH];
                cbbGV.Text = KmamhVmagv[selectedMaMH];
                cbbTenMH.SelectedIndexChanged += cbbTenMH_SelectedIndexChanged;
                cbbGV.SelectedIndexChanged += cbbGV_SelectedIndexChanged;
            }
        }


        private void LoadcbbTenMH()
        {
            DataTable cbbtenMH = GetData.cbbSV1();
            cbbTenMH.Items.Clear();
            cbbTenMH.Text = "";
            foreach (DataRow row in cbbtenMH.Rows)
            {
                string tenmonhoc = row["sTenMonHoc"].ToString();
                if (!cbbTenMH.Items.Contains(tenmonhoc))
                {
                    KtenmhVmagv[tenmonhoc] = row["sMaGiangVien"].ToString();
                    KtenmhVmamh[tenmonhoc] = row["PK_sMaMonHoc"].ToString();
                    cbbTenMH.Items.Add(tenmonhoc); // Thêm vào ComboBox
                }
            }
        }
        private void cbbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTenMH = cbbTenMH.SelectedItem.ToString();
            if(KtenmhVmamh.ContainsKey(selectedTenMH) && KtenmhVmagv.ContainsKey(selectedTenMH))
            {
                cbbMaMH.SelectedIndexChanged -= cbbMaMH_SelectedIndexChanged;
                cbbGV.SelectedIndexChanged -= cbbGV_SelectedIndexChanged;
                cbbMaMH.Text = KtenmhVmamh[selectedTenMH];
                cbbGV.Text = KmamhVmagv[selectedTenMH];
                cbbMaMH.SelectedIndexChanged += cbbMaMH_SelectedIndexChanged;
                cbbGV.SelectedIndexChanged += cbbGV_SelectedIndexChanged;
            }
        }
        

        private void LoadcbbMaHK()
        {
            DataTable cbbHK = GetData.cbbSV1();
            cbbMaHK.Items.Clear();
            cbbMaHK.Text = "";
            foreach (DataRow row in cbbHK.Rows)
            {
                string mahocky = row["PK_sMaHocKy"].ToString();

                if (!cbbMaHK.Items.Contains(mahocky))
                {
                    cbbMaHK.Items.Add(mahocky); // Thêm vào ComboBox
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            diem.sMaSV = cbbMaSV.Text;
            diem.sMaMH = cbbMaMH.Text;
            DangKyMonHocBLL.Xoa(diem);
            dgvDKMH.DataSource = GetData.DANGKYMONHOC();
            MessageBox.Show("Xóa thành công", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbbMaSV.Text = "";
            txtHovaTen.Clear();
            txtLop.Clear();
            cbbMaMH.Text = "";
            cbbTenMH.Text = "";
            cbbMaHK.Text = "";
        }

        private void dgvDKMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbbMaSV.Text = dgvDKMH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHovaTen.Text = dgvDKMH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLop.Text = dgvDKMH.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbbGV.Text = dgvDKMH.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbbMaHK.Text = dgvDKMH.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbbMaMH.Text = dgvDKMH.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbbTenMH.Text = dgvDKMH.Rows[e.RowIndex].Cells[7].Value.ToString();
                
            }
        }
        private void dgvDKMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbbMaSV.Text = dgvDKMH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtHovaTen.Text = dgvDKMH.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLop.Text = dgvDKMH.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbbGV.Text = dgvDKMH.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbbMaHK.Text = dgvDKMH.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbbMaMH.Text = dgvDKMH.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbbTenMH.Text = dgvDKMH.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }
        Dictionary<string, string> KmagvVtenmh = new Dictionary<string, string>();
        Dictionary<string, string> KmagvVmamh = new Dictionary<string, string>();
        private void LoadcbbMaGV()
        {
            DataTable cbbMaGV = GetData.cbbSV1();
            cbbTenMH.Items.Clear();
            cbbTenMH.Text = "";
            foreach (DataRow row in cbbMaGV.Rows)
            {
                string magiangvien = row["sMaGiangVien"].ToString();
                if (!cbbGV.Items.Contains(magiangvien))
                {
                    KmagvVtenmh[magiangvien] = row["sTenMonHoc"].ToString();
                    KmagvVmamh[magiangvien] = row["PK_sMaMonHoc"].ToString();
                    cbbGV.Items.Add(magiangvien); // Thêm vào ComboBox
                }
            }
        }
        private void cbbGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaGV = cbbGV.SelectedItem.ToString();
            if (KmagvVtenmh.ContainsKey(selectedMaGV) && KmagvVmamh.ContainsKey(selectedMaGV))
            {
                cbbMaMH.SelectedIndexChanged -= cbbMaMH_SelectedIndexChanged;
                cbbTenMH.SelectedIndexChanged -= cbbTenMH_SelectedIndexChanged;
                cbbMaMH.Text = KmagvVmamh[selectedMaGV];
                cbbTenMH.Text = KmagvVtenmh[selectedMaGV];
                cbbMaMH.SelectedIndexChanged += cbbMaMH_SelectedIndexChanged;
                cbbTenMH.SelectedIndexChanged += cbbTenMH_SelectedIndexChanged;
            }
        }
    }
}
