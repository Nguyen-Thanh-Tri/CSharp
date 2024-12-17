namespace DXApplication1
{
    partial class ThemSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.GioiTinh = new System.Windows.Forms.Panel();
            this.RbtnNam = new System.Windows.Forms.RadioButton();
            this.RbtnNu = new System.Windows.Forms.RadioButton();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.qLSVDataSet = new DXApplication1.QLSVDataSet();
            this.qLSVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lớp";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(90, 14);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(140, 20);
            this.txtHovaTen.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(90, 50);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(140, 20);
            this.txtMaSV.TabIndex = 2;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(563, 14);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(140, 20);
            this.txtLop.TabIndex = 6;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(563, 50);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(140, 20);
            this.txtKhoa.TabIndex = 7;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Controls.Add(this.RbtnNam);
            this.GioiTinh.Controls.Add(this.RbtnNu);
            this.GioiTinh.Controls.Add(this.label3);
            this.GioiTinh.Location = new System.Drawing.Point(246, 21);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(238, 41);
            this.GioiTinh.TabIndex = 12;
            // 
            // RbtnNam
            // 
            this.RbtnNam.AutoSize = true;
            this.RbtnNam.Location = new System.Drawing.Point(20, 17);
            this.RbtnNam.Name = "RbtnNam";
            this.RbtnNam.Size = new System.Drawing.Size(47, 17);
            this.RbtnNam.TabIndex = 4;
            this.RbtnNam.TabStop = true;
            this.RbtnNam.Text = "Nam";
            this.RbtnNam.UseVisualStyleBackColor = true;
            // 
            // RbtnNu
            // 
            this.RbtnNu.AutoSize = true;
            this.RbtnNu.Location = new System.Drawing.Point(173, 17);
            this.RbtnNu.Name = "RbtnNu";
            this.RbtnNu.Size = new System.Drawing.Size(39, 17);
            this.RbtnNu.TabIndex = 5;
            this.RbtnNu.TabStop = true;
            this.RbtnNu.Text = "Nữ";
            this.RbtnNu.UseVisualStyleBackColor = true;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(-3, 220);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.Size = new System.Drawing.Size(718, 260);
            this.dgvSinhVien.TabIndex = 13;
            this.dgvSinhVien.SizeChanged += new System.EventHandler(this.AnaMenu_SizeChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số điện thoại";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(90, 88);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(140, 20);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(292, 124);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(230, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(261, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Danh mục sinh viên";
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem.AppearanceHovered.Options.UseForeColor = true;
            this.btnThem.AppearancePressed.BackColor = System.Drawing.Color.Gray;
            this.btnThem.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnThem.AppearancePressed.Options.UseBackColor = true;
            this.btnThem.AppearancePressed.Options.UseForeColor = true;
            this.btnThem.Location = new System.Drawing.Point(29, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 33);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(580, 160);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 33);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(563, 89);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(140, 20);
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLSVDataSetBindingSource
            // 
            this.qLSVDataSetBindingSource.DataSource = this.qLSVDataSet;
            this.qLSVDataSetBindingSource.Position = 0;
            // 
            // ThemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 480);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemSV";
            this.Text = "QuanLySinhVien";
            this.SizeChanged += new System.EventHandler(this.AnaMenu_SizeChanged);
            this.GioiTinh.ResumeLayout(false);
            this.GioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Panel GioiTinh;
        private System.Windows.Forms.RadioButton RbtnNam;
        private System.Windows.Forms.RadioButton RbtnNu;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.BindingSource qLSVDataSetBindingSource;
        private QLSVDataSet qLSVDataSet;
    }
}