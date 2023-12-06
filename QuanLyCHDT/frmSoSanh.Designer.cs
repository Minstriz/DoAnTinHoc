namespace QuanLyCHDT
{
    partial class frmSoSanh
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
            this.dgvDienThoai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSanPham = new System.Windows.Forms.GroupBox();
            this.txtHangSanXuat = new System.Windows.Forms.TextBox();
            this.txtTenDienThoai = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtRom = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIDSanPham = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeDieuHanh = new System.Windows.Forms.TextBox();
            this.txtChip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtManHinh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHang2 = new System.Windows.Forms.TextBox();
            this.txtTen2 = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap2 = new System.Windows.Forms.TextBox();
            this.txtRam2 = new System.Windows.Forms.TextBox();
            this.txtGiaNhap2 = new System.Windows.Forms.TextBox();
            this.txtRom2 = new System.Windows.Forms.TextBox();
            this.txtGiaBan2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.txtPin2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtHeDieuHanh2 = new System.Windows.Forms.TextBox();
            this.txtChip2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtManHinh2 = new System.Windows.Forms.TextBox();
            this.btnXoaSanPham2 = new System.Windows.Forms.Button();
            this.brnSanPhamSoSanh2 = new System.Windows.Forms.Button();
            this.btnXoaSanPhamSoSanh1 = new System.Windows.Forms.Button();
            this.btnSanPhamSoSanh1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).BeginInit();
            this.gbSanPham.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDienThoai
            // 
            this.dgvDienThoai.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvDienThoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienThoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column11,
            this.Column7,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column4,
            this.pin,
            this.Column8,
            this.Column9});
            this.dgvDienThoai.Location = new System.Drawing.Point(25, 22);
            this.dgvDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDienThoai.Name = "dgvDienThoai";
            this.dgvDienThoai.RowHeadersWidth = 51;
            this.dgvDienThoai.RowTemplate.Height = 24;
            this.dgvDienThoai.ShowCellErrors = false;
            this.dgvDienThoai.Size = new System.Drawing.Size(967, 248);
            this.dgvDienThoai.TabIndex = 173;
            this.dgvDienThoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDienThoai_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdSanPham";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDienThoai";
            this.Column2.HeaderText = "Tên điện thoại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HangSanXuat";
            this.Column3.HeaderText = "Hãng ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Chip";
            this.Column11.HeaderText = "Chip";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "HeDieuHanh";
            this.Column7.HeaderText = "Hệ điều hành";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Ram";
            this.Column5.HeaderText = "Ram (GB)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Rom";
            this.Column6.HeaderText = "Dung lượng (GB)";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SoLuongNhap";
            this.Column10.HeaderText = "Số lượng nhập ";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ManHinh";
            this.Column4.HeaderText = "Màn hình (Inch)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // pin
            // 
            this.pin.DataPropertyName = "Pin";
            this.pin.HeaderText = "Pin (MAH)";
            this.pin.MinimumWidth = 6;
            this.pin.Name = "pin";
            this.pin.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "GiaNhap";
            this.Column8.HeaderText = "Giá nhập (VND)";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "GiaBan";
            this.Column9.HeaderText = "Giá bán (VND)";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // gbSanPham
            // 
            this.gbSanPham.BackColor = System.Drawing.Color.PapayaWhip;
            this.gbSanPham.Controls.Add(this.txtHangSanXuat);
            this.gbSanPham.Controls.Add(this.txtTenDienThoai);
            this.gbSanPham.Controls.Add(this.txtSoLuongNhap);
            this.gbSanPham.Controls.Add(this.txtRam);
            this.gbSanPham.Controls.Add(this.txtGiaNhap);
            this.gbSanPham.Controls.Add(this.txtRom);
            this.gbSanPham.Controls.Add(this.txtGiaBan);
            this.gbSanPham.Controls.Add(this.label10);
            this.gbSanPham.Controls.Add(this.label14);
            this.gbSanPham.Controls.Add(this.label9);
            this.gbSanPham.Controls.Add(this.label15);
            this.gbSanPham.Controls.Add(this.label23);
            this.gbSanPham.Controls.Add(this.label16);
            this.gbSanPham.Controls.Add(this.label22);
            this.gbSanPham.Controls.Add(this.label17);
            this.gbSanPham.Controls.Add(this.txtIDSanPham);
            this.gbSanPham.Controls.Add(this.txtPin);
            this.gbSanPham.Controls.Add(this.label8);
            this.gbSanPham.Controls.Add(this.label5);
            this.gbSanPham.Controls.Add(this.txtHeDieuHanh);
            this.gbSanPham.Controls.Add(this.txtChip);
            this.gbSanPham.Controls.Add(this.label7);
            this.gbSanPham.Controls.Add(this.label6);
            this.gbSanPham.Controls.Add(this.txtManHinh);
            this.gbSanPham.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSanPham.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbSanPham.Location = new System.Drawing.Point(39, 371);
            this.gbSanPham.Name = "gbSanPham";
            this.gbSanPham.Size = new System.Drawing.Size(471, 606);
            this.gbSanPham.TabIndex = 227;
            this.gbSanPham.TabStop = false;
            this.gbSanPham.Text = "Thông tin sản phẩm";
            // 
            // txtHangSanXuat
            // 
            this.txtHangSanXuat.BackColor = System.Drawing.Color.FloralWhite;
            this.txtHangSanXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHangSanXuat.Location = new System.Drawing.Point(155, 131);
            this.txtHangSanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHangSanXuat.Name = "txtHangSanXuat";
            this.txtHangSanXuat.Size = new System.Drawing.Size(242, 34);
            this.txtHangSanXuat.TabIndex = 226;
            // 
            // txtTenDienThoai
            // 
            this.txtTenDienThoai.BackColor = System.Drawing.Color.FloralWhite;
            this.txtTenDienThoai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDienThoai.Location = new System.Drawing.Point(155, 89);
            this.txtTenDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDienThoai.Name = "txtTenDienThoai";
            this.txtTenDienThoai.Size = new System.Drawing.Size(242, 34);
            this.txtTenDienThoai.TabIndex = 201;
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.BackColor = System.Drawing.Color.FloralWhite;
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(155, 452);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(242, 34);
            this.txtSoLuongNhap.TabIndex = 208;
            // 
            // txtRam
            // 
            this.txtRam.BackColor = System.Drawing.Color.FloralWhite;
            this.txtRam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRam.Location = new System.Drawing.Point(155, 226);
            this.txtRam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(242, 34);
            this.txtRam.TabIndex = 205;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.FloralWhite;
            this.txtGiaNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(155, 499);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(242, 34);
            this.txtGiaNhap.TabIndex = 209;
            // 
            // txtRom
            // 
            this.txtRom.BackColor = System.Drawing.Color.FloralWhite;
            this.txtRom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRom.Location = new System.Drawing.Point(155, 268);
            this.txtRom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRom.Name = "txtRom";
            this.txtRom.Size = new System.Drawing.Size(242, 34);
            this.txtRom.TabIndex = 206;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.FloralWhite;
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(157, 545);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(242, 34);
            this.txtGiaBan.TabIndex = 210;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(19, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 24);
            this.label10.TabIndex = 213;
            this.label10.Text = "Tên điện thoại";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(15, 456);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 24);
            this.label14.TabIndex = 222;
            this.label14.Text = "Số lượng nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(19, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 24);
            this.label9.TabIndex = 214;
            this.label9.Text = "Hãng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(51, 498);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 24);
            this.label15.TabIndex = 223;
            this.label15.Text = "Giá nhập";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(25, 230);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 24);
            this.label23.TabIndex = 215;
            this.label23.Text = "Ram";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(62, 540);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 24);
            this.label16.TabIndex = 224;
            this.label16.Text = "Giá bán";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(25, 272);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 24);
            this.label22.TabIndex = 216;
            this.label22.Text = "Rom";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(26, 408);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 24);
            this.label17.TabIndex = 221;
            this.label17.Text = "Pin";
            // 
            // txtIDSanPham
            // 
            this.txtIDSanPham.BackColor = System.Drawing.Color.FloralWhite;
            this.txtIDSanPham.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSanPham.Location = new System.Drawing.Point(155, 46);
            this.txtIDSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDSanPham.Name = "txtIDSanPham";
            this.txtIDSanPham.Size = new System.Drawing.Size(242, 34);
            this.txtIDSanPham.TabIndex = 200;
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.FloralWhite;
            this.txtPin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(155, 404);
            this.txtPin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(242, 34);
            this.txtPin.TabIndex = 207;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(19, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 24);
            this.label8.TabIndex = 217;
            this.label8.Text = "ID Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(26, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 220;
            this.label5.Text = "Chip";
            // 
            // txtHeDieuHanh
            // 
            this.txtHeDieuHanh.BackColor = System.Drawing.Color.FloralWhite;
            this.txtHeDieuHanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeDieuHanh.Location = new System.Drawing.Point(155, 176);
            this.txtHeDieuHanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeDieuHanh.Name = "txtHeDieuHanh";
            this.txtHeDieuHanh.Size = new System.Drawing.Size(242, 34);
            this.txtHeDieuHanh.TabIndex = 202;
            // 
            // txtChip
            // 
            this.txtChip.BackColor = System.Drawing.Color.FloralWhite;
            this.txtChip.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChip.Location = new System.Drawing.Point(155, 356);
            this.txtChip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChip.Name = "txtChip";
            this.txtChip.Size = new System.Drawing.Size(242, 34);
            this.txtChip.TabIndex = 204;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(19, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 218;
            this.label7.Text = "Hệ điều hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 219;
            this.label6.Text = "Màn hình";
            // 
            // txtManHinh
            // 
            this.txtManHinh.BackColor = System.Drawing.Color.FloralWhite;
            this.txtManHinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManHinh.Location = new System.Drawing.Point(155, 314);
            this.txtManHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.Size = new System.Drawing.Size(242, 34);
            this.txtManHinh.TabIndex = 203;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.txtHang2);
            this.groupBox1.Controls.Add(this.txtTen2);
            this.groupBox1.Controls.Add(this.txtSoLuongNhap2);
            this.groupBox1.Controls.Add(this.txtRam2);
            this.groupBox1.Controls.Add(this.txtGiaNhap2);
            this.groupBox1.Controls.Add(this.txtRom2);
            this.groupBox1.Controls.Add(this.txtGiaBan2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtId2);
            this.groupBox1.Controls.Add(this.txtPin2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtHeDieuHanh2);
            this.groupBox1.Controls.Add(this.txtChip2);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtManHinh2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(535, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 606);
            this.groupBox1.TabIndex = 228;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtHang2
            // 
            this.txtHang2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtHang2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHang2.Location = new System.Drawing.Point(157, 131);
            this.txtHang2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHang2.Name = "txtHang2";
            this.txtHang2.Size = new System.Drawing.Size(242, 34);
            this.txtHang2.TabIndex = 225;
            // 
            // txtTen2
            // 
            this.txtTen2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtTen2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen2.Location = new System.Drawing.Point(155, 89);
            this.txtTen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen2.Name = "txtTen2";
            this.txtTen2.Size = new System.Drawing.Size(242, 34);
            this.txtTen2.TabIndex = 201;
            // 
            // txtSoLuongNhap2
            // 
            this.txtSoLuongNhap2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtSoLuongNhap2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongNhap2.Location = new System.Drawing.Point(155, 452);
            this.txtSoLuongNhap2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuongNhap2.Name = "txtSoLuongNhap2";
            this.txtSoLuongNhap2.Size = new System.Drawing.Size(242, 34);
            this.txtSoLuongNhap2.TabIndex = 208;
            // 
            // txtRam2
            // 
            this.txtRam2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtRam2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRam2.Location = new System.Drawing.Point(155, 226);
            this.txtRam2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRam2.Name = "txtRam2";
            this.txtRam2.Size = new System.Drawing.Size(242, 34);
            this.txtRam2.TabIndex = 205;
            // 
            // txtGiaNhap2
            // 
            this.txtGiaNhap2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtGiaNhap2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap2.Location = new System.Drawing.Point(155, 499);
            this.txtGiaNhap2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaNhap2.Name = "txtGiaNhap2";
            this.txtGiaNhap2.Size = new System.Drawing.Size(242, 34);
            this.txtGiaNhap2.TabIndex = 209;
            // 
            // txtRom2
            // 
            this.txtRom2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtRom2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRom2.Location = new System.Drawing.Point(155, 268);
            this.txtRom2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRom2.Name = "txtRom2";
            this.txtRom2.Size = new System.Drawing.Size(242, 34);
            this.txtRom2.TabIndex = 206;
            // 
            // txtGiaBan2
            // 
            this.txtGiaBan2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtGiaBan2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan2.Location = new System.Drawing.Point(157, 545);
            this.txtGiaBan2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan2.Name = "txtGiaBan2";
            this.txtGiaBan2.Size = new System.Drawing.Size(242, 34);
            this.txtGiaBan2.TabIndex = 210;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 213;
            this.label1.Text = "Tên điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 222;
            this.label2.Text = "Số lượng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(50, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 214;
            this.label3.Text = "Hãng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(51, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 223;
            this.label4.Text = "Giá nhập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(51, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 24);
            this.label11.TabIndex = 215;
            this.label11.Text = "Ram";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(62, 540);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 24);
            this.label12.TabIndex = 224;
            this.label12.Text = "Giá bán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(50, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 24);
            this.label13.TabIndex = 216;
            this.label13.Text = "Rom";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(62, 408);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 24);
            this.label18.TabIndex = 221;
            this.label18.Text = "Pin";
            // 
            // txtId2
            // 
            this.txtId2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtId2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId2.Location = new System.Drawing.Point(155, 46);
            this.txtId2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(242, 34);
            this.txtId2.TabIndex = 200;
            // 
            // txtPin2
            // 
            this.txtPin2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtPin2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin2.Location = new System.Drawing.Point(155, 404);
            this.txtPin2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPin2.Name = "txtPin2";
            this.txtPin2.Size = new System.Drawing.Size(242, 34);
            this.txtPin2.TabIndex = 207;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(19, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 24);
            this.label19.TabIndex = 217;
            this.label19.Text = "ID Sản Phẩm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(56, 360);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 24);
            this.label20.TabIndex = 220;
            this.label20.Text = "Chip";
            // 
            // txtHeDieuHanh2
            // 
            this.txtHeDieuHanh2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtHeDieuHanh2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeDieuHanh2.Location = new System.Drawing.Point(155, 176);
            this.txtHeDieuHanh2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHeDieuHanh2.Name = "txtHeDieuHanh2";
            this.txtHeDieuHanh2.Size = new System.Drawing.Size(242, 34);
            this.txtHeDieuHanh2.TabIndex = 202;
            // 
            // txtChip2
            // 
            this.txtChip2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtChip2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChip2.Location = new System.Drawing.Point(155, 356);
            this.txtChip2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChip2.Name = "txtChip2";
            this.txtChip2.Size = new System.Drawing.Size(242, 34);
            this.txtChip2.TabIndex = 204;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(6, 180);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 24);
            this.label21.TabIndex = 218;
            this.label21.Text = "Hệ điều hành";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(37, 318);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 24);
            this.label24.TabIndex = 219;
            this.label24.Text = "Màn hình";
            // 
            // txtManHinh2
            // 
            this.txtManHinh2.BackColor = System.Drawing.Color.FloralWhite;
            this.txtManHinh2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManHinh2.Location = new System.Drawing.Point(155, 314);
            this.txtManHinh2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManHinh2.Name = "txtManHinh2";
            this.txtManHinh2.Size = new System.Drawing.Size(242, 34);
            this.txtManHinh2.TabIndex = 203;
            // 
            // btnXoaSanPham2
            // 
            this.btnXoaSanPham2.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnXoaSanPham2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanPham2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnXoaSanPham2.Location = new System.Drawing.Point(811, 296);
            this.btnXoaSanPham2.Name = "btnXoaSanPham2";
            this.btnXoaSanPham2.Size = new System.Drawing.Size(121, 38);
            this.btnXoaSanPham2.TabIndex = 232;
            this.btnXoaSanPham2.Text = "Xóa SP2";
            this.btnXoaSanPham2.UseVisualStyleBackColor = false;
            this.btnXoaSanPham2.Click += new System.EventHandler(this.btnXoaSanPham2_Click);
            // 
            // brnSanPhamSoSanh2
            // 
            this.brnSanPhamSoSanh2.BackColor = System.Drawing.Color.PapayaWhip;
            this.brnSanPhamSoSanh2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnSanPhamSoSanh2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.brnSanPhamSoSanh2.Location = new System.Drawing.Point(663, 296);
            this.brnSanPhamSoSanh2.Name = "brnSanPhamSoSanh2";
            this.brnSanPhamSoSanh2.Size = new System.Drawing.Size(121, 38);
            this.brnSanPhamSoSanh2.TabIndex = 231;
            this.brnSanPhamSoSanh2.Text = "Thêm SP2";
            this.brnSanPhamSoSanh2.UseVisualStyleBackColor = false;
            this.brnSanPhamSoSanh2.Click += new System.EventHandler(this.brnSanPhamSoSanh2_Click);
            // 
            // btnXoaSanPhamSoSanh1
            // 
            this.btnXoaSanPhamSoSanh1.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnXoaSanPhamSoSanh1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanPhamSoSanh1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnXoaSanPhamSoSanh1.Location = new System.Drawing.Point(278, 296);
            this.btnXoaSanPhamSoSanh1.Name = "btnXoaSanPhamSoSanh1";
            this.btnXoaSanPhamSoSanh1.Size = new System.Drawing.Size(121, 38);
            this.btnXoaSanPhamSoSanh1.TabIndex = 230;
            this.btnXoaSanPhamSoSanh1.Text = "Xóa SP1";
            this.btnXoaSanPhamSoSanh1.UseVisualStyleBackColor = false;
            this.btnXoaSanPhamSoSanh1.Click += new System.EventHandler(this.btnXoaSanPhamSoSanh1_Click);
            // 
            // btnSanPhamSoSanh1
            // 
            this.btnSanPhamSoSanh1.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSanPhamSoSanh1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPhamSoSanh1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSanPhamSoSanh1.Location = new System.Drawing.Point(132, 296);
            this.btnSanPhamSoSanh1.Name = "btnSanPhamSoSanh1";
            this.btnSanPhamSoSanh1.Size = new System.Drawing.Size(121, 38);
            this.btnSanPhamSoSanh1.TabIndex = 229;
            this.btnSanPhamSoSanh1.Text = "Thêm SP1";
            this.btnSanPhamSoSanh1.UseVisualStyleBackColor = false;
            this.btnSanPhamSoSanh1.Click += new System.EventHandler(this.btnSanPhamSoSanh1_Click);
            // 
            // frmSoSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 1018);
            this.Controls.Add(this.btnXoaSanPham2);
            this.Controls.Add(this.brnSanPhamSoSanh2);
            this.Controls.Add(this.btnXoaSanPhamSoSanh1);
            this.Controls.Add(this.btnSanPhamSoSanh1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSanPham);
            this.Controls.Add(this.dgvDienThoai);
            this.Name = "frmSoSanh";
            this.Text = "frmSoSanh";
            this.Load += new System.EventHandler(this.frmSoSanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).EndInit();
            this.gbSanPham.ResumeLayout(false);
            this.gbSanPham.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.GroupBox gbSanPham;
        private System.Windows.Forms.TextBox txtTenDienThoai;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtRom;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIDSanPham;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHeDieuHanh;
        private System.Windows.Forms.TextBox txtChip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtManHinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTen2;
        private System.Windows.Forms.TextBox txtSoLuongNhap2;
        private System.Windows.Forms.TextBox txtRam2;
        private System.Windows.Forms.TextBox txtGiaNhap2;
        private System.Windows.Forms.TextBox txtRom2;
        private System.Windows.Forms.TextBox txtGiaBan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.TextBox txtPin2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtHeDieuHanh2;
        private System.Windows.Forms.TextBox txtChip2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtManHinh2;
        private System.Windows.Forms.Button btnXoaSanPham2;
        private System.Windows.Forms.Button brnSanPhamSoSanh2;
        private System.Windows.Forms.Button btnXoaSanPhamSoSanh1;
        private System.Windows.Forms.Button btnSanPhamSoSanh1;
        private System.Windows.Forms.TextBox txtHangSanXuat;
        private System.Windows.Forms.TextBox txtHang2;
    }
}