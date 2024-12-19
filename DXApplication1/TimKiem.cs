using DAL;
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
    public partial class TimKiem : Form
    {
        float firstWidth;
        float firstHeight;
        public TimKiem()
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
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtinput.Text;
                if(input == "")
                {
                    MessageBox.Show("các trường không được trống", "Quản lý sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }   
                else
                {
                    var result = GetData.TimKiem(input);
                    if (result == null || result.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        dgv.DataSource = GetData.TimKiem(input);
                    }                                        
                }   
            }
            catch { }
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

        private void TimKiem_Load(object sender, EventArgs e)
        {
            firstWidth = this.Size.Width;
            firstHeight = this.Size.Height;
        }
    }
}
