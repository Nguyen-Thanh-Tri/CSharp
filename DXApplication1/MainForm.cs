using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void FluentDesignForm1_Load(object sender, EventArgs e)
        {

        }

      

        private void ThemSV_Click(object sender, EventArgs e)
        {
            ThemSV f = new ThemSV();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }

        private void Sua_Xoa_Click(object sender, EventArgs e)
        {
            Sua_XoaSV f = new Sua_XoaSV();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }

        private void ThemGV_Click(object sender, EventArgs e)
        {
            ThemGV f = new ThemGV();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }

        private void ThemMonHoc_Click(object sender, EventArgs e)
        {
            ThemMonHoc f = new ThemMonHoc();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }

        private void Sua_XoaMonHoc_Click(object sender, EventArgs e)
        {
            Sua_XoaMonHoc f = new Sua_XoaMonHoc();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }

        private void Khoa_Click(object sender, EventArgs e)
        {
            Khoa f = new Khoa();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }

        private void Lop_Click(object sender, EventArgs e)
        {
            Lop f = new Lop();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            DangKyMonHoc f =new DangKyMonHoc();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            NhapDiem f = new NhapDiem();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }

        private void In_Click(object sender, EventArgs e)
        {
            DSSV f = new DSSV();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            container.Controls.Clear();
            container.Controls.Add(f);
            f.Show();
        }
    }
}
