﻿namespace QuanLyCHDT
{
    partial class frmChiTietHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tongtien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tinhtrang = new System.Windows.Forms.Label();
            this.makh = new System.Windows.Forms.Label();
            this.ngaylap = new System.Windows.Forms.Label();
            this.dgv_dsMua = new System.Windows.Forms.DataGridView();
            this.Col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mahd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsMua)).BeginInit();
            this.SuspendLayout();
            // 
            // tongtien
            // 
            this.tongtien.AutoSize = true;
            this.tongtien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtien.Location = new System.Drawing.Point(404, 495);
            this.tongtien.Name = "tongtien";
            this.tongtien.Size = new System.Drawing.Size(79, 23);
            this.tongtien.TabIndex = 45;
            this.tongtien.Text = "tongtien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tổng tiền: ";
            // 
            // tinhtrang
            // 
            this.tinhtrang.AutoSize = true;
            this.tinhtrang.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhtrang.ForeColor = System.Drawing.Color.DarkRed;
            this.tinhtrang.Location = new System.Drawing.Point(291, 561);
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Size = new System.Drawing.Size(111, 27);
            this.tinhtrang.TabIndex = 43;
            this.tinhtrang.Text = "Tình trạng";
            // 
            // makh
            // 
            this.makh.AutoSize = true;
            this.makh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makh.Location = new System.Drawing.Point(180, 153);
            this.makh.Name = "makh";
            this.makh.Size = new System.Drawing.Size(75, 22);
            this.makh.TabIndex = 42;
            this.makh.Text = "Mã KH:";
            // 
            // ngaylap
            // 
            this.ngaylap.AutoSize = true;
            this.ngaylap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaylap.Location = new System.Drawing.Point(180, 114);
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.Size = new System.Drawing.Size(92, 22);
            this.ngaylap.TabIndex = 41;
            this.ngaylap.Text = "Ngày lập: ";
            // 
            // dgv_dsMua
            // 
            this.dgv_dsMua.AllowUserToAddRows = false;
            this.dgv_dsMua.AllowUserToDeleteRows = false;
            this.dgv_dsMua.AllowUserToResizeColumns = false;
            this.dgv_dsMua.AllowUserToResizeRows = false;
            this.dgv_dsMua.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dsMua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dsMua.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_dsMua.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dsMua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_dsMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsMua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_STT,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dsMua.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_dsMua.Enabled = false;
            this.dgv_dsMua.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_dsMua.Location = new System.Drawing.Point(7, 205);
            this.dgv_dsMua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_dsMua.Name = "dgv_dsMua";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dsMua.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_dsMua.RowHeadersVisible = false;
            this.dgv_dsMua.RowHeadersWidth = 62;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_dsMua.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_dsMua.RowTemplate.Height = 28;
            this.dgv_dsMua.ShowCellToolTips = false;
            this.dgv_dsMua.ShowEditingIcon = false;
            this.dgv_dsMua.Size = new System.Drawing.Size(508, 282);
            this.dgv_dsMua.TabIndex = 40;
            this.dgv_dsMua.TabStop = false;
            // 
            // Col_STT
            // 
            this.Col_STT.HeaderText = "STT";
            this.Col_STT.MinimumWidth = 8;
            this.Col_STT.Name = "Col_STT";
            this.Col_STT.Width = 40;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TenSanPham";
            this.Column12.HeaderText = "Tên";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.Width = 115;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Gia";
            this.Column13.HeaderText = "Giá";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.Width = 80;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "SoLuong";
            this.Column14.HeaderText = "SL";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.Width = 40;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ThanhTien";
            this.Column1.HeaderText = "Thành tiền";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mã KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 35);
            this.label3.TabIndex = 38;
            this.label3.Text = "Hóa đơn bán hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ngày lập: ";
            // 
            // mahd
            // 
            this.mahd.AutoSize = true;
            this.mahd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahd.Location = new System.Drawing.Point(438, 22);
            this.mahd.Name = "mahd";
            this.mahd.Size = new System.Drawing.Size(45, 19);
            this.mahd.TabIndex = 47;
            this.mahd.Text = "mahd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã HĐ:";
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 634);
            this.Controls.Add(this.mahd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tinhtrang);
            this.Controls.Add(this.makh);
            this.Controls.Add(this.ngaylap);
            this.Controls.Add(this.dgv_dsMua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmChiTietHoaDon";
            this.Text = "frmChiTietHoaDon";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsMua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tinhtrang;
        private System.Windows.Forms.Label makh;
        private System.Windows.Forms.Label ngaylap;
        private System.Windows.Forms.DataGridView dgv_dsMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mahd;
        private System.Windows.Forms.Label label1;
    }
}