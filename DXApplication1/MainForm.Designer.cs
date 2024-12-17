namespace DXApplication1
{
    partial class MainForm
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
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ThemMonHoc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ư = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement17 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement18 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Khoa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Lop = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement19 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement20 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement21 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControlElement13 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSeparator1,
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement6,
            this.accordionControlElement8,
            this.accordionControlElement7,
            this.accordionControlElement9,
            this.accordionControlElement11});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(260, 442);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Quản Lý Sinh Viên";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Thêm Sinh Viên";
            this.accordionControlElement3.Click += new System.EventHandler(this.ThemSV_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Sửa/Xóa Sinh viên";
            this.accordionControlElement4.Click += new System.EventHandler(this.Sua_Xoa_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement10});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Quản Lý Điểm";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Nhâp điểm";
            this.accordionControlElement10.Click += new System.EventHandler(this.accordionControlElement10_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ThemMonHoc,
            this.ư});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Quản Lý Môn Học";
            // 
            // ThemMonHoc
            // 
            this.ThemMonHoc.Name = "ThemMonHoc";
            this.ThemMonHoc.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ThemMonHoc.Text = "Thêm môn học";
            this.ThemMonHoc.Click += new System.EventHandler(this.ThemMonHoc_Click);
            // 
            // ư
            // 
            this.ư.Name = "ư";
            this.ư.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ư.Text = "Sửa/Xóa môn học";
            this.ư.Click += new System.EventHandler(this.Sua_XoaMonHoc_Click);
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement17,
            this.accordionControlElement18});
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Text = "Tìm Kiếm";
            // 
            // accordionControlElement17
            // 
            this.accordionControlElement17.Name = "accordionControlElement17";
            this.accordionControlElement17.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement17.Text = "Tìm kiếm theo tên";
            // 
            // accordionControlElement18
            // 
            this.accordionControlElement18.Name = "accordionControlElement18";
            this.accordionControlElement18.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement18.Text = "Tìm kiếm theo mã";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Khoa,
            this.Lop});
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "Quản Lý Khoa/Lớp";
            // 
            // Khoa
            // 
            this.Khoa.Name = "Khoa";
            this.Khoa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Khoa.Text = "Khoa";
            this.Khoa.Click += new System.EventHandler(this.Khoa_Click);
            // 
            // Lop
            // 
            this.Lop.Name = "Lop";
            this.Lop.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.Lop.Text = "Lớp";
            this.Lop.Click += new System.EventHandler(this.Lop_Click);
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement19,
            this.accordionControlElement20,
            this.accordionControlElement21});
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Text = "Báo Cáo Thống Kê";
            // 
            // accordionControlElement19
            // 
            this.accordionControlElement19.Name = "accordionControlElement19";
            this.accordionControlElement19.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement19.Text = "In danh sách sinh viên theo lớp";
            // 
            // accordionControlElement20
            // 
            this.accordionControlElement20.Name = "accordionControlElement20";
            this.accordionControlElement20.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement20.Text = "In danh sách sinh viên theo khoa";
            // 
            // accordionControlElement21
            // 
            this.accordionControlElement21.Name = "accordionControlElement21";
            this.accordionControlElement21.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement21.Text = "In điểm sinh viên theo lớp";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement12});
            this.accordionControlElement11.Expanded = true;
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Text = "FOR ADMIN DUMP DATA";
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement12.Text = "Đăng ký môn học";
            this.accordionControlElement12.Click += new System.EventHandler(this.accordionControlElement12_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(691, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3,
            this.bar4});
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1});
            this.fluentFormDefaultManager1.MainMenu = this.bar1;
            this.fluentFormDefaultManager1.MaxItemId = 1;
            this.fluentFormDefaultManager1.StatusBar = this.bar2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 4";
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.Text = "Custom 4";
            // 
            // bar4
            // 
            this.bar4.BarName = "Custom 5";
            this.bar4.DockCol = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Custom 5";
            // 
            // container
            // 
            this.container.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(260, 31);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(431, 442);
            this.container.TabIndex = 0;
            // 
            // accordionControlElement13
            // 
            this.accordionControlElement13.Name = "accordionControlElement13";
            this.accordionControlElement13.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement13.Text = "Thêm giảng viên";
            this.accordionControlElement13.Click += new System.EventHandler(this.ThemGV_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement13});
            this.accordionControlElement5.Expanded = true;
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Giảng Viên";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 473);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.Text = "FluentDesignForm1";
            this.Load += new System.EventHandler(this.FluentDesignForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ThemMonHoc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ư;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement17;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement18;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement19;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement20;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement21;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Khoa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Lop;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement13;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
    }
}