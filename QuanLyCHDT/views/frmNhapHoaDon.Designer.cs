namespace QuanLyCHDT.views
{
    partial class frmNhapHoaDon
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
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.txtIdChiTietHoaDon = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNDHsdt = new System.Windows.Forms.TextBox();
            this.lbTenKhachHangNHD = new System.Windows.Forms.Label();
            this.txtNDHTenKhachHang = new System.Windows.Forms.TextBox();
            this.lbMaKhachHangNHD = new System.Windows.Forms.Label();
            this.txtMaKhachHangNHD = new System.Windows.Forms.TextBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbLocTheo = new System.Windows.Forms.Label();
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.btnThemVaoGioHang = new System.Windows.Forms.Button();
            this.lbGioHang = new System.Windows.Forms.Label();
            this.btnXoaSpGioHang = new System.Windows.Forms.Button();
            this.btnTaoDonHang = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLocKH = new System.Windows.Forms.ComboBox();
            this.lbTxtNhapDuLieuTimKiem = new System.Windows.Forms.Label();
            this.txtLocKhachHang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
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
            this.dgvDienThoai.Location = new System.Drawing.Point(12, 68);
            this.dgvDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDienThoai.Name = "dgvDienThoai";
            this.dgvDienThoai.RowHeadersWidth = 51;
            this.dgvDienThoai.RowTemplate.Height = 24;
            this.dgvDienThoai.ShowCellErrors = false;
            this.dgvDienThoai.Size = new System.Drawing.Size(704, 293);
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
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(971, 499);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(277, 27);
            this.dateTimePicker3.TabIndex = 249;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(862, 720);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 24);
            this.label13.TabIndex = 248;
            this.label13.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.FloralWhite;
            this.txtTongTien.Location = new System.Drawing.Point(971, 723);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(277, 22);
            this.txtTongTien.TabIndex = 247;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(794, 496);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 24);
            this.label12.TabIndex = 246;
            this.label12.Text = "Ngày lập hóa đơn";
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.BackColor = System.Drawing.Color.Transparent;
            this.lbMaHoaDon.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHoaDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaHoaDon.Location = new System.Drawing.Point(843, 439);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(110, 24);
            this.lbMaHoaDon.TabIndex = 245;
            this.lbMaHoaDon.Text = "Mã hóa đơn";
            // 
            // txtIdChiTietHoaDon
            // 
            this.txtIdChiTietHoaDon.BackColor = System.Drawing.Color.FloralWhite;
            this.txtIdChiTietHoaDon.Location = new System.Drawing.Point(971, 438);
            this.txtIdChiTietHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdChiTietHoaDon.Name = "txtIdChiTietHoaDon";
            this.txtIdChiTietHoaDon.Size = new System.Drawing.Size(277, 22);
            this.txtIdChiTietHoaDon.TabIndex = 244;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(832, 660);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 24);
            this.label19.TabIndex = 243;
            this.label19.Text = "Số điện thoại";
            // 
            // txtNDHsdt
            // 
            this.txtNDHsdt.BackColor = System.Drawing.Color.FloralWhite;
            this.txtNDHsdt.Location = new System.Drawing.Point(971, 663);
            this.txtNDHsdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNDHsdt.Name = "txtNDHsdt";
            this.txtNDHsdt.Size = new System.Drawing.Size(277, 22);
            this.txtNDHsdt.TabIndex = 238;
            // 
            // lbTenKhachHangNHD
            // 
            this.lbTenKhachHangNHD.AutoSize = true;
            this.lbTenKhachHangNHD.BackColor = System.Drawing.Color.Transparent;
            this.lbTenKhachHangNHD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhachHangNHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTenKhachHangNHD.Location = new System.Drawing.Point(810, 605);
            this.lbTenKhachHangNHD.Name = "lbTenKhachHangNHD";
            this.lbTenKhachHangNHD.Size = new System.Drawing.Size(143, 24);
            this.lbTenKhachHangNHD.TabIndex = 240;
            this.lbTenKhachHangNHD.Text = "Tên khách hàng";
            // 
            // txtNDHTenKhachHang
            // 
            this.txtNDHTenKhachHang.BackColor = System.Drawing.Color.FloralWhite;
            this.txtNDHTenKhachHang.Location = new System.Drawing.Point(971, 611);
            this.txtNDHTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNDHTenKhachHang.Name = "txtNDHTenKhachHang";
            this.txtNDHTenKhachHang.Size = new System.Drawing.Size(277, 22);
            this.txtNDHTenKhachHang.TabIndex = 236;
            // 
            // lbMaKhachHangNHD
            // 
            this.lbMaKhachHangNHD.AutoSize = true;
            this.lbMaKhachHangNHD.BackColor = System.Drawing.Color.Transparent;
            this.lbMaKhachHangNHD.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhachHangNHD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbMaKhachHangNHD.Location = new System.Drawing.Point(810, 550);
            this.lbMaKhachHangNHD.Name = "lbMaKhachHangNHD";
            this.lbMaKhachHangNHD.Size = new System.Drawing.Size(138, 24);
            this.lbMaKhachHangNHD.TabIndex = 251;
            this.lbMaKhachHangNHD.Text = "Mã khách hàng";
            // 
            // txtMaKhachHangNHD
            // 
            this.txtMaKhachHangNHD.BackColor = System.Drawing.Color.FloralWhite;
            this.txtMaKhachHangNHD.Location = new System.Drawing.Point(971, 556);
            this.txtMaKhachHangNHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKhachHangNHD.Name = "txtMaKhachHangNHD";
            this.txtMaKhachHangNHD.Size = new System.Drawing.Size(277, 22);
            this.txtMaKhachHangNHD.TabIndex = 250;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvGioHang.Location = new System.Drawing.Point(12, 440);
            this.dgvGioHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.ShowCellErrors = false;
            this.dgvGioHang.Size = new System.Drawing.Size(704, 348);
            this.dgvGioHang.TabIndex = 252;
            this.dgvGioHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdSanPham";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDienThoai";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên điện thoại";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HangSanXuat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hãng ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Chip";
            this.dataGridViewTextBoxColumn4.HeaderText = "Chip";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HeDieuHanh";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hệ điều hành";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ram";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ram (GB)";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Rom";
            this.dataGridViewTextBoxColumn7.HeaderText = "Dung lượng (GB)";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SoLuongNhap";
            this.dataGridViewTextBoxColumn8.HeaderText = "Số lượng nhập ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ManHinh";
            this.dataGridViewTextBoxColumn9.HeaderText = "Màn hình (Inch)";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Pin";
            this.dataGridViewTextBoxColumn10.HeaderText = "Pin (MAH)";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "GiaNhap";
            this.dataGridViewTextBoxColumn11.HeaderText = "Giá nhập (VND)";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "GiaBan";
            this.dataGridViewTextBoxColumn12.HeaderText = "Giá bán (VND)";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // lbLocTheo
            // 
            this.lbLocTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocTheo.Location = new System.Drawing.Point(13, 23);
            this.lbLocTheo.Name = "lbLocTheo";
            this.lbLocTheo.Size = new System.Drawing.Size(81, 23);
            this.lbLocTheo.TabIndex = 255;
            this.lbLocTheo.Text = "Lọc theo";
            // 
            // cbLoc
            // 
            this.cbLoc.FormattingEnabled = true;
            this.cbLoc.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Chip",
            "Số lượng nhập",
            "Hệ điều hành",
            "Tên điện thoại",
            "Hãng",
            "Màn hình",
            "Ram",
            "Rom",
            "Dung lượng",
            "Pin",
            "Giá nhập",
            "Giá bán"});
            this.cbLoc.Location = new System.Drawing.Point(98, 22);
            this.cbLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(145, 24);
            this.cbLoc.TabIndex = 254;
            // 
            // txtLoc
            // 
            this.txtLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoc.ForeColor = System.Drawing.Color.Black;
            this.txtLoc.Location = new System.Drawing.Point(259, 23);
            this.txtLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoc.Multiline = true;
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(299, 24);
            this.txtLoc.TabIndex = 253;
            this.txtLoc.Tag = "Nhập dữ liệu tìm kiếm";
            this.txtLoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLoc_MouseClick);
            this.txtLoc.TextChanged += new System.EventHandler(this.txtLoc_TextChanged);
            // 
            // btnThemVaoGioHang
            // 
            this.btnThemVaoGioHang.Location = new System.Drawing.Point(336, 385);
            this.btnThemVaoGioHang.Name = "btnThemVaoGioHang";
            this.btnThemVaoGioHang.Size = new System.Drawing.Size(75, 36);
            this.btnThemVaoGioHang.TabIndex = 256;
            this.btnThemVaoGioHang.Text = "Thêm";
            this.btnThemVaoGioHang.UseVisualStyleBackColor = true;
            this.btnThemVaoGioHang.Click += new System.EventHandler(this.btnThemVaoGioHang_Click);
            // 
            // lbGioHang
            // 
            this.lbGioHang.AutoSize = true;
            this.lbGioHang.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioHang.Location = new System.Drawing.Point(12, 389);
            this.lbGioHang.Name = "lbGioHang";
            this.lbGioHang.Size = new System.Drawing.Size(89, 24);
            this.lbGioHang.TabIndex = 257;
            this.lbGioHang.Text = "Giỏ Hàng";
            // 
            // btnXoaSpGioHang
            // 
            this.btnXoaSpGioHang.Location = new System.Drawing.Point(417, 385);
            this.btnXoaSpGioHang.Name = "btnXoaSpGioHang";
            this.btnXoaSpGioHang.Size = new System.Drawing.Size(75, 36);
            this.btnXoaSpGioHang.TabIndex = 258;
            this.btnXoaSpGioHang.Text = "Xóa";
            this.btnXoaSpGioHang.UseVisualStyleBackColor = true;
            this.btnXoaSpGioHang.Click += new System.EventHandler(this.btnXoaSpGioHang_Click);
            // 
            // btnTaoDonHang
            // 
            this.btnTaoDonHang.Location = new System.Drawing.Point(1293, 692);
            this.btnTaoDonHang.Name = "btnTaoDonHang";
            this.btnTaoDonHang.Size = new System.Drawing.Size(107, 53);
            this.btnTaoDonHang.TabIndex = 259;
            this.btnTaoDonHang.Text = "Tạo đơn hàng";
            this.btnTaoDonHang.UseVisualStyleBackColor = true;
            this.btnTaoDonHang.Click += new System.EventHandler(this.btnTaoDonHang_Click);
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dgvKhachHang.Location = new System.Drawing.Point(758, 68);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.Size = new System.Drawing.Size(690, 293);
            this.dgvKhachHang.TabIndex = 260;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "MaKhachHang";
            this.dataGridViewTextBoxColumn13.HeaderText = "Mã Khách Hàng";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "TenKhachHang";
            this.dataGridViewTextBoxColumn14.HeaderText = "Tên Khách Hàng";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Phai";
            this.dataGridViewTextBoxColumn15.HeaderText = "Giới tính";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "NgayThangNamSinh";
            this.dataGridViewTextBoxColumn16.HeaderText = "Ngày Tháng Năm Sinh";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "DiaChiEmail";
            this.dataGridViewTextBoxColumn17.HeaderText = "Email";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "SoDienThoai";
            this.dataGridViewTextBoxColumn18.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(871, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 264;
            this.label1.Text = "Lọc theo";
            // 
            // cbLocKH
            // 
            this.cbLocKH.FormattingEnabled = true;
            this.cbLocKH.Items.AddRange(new object[] {
            "Mã Khách Hàng",
            "Tên Khách Hàng",
            "Giới tính",
            "Ngày Tháng Năm Sinh",
            "Email",
            "Số điện thoại",
            "Tài khoản",
            "Mật Khẩu"});
            this.cbLocKH.Location = new System.Drawing.Point(973, 19);
            this.cbLocKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLocKH.Name = "cbLocKH";
            this.cbLocKH.Size = new System.Drawing.Size(201, 24);
            this.cbLocKH.TabIndex = 263;
            // 
            // lbTxtNhapDuLieuTimKiem
            // 
            this.lbTxtNhapDuLieuTimKiem.AutoSize = true;
            this.lbTxtNhapDuLieuTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTxtNhapDuLieuTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTxtNhapDuLieuTimKiem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbTxtNhapDuLieuTimKiem.Location = new System.Drawing.Point(1190, 21);
            this.lbTxtNhapDuLieuTimKiem.Name = "lbTxtNhapDuLieuTimKiem";
            this.lbTxtNhapDuLieuTimKiem.Size = new System.Drawing.Size(134, 16);
            this.lbTxtNhapDuLieuTimKiem.TabIndex = 262;
            this.lbTxtNhapDuLieuTimKiem.Tag = "";
            this.lbTxtNhapDuLieuTimKiem.Text = "Tìm kiếm khách hàng";
            // 
            // txtLocKhachHang
            // 
            this.txtLocKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtLocKhachHang.Location = new System.Drawing.Point(1186, 13);
            this.txtLocKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocKhachHang.Multiline = true;
            this.txtLocKhachHang.Name = "txtLocKhachHang";
            this.txtLocKhachHang.Size = new System.Drawing.Size(262, 34);
            this.txtLocKhachHang.TabIndex = 261;
            this.txtLocKhachHang.Tag = "Nhập dữ liệu tìm kiếm";
            this.txtLocKhachHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLocKhachHang_MouseClick);
            this.txtLocKhachHang.TextChanged += new System.EventHandler(this.txtLocKhachHang_TextChanged);
            this.txtLocKhachHang.MouseCaptureChanged += new System.EventHandler(this.txtLocKhachHang_MouseCaptureChanged);
            // 
            // frmNhapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 866);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLocKH);
            this.Controls.Add(this.lbTxtNhapDuLieuTimKiem);
            this.Controls.Add(this.txtLocKhachHang);
            this.Controls.Add(this.dgvKhachHang);
            this.Controls.Add(this.btnTaoDonHang);
            this.Controls.Add(this.btnXoaSpGioHang);
            this.Controls.Add(this.lbGioHang);
            this.Controls.Add(this.btnThemVaoGioHang);
            this.Controls.Add(this.lbLocTheo);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.lbMaKhachHangNHD);
            this.Controls.Add(this.txtMaKhachHangNHD);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbMaHoaDon);
            this.Controls.Add(this.txtIdChiTietHoaDon);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtNDHsdt);
            this.Controls.Add(this.lbTenKhachHangNHD);
            this.Controls.Add(this.txtNDHTenKhachHang);
            this.Controls.Add(this.dgvDienThoai);
            this.Name = "frmNhapHoaDon";
            this.Text = "frmNhapHoaDon";
            this.Load += new System.EventHandler(this.frmNhapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.TextBox txtIdChiTietHoaDon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNDHsdt;
        private System.Windows.Forms.Label lbTenKhachHangNHD;
        private System.Windows.Forms.TextBox txtNDHTenKhachHang;
        private System.Windows.Forms.Label lbMaKhachHangNHD;
        private System.Windows.Forms.TextBox txtMaKhachHangNHD;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label lbLocTheo;
        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Button btnThemVaoGioHang;
        private System.Windows.Forms.Label lbGioHang;
        private System.Windows.Forms.Button btnXoaSpGioHang;
        private System.Windows.Forms.Button btnTaoDonHang;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLocKH;
        private System.Windows.Forms.Label lbTxtNhapDuLieuTimKiem;
        private System.Windows.Forms.TextBox txtLocKhachHang;
    }
}