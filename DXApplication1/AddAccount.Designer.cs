namespace DXApplication1
{
    partial class AddAccount
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
            this.aaaa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnfind = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btntao = new System.Windows.Forms.Button();
            this.dgvTao = new System.Windows.Forms.DataGridView();
            this.dgvTim = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // aaaa
            // 
            this.aaaa.AutoSize = true;
            this.aaaa.Location = new System.Drawing.Point(21, 28);
            this.aaaa.Name = "aaaa";
            this.aaaa.Size = new System.Drawing.Size(82, 13);
            this.aaaa.TabIndex = 0;
            this.aaaa.Text = "Nhập username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(152, 28);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(126, 21);
            this.txtfind.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(152, 26);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(126, 21);
            this.txtuser.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(152, 53);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(126, 21);
            this.txtpass.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnfind);
            this.groupControl1.Controls.Add(this.aaaa);
            this.groupControl1.Controls.Add(this.txtfind);
            this.groupControl1.Location = new System.Drawing.Point(14, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(429, 80);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Tìm kiếm";
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(330, 28);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(84, 34);
            this.btnfind.TabIndex = 4;
            this.btnfind.Text = "Tìm";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btntao);
            this.groupControl2.Controls.Add(this.txtuser);
            this.groupControl2.Controls.Add(this.txtpass);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Location = new System.Drawing.Point(14, 89);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(429, 87);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Tạo";
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(330, 29);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(84, 37);
            this.btntao.TabIndex = 6;
            this.btntao.Text = "Tạo";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // dgvTao
            // 
            this.dgvTao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTao.Location = new System.Drawing.Point(-1, 218);
            this.dgvTao.Name = "dgvTao";
            this.dgvTao.Size = new System.Drawing.Size(803, 234);
            this.dgvTao.TabIndex = 8;
            // 
            // dgvTim
            // 
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTim.Location = new System.Drawing.Point(463, 3);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.Size = new System.Drawing.Size(339, 209);
            this.dgvTim.TabIndex = 9;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.dgvTao);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.SizeChanged += new System.EventHandler(this.AnaMenu_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label aaaa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnfind;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.DataGridView dgvTao;
        private System.Windows.Forms.DataGridView dgvTim;
    }
}