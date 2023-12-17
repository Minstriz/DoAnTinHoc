namespace QuanLyCHDT
{
    partial class frmLoc
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
            this.cbLoc = new System.Windows.Forms.ComboBox();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.lbLocTheo = new System.Windows.Forms.Label();
            this.dgvDienThoaiLoc = new System.Windows.Forms.DataGridView();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoaiLoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.cbLoc.Location = new System.Drawing.Point(128, 96);
            this.cbLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(164, 24);
            this.cbLoc.TabIndex = 172;
            this.cbLoc.SelectedIndexChanged += new System.EventHandler(this.cbLoc_SelectedIndexChanged);
            this.cbLoc.SelectedValueChanged += new System.EventHandler(this.Sort);
            this.cbLoc.TextChanged += new System.EventHandler(this.Sort);
            // 
            // txtLoc
            // 
            this.txtLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoc.ForeColor = System.Drawing.Color.Black;
            this.txtLoc.Location = new System.Drawing.Point(310, 96);
            this.txtLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoc.Multiline = true;
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(455, 24);
            this.txtLoc.TabIndex = 171;
            this.txtLoc.Tag = "Nhập dữ liệu tìm kiếm";
            this.txtLoc.TextChanged += new System.EventHandler(this.Sort);
            // 
            // lbLocTheo
            // 
            this.lbLocTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocTheo.Location = new System.Drawing.Point(41, 97);
            this.lbLocTheo.Name = "lbLocTheo";
            this.lbLocTheo.Size = new System.Drawing.Size(81, 23);
            this.lbLocTheo.TabIndex = 173;
            this.lbLocTheo.Text = "Lọc theo";
            // 
            // dgvDienThoaiLoc
            // 
            this.dgvDienThoaiLoc.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgvDienThoaiLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDienThoaiLoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvDienThoaiLoc.Location = new System.Drawing.Point(12, 199);
            this.dgvDienThoaiLoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDienThoaiLoc.Name = "dgvDienThoaiLoc";
            this.dgvDienThoaiLoc.RowHeadersWidth = 51;
            this.dgvDienThoaiLoc.RowTemplate.Height = 24;
            this.dgvDienThoaiLoc.Size = new System.Drawing.Size(799, 400);
            this.dgvDienThoaiLoc.TabIndex = 174;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 73);
            this.panel1.TabIndex = 197;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(326, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lọc sản phẩm";
            // 
            // frmLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbLocTheo);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.dgvDienThoaiLoc);
            this.Controls.Add(this.txtLoc);
            this.Name = "frmLoc";
            this.Text = "frmLoc";
            this.Load += new System.EventHandler(this.frmLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDienThoaiLoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoc;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label lbLocTheo;
        private System.Windows.Forms.DataGridView dgvDienThoaiLoc;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}