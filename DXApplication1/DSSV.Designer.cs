namespace DXApplication1
{
    partial class DSSV
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbnameless = new System.Windows.Forms.ComboBox();
            this.rbtk = new System.Windows.Forms.RadioButton();
            this.rbtlhp = new System.Windows.Forms.RadioButton();
            this.rbtlsh = new System.Windows.Forms.RadioButton();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(249, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(239, 26);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Xuất danh sách sinh viên";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbnameless);
            this.panelControl1.Controls.Add(this.rbtk);
            this.panelControl1.Controls.Add(this.rbtlhp);
            this.panelControl1.Controls.Add(this.rbtlsh);
            this.panelControl1.Location = new System.Drawing.Point(144, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(386, 100);
            this.panelControl1.TabIndex = 1;
            // 
            // cbbnameless
            // 
            this.cbbnameless.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbnameless.FormattingEnabled = true;
            this.cbbnameless.Location = new System.Drawing.Point(145, 53);
            this.cbbnameless.Name = "cbbnameless";
            this.cbbnameless.Size = new System.Drawing.Size(121, 21);
            this.cbbnameless.TabIndex = 3;
            // 
            // rbtk
            // 
            this.rbtk.AutoSize = true;
            this.rbtk.Location = new System.Drawing.Point(295, 16);
            this.rbtk.Name = "rbtk";
            this.rbtk.Size = new System.Drawing.Size(49, 17);
            this.rbtk.TabIndex = 2;
            this.rbtk.TabStop = true;
            this.rbtk.Text = "Khoa";
            this.rbtk.UseVisualStyleBackColor = true;
            this.rbtk.CheckedChanged += new System.EventHandler(this.rbtk_CheckedChanged);
            // 
            // rbtlhp
            // 
            this.rbtlhp.AutoSize = true;
            this.rbtlhp.Location = new System.Drawing.Point(145, 16);
            this.rbtlhp.Name = "rbtlhp";
            this.rbtlhp.Size = new System.Drawing.Size(124, 17);
            this.rbtlhp.TabIndex = 1;
            this.rbtlhp.TabStop = true;
            this.rbtlhp.Text = "Lớp học phần (Điểm)";
            this.rbtlhp.UseVisualStyleBackColor = true;
            this.rbtlhp.CheckedChanged += new System.EventHandler(this.rbtlhp_CheckedChanged);
            // 
            // rbtlsh
            // 
            this.rbtlsh.AutoSize = true;
            this.rbtlsh.Location = new System.Drawing.Point(21, 16);
            this.rbtlsh.Name = "rbtlsh";
            this.rbtlsh.Size = new System.Drawing.Size(89, 17);
            this.rbtlsh.TabIndex = 0;
            this.rbtlsh.TabStop = true;
            this.rbtlsh.Text = "Lớp sinh hoạt";
            this.rbtlsh.UseVisualStyleBackColor = true;
            this.rbtlsh.CheckedChanged += new System.EventHandler(this.rbtlsh_CheckedChanged);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(38, 199);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất file";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(654, 59);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 38);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Tải danh sách";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Location = new System.Drawing.Point(-1, 228);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.Size = new System.Drawing.Size(801, 224);
            this.dgvDSSV.TabIndex = 5;
            // 
            // DSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "DSSV";
            this.Text = "DSSV";
            this.Load += new System.EventHandler(this.DSSV_Load);
            this.SizeChanged += new System.EventHandler(this.AnaMenu_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbnameless;
        private System.Windows.Forms.RadioButton rbtk;
        private System.Windows.Forms.RadioButton rbtlhp;
        private System.Windows.Forms.RadioButton rbtlsh;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvDSSV;
    }
}