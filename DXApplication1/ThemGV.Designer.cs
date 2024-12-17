namespace DXApplication1
{
    partial class ThemGV
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaGiangVien = new System.Windows.Forms.TextBox();
            this.txtTenGiangVien = new System.Windows.Forms.TextBox();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giảng viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên giảng viên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(113, 131);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(215, 26);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Danh sách giảng viên";
            // 
            // txtMaGiangVien
            // 
            this.txtMaGiangVien.Location = new System.Drawing.Point(113, 33);
            this.txtMaGiangVien.Name = "txtMaGiangVien";
            this.txtMaGiangVien.Size = new System.Drawing.Size(139, 20);
            this.txtMaGiangVien.TabIndex = 3;
            // 
            // txtTenGiangVien
            // 
            this.txtTenGiangVien.Location = new System.Drawing.Point(113, 92);
            this.txtTenGiangVien.Name = "txtTenGiangVien";
            this.txtTenGiangVien.Size = new System.Drawing.Size(139, 20);
            this.txtTenGiangVien.TabIndex = 4;
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGiangVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Location = new System.Drawing.Point(0, 158);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.Size = new System.Drawing.Size(424, 297);
            this.dgvGiangVien.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(300, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 33);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbnThoat
            // 
            this.tbnThoat.Location = new System.Drawing.Point(300, 92);
            this.tbnThoat.Name = "tbnThoat";
            this.tbnThoat.Size = new System.Drawing.Size(111, 33);
            this.tbnThoat.TabIndex = 7;
            this.tbnThoat.Text = "Thoát";
            this.tbnThoat.UseVisualStyleBackColor = true;
            this.tbnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ThemGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 451);
            this.Controls.Add(this.tbnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvGiangVien);
            this.Controls.Add(this.txtTenGiangVien);
            this.Controls.Add(this.txtMaGiangVien);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemGV";
            this.Text = "ThemGV";
            this.SizeChanged += new System.EventHandler(this.AnaMenu_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtMaGiangVien;
        private System.Windows.Forms.TextBox txtTenGiangVien;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button tbnThoat;
    }
}