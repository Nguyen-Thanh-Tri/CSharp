namespace DXApplication1
{
    partial class DangKyMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMaSV = new System.Windows.Forms.ComboBox();
            this.cbbMaMH = new System.Windows.Forms.ComboBox();
            this.cbbTenMH = new System.Windows.Forms.ComboBox();
            this.cbbMaHK = new System.Windows.Forms.ComboBox();
            this.dgvDKMH = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbGV = new System.Windows.Forms.ComboBox();
            this.txtGV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã môn học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã học kỳ";
            // 
            // cbbMaSV
            // 
            this.cbbMaSV.FormattingEnabled = true;
            this.cbbMaSV.Location = new System.Drawing.Point(148, 32);
            this.cbbMaSV.Name = "cbbMaSV";
            this.cbbMaSV.Size = new System.Drawing.Size(140, 21);
            this.cbbMaSV.TabIndex = 6;
            this.cbbMaSV.SelectedIndexChanged += new System.EventHandler(this.cbbMaSV_SelectedIndexChanged);
            // 
            // cbbMaMH
            // 
            this.cbbMaMH.FormattingEnabled = true;
            this.cbbMaMH.Location = new System.Drawing.Point(617, 32);
            this.cbbMaMH.Name = "cbbMaMH";
            this.cbbMaMH.Size = new System.Drawing.Size(140, 21);
            this.cbbMaMH.TabIndex = 9;
            this.cbbMaMH.SelectedIndexChanged += new System.EventHandler(this.cbbMaMH_SelectedIndexChanged);
            // 
            // cbbTenMH
            // 
            this.cbbTenMH.FormattingEnabled = true;
            this.cbbTenMH.Location = new System.Drawing.Point(617, 72);
            this.cbbTenMH.Name = "cbbTenMH";
            this.cbbTenMH.Size = new System.Drawing.Size(140, 21);
            this.cbbTenMH.TabIndex = 10;
            this.cbbTenMH.SelectedIndexChanged += new System.EventHandler(this.cbbTenMH_SelectedIndexChanged);
            // 
            // cbbMaHK
            // 
            this.cbbMaHK.FormattingEnabled = true;
            this.cbbMaHK.Location = new System.Drawing.Point(617, 113);
            this.cbbMaHK.Name = "cbbMaHK";
            this.cbbMaHK.Size = new System.Drawing.Size(140, 21);
            this.cbbMaHK.TabIndex = 11;
            // 
            // dgvDKMH
            // 
            this.dgvDKMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDKMH.Location = new System.Drawing.Point(-1, 189);
            this.dgvDKMH.Name = "dgvDKMH";
            this.dgvDKMH.Size = new System.Drawing.Size(802, 261);
            this.dgvDKMH.TabIndex = 12;
            this.dgvDKMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDKMH_CellClick);
            this.dgvDKMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDKMH_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(540, 145);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 38);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(127, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 38);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(148, 73);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.ReadOnly = true;
            this.txtHovaTen.Size = new System.Drawing.Size(140, 20);
            this.txtHovaTen.TabIndex = 15;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(148, 114);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(140, 20);
            this.txtLop.TabIndex = 16;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(341, 145);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(132, 38);
            this.btn_Xoa.TabIndex = 17;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Giảng viên";
            // 
            // cbbGV
            // 
            this.cbbGV.FormattingEnabled = true;
            this.cbbGV.Location = new System.Drawing.Point(320, 48);
            this.cbbGV.Name = "cbbGV";
            this.cbbGV.Size = new System.Drawing.Size(140, 21);
            this.cbbGV.TabIndex = 20;
            this.cbbGV.SelectedIndexChanged += new System.EventHandler(this.cbbGV_SelectedIndexChanged);
            // 
            // txtGV
            // 
            this.txtGV.Location = new System.Drawing.Point(320, 73);
            this.txtGV.Name = "txtGV";
            this.txtGV.ReadOnly = true;
            this.txtGV.Size = new System.Drawing.Size(140, 20);
            this.txtGV.TabIndex = 21;
            // 
            // DangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGV);
            this.Controls.Add(this.cbbGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDKMH);
            this.Controls.Add(this.cbbMaHK);
            this.Controls.Add(this.cbbTenMH);
            this.Controls.Add(this.cbbMaMH);
            this.Controls.Add(this.cbbMaSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangKyMonHoc";
            this.Text = "DangKyMonHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKMH)).EndInit();
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
        private System.Windows.Forms.ComboBox cbbMaSV;
        private System.Windows.Forms.ComboBox cbbMaMH;
        private System.Windows.Forms.ComboBox cbbTenMH;
        private System.Windows.Forms.ComboBox cbbMaHK;
        private System.Windows.Forms.DataGridView dgvDKMH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbGV;
        private System.Windows.Forms.TextBox txtGV;
    }
}