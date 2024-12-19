namespace DXApplication1
{
    partial class Sua_XoaSV
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBtnNu = new System.Windows.Forms.RadioButton();
            this.RBtnNam = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 195);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.Size = new System.Drawing.Size(801, 255);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSinhVien_CellClick);
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSinhVien_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(27, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Họ và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Khoa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giới tính";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(30, 23);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(135, 20);
            this.txtMaSV.TabIndex = 9;
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(30, 71);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(135, 20);
            this.txtHovaTen.TabIndex = 10;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(638, 25);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(135, 20);
            this.txtLop.TabIndex = 11;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(638, 71);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(135, 20);
            this.txtKhoa.TabIndex = 13;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(30, 118);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(135, 20);
            this.txtSoDienThoai.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(638, 118);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(135, 20);
            this.txtDiaChi.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBtnNu);
            this.panel1.Controls.Add(this.RBtnNam);
            this.panel1.Location = new System.Drawing.Point(297, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 79);
            this.panel1.TabIndex = 17;
            // 
            // RBtnNu
            // 
            this.RBtnNu.AutoSize = true;
            this.RBtnNu.Location = new System.Drawing.Point(156, 30);
            this.RBtnNu.Name = "RBtnNu";
            this.RBtnNu.Size = new System.Drawing.Size(39, 17);
            this.RBtnNu.TabIndex = 1;
            this.RBtnNu.TabStop = true;
            this.RBtnNu.Text = "Nữ";
            this.RBtnNu.UseVisualStyleBackColor = true;
            // 
            // RBtnNam
            // 
            this.RBtnNam.AutoSize = true;
            this.RBtnNam.Location = new System.Drawing.Point(3, 30);
            this.RBtnNam.Name = "RBtnNam";
            this.RBtnNam.Size = new System.Drawing.Size(47, 17);
            this.RBtnNam.TabIndex = 0;
            this.RBtnNam.TabStop = true;
            this.RBtnNam.Text = "Nam";
            this.RBtnNam.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Tải Danh Sách\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadDS_SinhVien_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sửa Thông Tin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SuaSV_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(483, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 36);
            this.button3.TabIndex = 20;
            this.button3.Text = "Xóa Sinh Viên";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.XoaSV_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(693, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 36);
            this.button4.TabIndex = 21;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Sua_XoaSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "Sua_XoaSV";
            this.Text = "Sua_XoaSV";
            this.Load += new System.EventHandler(this.Sua_XoaSV_Load);
            this.SizeChanged += new System.EventHandler(this.AnaMenu_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RBtnNu;
        private System.Windows.Forms.RadioButton RBtnNam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}