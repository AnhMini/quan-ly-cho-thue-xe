namespace QL_ThueXe
{
    partial class Xe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xe));
            this.pnl_ChucNang = new System.Windows.Forms.Panel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.pnl_OkNoLoad = new System.Windows.Forms.Panel();
            this.btn_XoaHinhAnh = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.pnl_ThongTin = new System.Windows.Forms.Panel();
            this.txt_ID_Xe = new System.Windows.Forms.TextBox();
            this.txt_TenXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbx_TimKiem = new System.Windows.Forms.GroupBox();
            this.txt_NoiDungCanTim = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rdb_TenXe = new System.Windows.Forms.RadioButton();
            this.rdb_BienSo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pic_Xe = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_LoaiXe = new System.Windows.Forms.ComboBox();
            this.loaiXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_ThueXeDataSet = new QL_ThueXe.QL_ThueXeDataSet();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_BienSo = new System.Windows.Forms.TextBox();
            this.dgv_Xe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loaiXeTableAdapter = new QL_ThueXe.QL_ThueXeDataSetTableAdapters.LoaiXeTableAdapter();
            this.pnl_ChucNang.SuspendLayout();
            this.pnl_OkNoLoad.SuspendLayout();
            this.pnl_ThongTin.SuspendLayout();
            this.gbx_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Xe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiXeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThueXeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Xe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ChucNang
            // 
            this.pnl_ChucNang.Controls.Add(this.btn_Them);
            this.pnl_ChucNang.Controls.Add(this.btn_Dong);
            this.pnl_ChucNang.Controls.Add(this.btn_QuayLai);
            this.pnl_ChucNang.Controls.Add(this.btn_Xoa);
            this.pnl_ChucNang.Controls.Add(this.btn_CapNhat);
            this.pnl_ChucNang.Location = new System.Drawing.Point(0, 348);
            this.pnl_ChucNang.Name = "pnl_ChucNang";
            this.pnl_ChucNang.Size = new System.Drawing.Size(935, 129);
            this.pnl_ChucNang.TabIndex = 16;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Them.Location = new System.Drawing.Point(97, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(95, 96);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.BackColor = System.Drawing.Color.White;
            this.btn_Dong.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dong.Image")));
            this.btn_Dong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Dong.Location = new System.Drawing.Point(697, 12);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(95, 96);
            this.btn_Dong.TabIndex = 9;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Dong.UseVisualStyleBackColor = false;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.White;
            this.btn_QuayLai.Enabled = false;
            this.btn_QuayLai.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuayLai.Image")));
            this.btn_QuayLai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_QuayLai.Location = new System.Drawing.Point(547, 12);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(95, 96);
            this.btn_QuayLai.TabIndex = 1;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Xoa.Location = new System.Drawing.Point(397, 12);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(95, 96);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.Color.White;
            this.btn_CapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CapNhat.Image")));
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CapNhat.Location = new System.Drawing.Point(247, 12);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(95, 96);
            this.btn_CapNhat.TabIndex = 1;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // pnl_OkNoLoad
            // 
            this.pnl_OkNoLoad.Controls.Add(this.btn_XoaHinhAnh);
            this.pnl_OkNoLoad.Controls.Add(this.btn_Load);
            this.pnl_OkNoLoad.Controls.Add(this.btn_No);
            this.pnl_OkNoLoad.Controls.Add(this.btn_Ok);
            this.pnl_OkNoLoad.Location = new System.Drawing.Point(715, 5);
            this.pnl_OkNoLoad.Name = "pnl_OkNoLoad";
            this.pnl_OkNoLoad.Size = new System.Drawing.Size(201, 46);
            this.pnl_OkNoLoad.TabIndex = 14;
            this.pnl_OkNoLoad.Visible = false;
            // 
            // btn_XoaHinhAnh
            // 
            this.btn_XoaHinhAnh.BackColor = System.Drawing.Color.White;
            this.btn_XoaHinhAnh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_XoaHinhAnh.BackgroundImage")));
            this.btn_XoaHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_XoaHinhAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaHinhAnh.Location = new System.Drawing.Point(155, 4);
            this.btn_XoaHinhAnh.Name = "btn_XoaHinhAnh";
            this.btn_XoaHinhAnh.Size = new System.Drawing.Size(38, 38);
            this.btn_XoaHinhAnh.TabIndex = 12;
            this.btn_XoaHinhAnh.UseVisualStyleBackColor = false;
            this.btn_XoaHinhAnh.Click += new System.EventHandler(this.btn_XoaHinhAnh_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.White;
            this.btn_Load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Load.BackgroundImage")));
            this.btn_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Location = new System.Drawing.Point(106, 4);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(38, 38);
            this.btn_Load.TabIndex = 12;
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.White;
            this.btn_No.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_No.BackgroundImage")));
            this.btn_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Location = new System.Drawing.Point(56, 4);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(38, 38);
            this.btn_No.TabIndex = 12;
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.White;
            this.btn_Ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ok.BackgroundImage")));
            this.btn_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Location = new System.Drawing.Point(8, 4);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(38, 38);
            this.btn_Ok.TabIndex = 12;
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // pnl_ThongTin
            // 
            this.pnl_ThongTin.Controls.Add(this.pnl_OkNoLoad);
            this.pnl_ThongTin.Controls.Add(this.txt_ID_Xe);
            this.pnl_ThongTin.Controls.Add(this.txt_TenXe);
            this.pnl_ThongTin.Controls.Add(this.label2);
            this.pnl_ThongTin.Controls.Add(this.label8);
            this.pnl_ThongTin.Controls.Add(this.gbx_TimKiem);
            this.pnl_ThongTin.Controls.Add(this.label3);
            this.pnl_ThongTin.Controls.Add(this.label7);
            this.pnl_ThongTin.Controls.Add(this.label4);
            this.pnl_ThongTin.Controls.Add(this.pic_Xe);
            this.pnl_ThongTin.Controls.Add(this.label5);
            this.pnl_ThongTin.Controls.Add(this.cbx_LoaiXe);
            this.pnl_ThongTin.Controls.Add(this.txt_DonGia);
            this.pnl_ThongTin.Controls.Add(this.txt_BienSo);
            this.pnl_ThongTin.Location = new System.Drawing.Point(0, 83);
            this.pnl_ThongTin.Name = "pnl_ThongTin";
            this.pnl_ThongTin.Size = new System.Drawing.Size(935, 265);
            this.pnl_ThongTin.TabIndex = 17;
            // 
            // txt_ID_Xe
            // 
            this.txt_ID_Xe.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ID_Xe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_Xe.ForeColor = System.Drawing.Color.Red;
            this.txt_ID_Xe.Location = new System.Drawing.Point(100, 13);
            this.txt_ID_Xe.Name = "txt_ID_Xe";
            this.txt_ID_Xe.ReadOnly = true;
            this.txt_ID_Xe.Size = new System.Drawing.Size(42, 34);
            this.txt_ID_Xe.TabIndex = 13;
            this.txt_ID_Xe.Text = "1";
            this.txt_ID_Xe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TenXe
            // 
            this.txt_TenXe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenXe.Location = new System.Drawing.Point(100, 55);
            this.txt_TenXe.Name = "txt_TenXe";
            this.txt_TenXe.ReadOnly = true;
            this.txt_TenXe.Size = new System.Drawing.Size(138, 34);
            this.txt_TenXe.TabIndex = 13;
            this.txt_TenXe.Text = "Air Blade";
            this.txt_TenXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "STT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(477, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Hình Xe:";
            // 
            // gbx_TimKiem
            // 
            this.gbx_TimKiem.Controls.Add(this.txt_NoiDungCanTim);
            this.gbx_TimKiem.Controls.Add(this.btn_TimKiem);
            this.gbx_TimKiem.Controls.Add(this.label6);
            this.gbx_TimKiem.Controls.Add(this.rdb_TenXe);
            this.gbx_TimKiem.Controls.Add(this.rdb_BienSo);
            this.gbx_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbx_TimKiem.Location = new System.Drawing.Point(17, 146);
            this.gbx_TimKiem.Name = "gbx_TimKiem";
            this.gbx_TimKiem.Size = new System.Drawing.Size(428, 102);
            this.gbx_TimKiem.TabIndex = 2;
            this.gbx_TimKiem.TabStop = false;
            this.gbx_TimKiem.Text = "Các lựa chọn tìm kiếm";
            // 
            // txt_NoiDungCanTim
            // 
            this.txt_NoiDungCanTim.Enabled = false;
            this.txt_NoiDungCanTim.Location = new System.Drawing.Point(118, 66);
            this.txt_NoiDungCanTim.Name = "txt_NoiDungCanTim";
            this.txt_NoiDungCanTim.Size = new System.Drawing.Size(183, 22);
            this.txt_NoiDungCanTim.TabIndex = 2;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.Enabled = false;
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_TimKiem.Location = new System.Drawing.Point(326, 2);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(89, 97);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nội dung tìm kiếm:";
            // 
            // rdb_TenXe
            // 
            this.rdb_TenXe.AutoSize = true;
            this.rdb_TenXe.Location = new System.Drawing.Point(9, 37);
            this.rdb_TenXe.Name = "rdb_TenXe";
            this.rdb_TenXe.Size = new System.Drawing.Size(75, 21);
            this.rdb_TenXe.TabIndex = 0;
            this.rdb_TenXe.TabStop = true;
            this.rdb_TenXe.Text = "Tên Xe";
            this.rdb_TenXe.UseVisualStyleBackColor = true;
            this.rdb_TenXe.CheckedChanged += new System.EventHandler(this.rdb_TenXe_CheckedChanged);
            // 
            // rdb_BienSo
            // 
            this.rdb_BienSo.AutoSize = true;
            this.rdb_BienSo.Location = new System.Drawing.Point(9, 69);
            this.rdb_BienSo.Name = "rdb_BienSo";
            this.rdb_BienSo.Size = new System.Drawing.Size(78, 21);
            this.rdb_BienSo.TabIndex = 0;
            this.rdb_BienSo.TabStop = true;
            this.rdb_BienSo.Text = "Biển Số";
            this.rdb_BienSo.UseVisualStyleBackColor = true;
            this.rdb_BienSo.CheckedChanged += new System.EventHandler(this.rdb_BienSo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Xe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 107);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Đơn Giá";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại Xe";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pic_Xe
            // 
            this.pic_Xe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Xe.Location = new System.Drawing.Point(480, 55);
            this.pic_Xe.Name = "pic_Xe";
            this.pic_Xe.Size = new System.Drawing.Size(428, 201);
            this.pic_Xe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Xe.TabIndex = 8;
            this.pic_Xe.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Biển Số";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbx_LoaiXe
            // 
            this.cbx_LoaiXe.AllowDrop = true;
            this.cbx_LoaiXe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_LoaiXe.DataSource = this.loaiXeBindingSource;
            this.cbx_LoaiXe.DisplayMember = "TenLoaiXe";
            this.cbx_LoaiXe.Enabled = false;
            this.cbx_LoaiXe.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_LoaiXe.FormattingEnabled = true;
            this.cbx_LoaiXe.Location = new System.Drawing.Point(346, 57);
            this.cbx_LoaiXe.Name = "cbx_LoaiXe";
            this.cbx_LoaiXe.Size = new System.Drawing.Size(125, 34);
            this.cbx_LoaiXe.TabIndex = 7;
            this.cbx_LoaiXe.ValueMember = "ID_LX";
            // 
            // loaiXeBindingSource
            // 
            this.loaiXeBindingSource.DataMember = "LoaiXe";
            this.loaiXeBindingSource.DataSource = this.qL_ThueXeDataSet;
            // 
            // qL_ThueXeDataSet
            // 
            this.qL_ThueXeDataSet.DataSetName = "QL_ThueXeDataSet";
            this.qL_ThueXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(346, 102);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(125, 34);
            this.txt_DonGia.TabIndex = 2;
            this.txt_DonGia.Text = "120,000";
            this.txt_DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_BienSo
            // 
            this.txt_BienSo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BienSo.Location = new System.Drawing.Point(100, 103);
            this.txt_BienSo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BienSo.Name = "txt_BienSo";
            this.txt_BienSo.ReadOnly = true;
            this.txt_BienSo.Size = new System.Drawing.Size(138, 34);
            this.txt_BienSo.TabIndex = 2;
            this.txt_BienSo.Text = "29-K5 6789";
            this.txt_BienSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_Xe
            // 
            this.dgv_Xe.AllowUserToAddRows = false;
            this.dgv_Xe.AllowUserToDeleteRows = false;
            this.dgv_Xe.AllowUserToResizeColumns = false;
            this.dgv_Xe.AllowUserToResizeRows = false;
            this.dgv_Xe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Xe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Xe.Location = new System.Drawing.Point(0, 477);
            this.dgv_Xe.Name = "dgv_Xe";
            this.dgv_Xe.ReadOnly = true;
            this.dgv_Xe.RowTemplate.Height = 24;
            this.dgv_Xe.Size = new System.Drawing.Size(935, 183);
            this.dgv_Xe.TabIndex = 15;
            this.dgv_Xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Xe_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(935, 81);
            this.label1.TabIndex = 14;
            this.label1.Text = "THÔNG TIN XE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // loaiXeTableAdapter
            // 
            this.loaiXeTableAdapter.ClearBeforeFill = true;
            // 
            // Xe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(935, 660);
            this.Controls.Add(this.pnl_ChucNang);
            this.Controls.Add(this.pnl_ThongTin);
            this.Controls.Add(this.dgv_Xe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Xe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.Xe_Load);
            this.pnl_ChucNang.ResumeLayout(false);
            this.pnl_OkNoLoad.ResumeLayout(false);
            this.pnl_ThongTin.ResumeLayout(false);
            this.pnl_ThongTin.PerformLayout();
            this.gbx_TimKiem.ResumeLayout(false);
            this.gbx_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Xe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiXeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_ThueXeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Xe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ChucNang;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Panel pnl_OkNoLoad;
        private System.Windows.Forms.Button btn_XoaHinhAnh;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Panel pnl_ThongTin;
        private System.Windows.Forms.TextBox txt_ID_Xe;
        private System.Windows.Forms.TextBox txt_TenXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbx_TimKiem;
        private System.Windows.Forms.TextBox txt_NoiDungCanTim;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdb_TenXe;
        private System.Windows.Forms.RadioButton rdb_BienSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_Xe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_LoaiXe;
        private System.Windows.Forms.TextBox txt_BienSo;
        private System.Windows.Forms.DataGridView dgv_Xe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private QL_ThueXeDataSet qL_ThueXeDataSet;
        private System.Windows.Forms.BindingSource loaiXeBindingSource;
        private QL_ThueXeDataSetTableAdapters.LoaiXeTableAdapter loaiXeTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DonGia;


    }
}