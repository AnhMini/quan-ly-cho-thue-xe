namespace QL_ThueXe
{
    partial class FormMain
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
            this.menuStrip_1 = new System.Windows.Forms.MenuStrip();
            this.mit_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.mit_ThongTinNhom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mit_ExitAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mit_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mit_LoaiXe = new System.Windows.Forms.ToolStripMenuItem();
            this.mit_Xe = new System.Windows.Forms.ToolStripMenuItem();
            this.mit_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_1
            // 
            this.menuStrip_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mit_Home,
            this.mit_KhachHang,
            this.mit_LoaiXe,
            this.mit_Xe,
            this.mit_HoaDon});
            this.menuStrip_1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_1.Name = "menuStrip_1";
            this.menuStrip_1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip_1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip_1.TabIndex = 3;
            this.menuStrip_1.Text = "menuStrip1";
            // 
            // mit_Home
            // 
            this.mit_Home.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mit_ThongTinNhom,
            this.toolStripSeparator1,
            this.mit_ExitAll});
            this.mit_Home.Name = "mit_Home";
            this.mit_Home.Size = new System.Drawing.Size(54, 20);
            this.mit_Home.Text = "HOME";
            // 
            // mit_ThongTinNhom
            // 
            this.mit_ThongTinNhom.Name = "mit_ThongTinNhom";
            this.mit_ThongTinNhom.Size = new System.Drawing.Size(166, 22);
            this.mit_ThongTinNhom.Text = "Thông Tin Nhóm";
            this.mit_ThongTinNhom.Click += new System.EventHandler(this.mit_ThongTinNhom_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // mit_ExitAll
            // 
            this.mit_ExitAll.Name = "mit_ExitAll";
            this.mit_ExitAll.Size = new System.Drawing.Size(166, 22);
            this.mit_ExitAll.Text = "Exit";
            this.mit_ExitAll.Click += new System.EventHandler(this.mit_ExitAll_Click);
            // 
            // mit_KhachHang
            // 
            this.mit_KhachHang.Name = "mit_KhachHang";
            this.mit_KhachHang.Size = new System.Drawing.Size(97, 20);
            this.mit_KhachHang.Text = "KHÁCH HÀNG";
            this.mit_KhachHang.Click += new System.EventHandler(this.mit_KhachHang_Click);
            // 
            // mit_LoaiXe
            // 
            this.mit_LoaiXe.Name = "mit_LoaiXe";
            this.mit_LoaiXe.Size = new System.Drawing.Size(61, 20);
            this.mit_LoaiXe.Text = "LOẠI XE";
            this.mit_LoaiXe.Click += new System.EventHandler(this.mit_LoaiXe_Click);
            // 
            // mit_Xe
            // 
            this.mit_Xe.Name = "mit_Xe";
            this.mit_Xe.Size = new System.Drawing.Size(32, 20);
            this.mit_Xe.Text = "XE";
            this.mit_Xe.Click += new System.EventHandler(this.mit_Xe_Click);
            // 
            // mit_HoaDon
            // 
            this.mit_HoaDon.Name = "mit_HoaDon";
            this.mit_HoaDon.Size = new System.Drawing.Size(74, 20);
            this.mit_HoaDon.Text = "HÓA ĐƠN";
            this.mit_HoaDon.Click += new System.EventHandler(this.mit_HoaDon_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1050, 604);
            this.Controls.Add(this.menuStrip_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip_1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Nhóm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip_1.ResumeLayout(false);
            this.menuStrip_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_1;
        private System.Windows.Forms.ToolStripMenuItem mit_Home;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mit_ExitAll;
        private System.Windows.Forms.ToolStripMenuItem mit_HoaDon;
        private System.Windows.Forms.ToolStripMenuItem mit_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mit_LoaiXe;
        private System.Windows.Forms.ToolStripMenuItem mit_Xe;
        private System.Windows.Forms.ToolStripMenuItem mit_ThongTinNhom;

    }
}