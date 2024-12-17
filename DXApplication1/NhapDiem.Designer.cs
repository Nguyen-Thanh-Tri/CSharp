namespace DXApplication1
{
    partial class NhapDiem
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
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbbTenMH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiemCK = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.txtDiemGK = new System.Windows.Forms.TextBox();
            this.txtDiemBT = new System.Windows.Forms.TextBox();
            this.txtDiemCC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbbMaHK = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớp";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(98, 18);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(140, 20);
            this.txtMaSV.TabIndex = 11;
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(335, 18);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.ReadOnly = true;
            this.txtHovaTen.Size = new System.Drawing.Size(140, 20);
            this.txtHovaTen.TabIndex = 12;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(557, 18);
            this.txtLop.Name = "txtLop";
            this.txtLop.ReadOnly = true;
            this.txtLop.Size = new System.Drawing.Size(140, 20);
            this.txtLop.TabIndex = 13;
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(-3, 247);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(718, 233);
            this.dgvDiem.TabIndex = 22;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            this.dgvDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellContentClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(309, 215);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 26);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Danh Sách";
            // 
            // cbbTenMH
            // 
            this.cbbTenMH.FormattingEnabled = true;
            this.cbbTenMH.Location = new System.Drawing.Point(101, 4);
            this.cbbTenMH.Name = "cbbTenMH";
            this.cbbTenMH.Size = new System.Drawing.Size(140, 21);
            this.cbbTenMH.TabIndex = 24;
            this.cbbTenMH.SelectedIndexChanged += new System.EventHandler(this.cbbTenMH_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHovaTen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLop);
            this.groupBox1.Location = new System.Drawing.Point(-3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(718, 47);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDiemCK);
            this.groupBox2.Controls.Add(this.txtDiemTB);
            this.groupBox2.Controls.Add(this.txtDiemGK);
            this.groupBox2.Controls.Add(this.txtDiemBT);
            this.groupBox2.Controls.Add(this.txtDiemCC);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(-3, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 108);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điểm";
            // 
            // txtDiemCK
            // 
            this.txtDiemCK.Location = new System.Drawing.Point(538, 55);
            this.txtDiemCK.Name = "txtDiemCK";
            this.txtDiemCK.Size = new System.Drawing.Size(140, 20);
            this.txtDiemCK.TabIndex = 11;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(377, 84);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.ReadOnly = true;
            this.txtDiemTB.Size = new System.Drawing.Size(140, 20);
            this.txtDiemTB.TabIndex = 10;
            // 
            // txtDiemGK
            // 
            this.txtDiemGK.Location = new System.Drawing.Point(168, 52);
            this.txtDiemGK.Name = "txtDiemGK";
            this.txtDiemGK.Size = new System.Drawing.Size(140, 20);
            this.txtDiemGK.TabIndex = 9;
            // 
            // txtDiemBT
            // 
            this.txtDiemBT.Location = new System.Drawing.Point(538, 19);
            this.txtDiemBT.Name = "txtDiemBT";
            this.txtDiemBT.Size = new System.Drawing.Size(140, 20);
            this.txtDiemBT.TabIndex = 8;
            // 
            // txtDiemCC
            // 
            this.txtDiemCC.Location = new System.Drawing.Point(168, 19);
            this.txtDiemCC.Name = "txtDiemCC";
            this.txtDiemCC.Size = new System.Drawing.Size(140, 20);
            this.txtDiemCC.TabIndex = 6;
            this.txtDiemCC.TextChanged += new System.EventHandler(this.txtDiemCC_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Điểm trung bình";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Điểm cuối kỳ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Điểm giữa kỳ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Điểm bài tập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm chuyên cần";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(581, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 23);
            this.btnLoad.TabIndex = 28;
            this.btnLoad.Text = "Tải Danh Sách";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbbMaHK
            // 
            this.cbbMaHK.FormattingEnabled = true;
            this.cbbMaHK.Location = new System.Drawing.Point(414, 6);
            this.cbbMaHK.Name = "cbbMaHK";
            this.cbbMaHK.Size = new System.Drawing.Size(140, 21);
            this.cbbMaHK.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Mã học kỳ";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(581, 215);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(113, 26);
            this.btn_Save.TabIndex = 29;
            this.btn_Save.Text = "Lưu điểm";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 480);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cbbMaHK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbTenMH);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDiem);
            this.Name = "NhapDiem";
            this.Text = "NhapDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.DataGridView dgvDiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbbTenMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiemCK;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.TextBox txtDiemGK;
        private System.Windows.Forms.TextBox txtDiemBT;
        private System.Windows.Forms.TextBox txtDiemCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbbMaHK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Save;
    }
}