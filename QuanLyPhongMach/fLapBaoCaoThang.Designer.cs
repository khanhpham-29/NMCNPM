
namespace QuanLyPhongMach
{
    partial class fLapBaoCaoThang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDoangThuTheoNgay = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTyLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btLapBC = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.btNam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.bTThang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSuDungThuoc = new System.Windows.Forms.DataGridView();
            this.colSTTThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbNamThuoc = new System.Windows.Forms.ComboBox();
            this.btNamThuoc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbThangThuoc = new System.Windows.Forms.ComboBox();
            this.btThangThuoc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoangThuTheoNgay)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDungThuoc)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDoangThuTheoNgay);
            this.groupBox1.Controls.Add(this.btLapBC);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo Cáo Doanh Thu Theo Ngày";
            // 
            // dgvDoangThuTheoNgay
            // 
            this.dgvDoangThuTheoNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoangThuTheoNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.col,
            this.colSoBenhNhan,
            this.colDoanhThu,
            this.colTyLe});
            this.dgvDoangThuTheoNgay.Location = new System.Drawing.Point(6, 66);
            this.dgvDoangThuTheoNgay.Name = "dgvDoangThuTheoNgay";
            this.dgvDoangThuTheoNgay.RowTemplate.Height = 25;
            this.dgvDoangThuTheoNgay.Size = new System.Drawing.Size(480, 372);
            this.dgvDoangThuTheoNgay.TabIndex = 4;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 50;
            // 
            // col
            // 
            this.col.HeaderText = "Ngày";
            this.col.Name = "col";
            // 
            // colSoBenhNhan
            // 
            this.colSoBenhNhan.HeaderText = "Số Bệnh Nhân";
            this.colSoBenhNhan.Name = "colSoBenhNhan";
            this.colSoBenhNhan.Width = 110;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.HeaderText = "Doanh thu";
            this.colDoanhThu.Name = "colDoanhThu";
            // 
            // colTyLe
            // 
            this.colTyLe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTyLe.HeaderText = "Tỷ lệ";
            this.colTyLe.Name = "colTyLe";
            // 
            // btLapBC
            // 
            this.btLapBC.Location = new System.Drawing.Point(388, 30);
            this.btLapBC.Name = "btLapBC";
            this.btLapBC.Size = new System.Drawing.Size(98, 23);
            this.btLapBC.TabIndex = 3;
            this.btLapBC.Text = "Lập báo cáo";
            this.btLapBC.UseVisualStyleBackColor = true;
            this.btLapBC.Click += new System.EventHandler(this.btLapBC_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbNam);
            this.panel2.Controls.Add(this.btNam);
            this.panel2.Location = new System.Drawing.Point(197, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 38);
            this.panel2.TabIndex = 2;
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(84, 9);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(98, 23);
            this.cbbNam.TabIndex = 1;
            // 
            // btNam
            // 
            this.btNam.Location = new System.Drawing.Point(3, 9);
            this.btNam.Name = "btNam";
            this.btNam.Size = new System.Drawing.Size(75, 23);
            this.btNam.TabIndex = 0;
            this.btNam.Text = "Năm";
            this.btNam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbThang);
            this.panel1.Controls.Add(this.bTThang);
            this.panel1.Location = new System.Drawing.Point(6, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 38);
            this.panel1.TabIndex = 0;
            // 
            // cbbThang
            // 
            this.cbbThang.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(84, 9);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(98, 23);
            this.cbbThang.TabIndex = 1;
            // 
            // bTThang
            // 
            this.bTThang.Location = new System.Drawing.Point(3, 9);
            this.bTThang.Name = "bTThang";
            this.bTThang.Size = new System.Drawing.Size(75, 23);
            this.bTThang.TabIndex = 0;
            this.bTThang.Text = "Tháng";
            this.bTThang.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSuDungThuoc);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(510, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 448);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Báo Cáo Sử dụng Thuốc";
            // 
            // dgvSuDungThuoc
            // 
            this.dgvSuDungThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuDungThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTTThuoc,
            this.colThuoc,
            this.colDonViTinh,
            this.colSoLuong,
            this.colSoLanDung});
            this.dgvSuDungThuoc.Location = new System.Drawing.Point(12, 66);
            this.dgvSuDungThuoc.Name = "dgvSuDungThuoc";
            this.dgvSuDungThuoc.RowTemplate.Height = 25;
            this.dgvSuDungThuoc.Size = new System.Drawing.Size(474, 372);
            this.dgvSuDungThuoc.TabIndex = 5;
            // 
            // colSTTThuoc
            // 
            this.colSTTThuoc.HeaderText = "STT";
            this.colSTTThuoc.Name = "colSTTThuoc";
            this.colSTTThuoc.Width = 50;
            // 
            // colThuoc
            // 
            this.colThuoc.HeaderText = "Thuốc";
            this.colThuoc.Name = "colThuoc";
            this.colThuoc.Width = 80;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.HeaderText = "Đơn Vị Tính";
            this.colDonViTinh.Name = "colDonViTinh";
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 90;
            // 
            // colSoLanDung
            // 
            this.colSoLanDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSoLanDung.HeaderText = "Số lần dung";
            this.colSoLanDung.Name = "colSoLanDung";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Lập báo cáo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbNamThuoc);
            this.panel4.Controls.Add(this.btNamThuoc);
            this.panel4.Location = new System.Drawing.Point(200, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(185, 38);
            this.panel4.TabIndex = 3;
            // 
            // cbbNamThuoc
            // 
            this.cbbNamThuoc.FormattingEnabled = true;
            this.cbbNamThuoc.Location = new System.Drawing.Point(84, 9);
            this.cbbNamThuoc.Name = "cbbNamThuoc";
            this.cbbNamThuoc.Size = new System.Drawing.Size(98, 23);
            this.cbbNamThuoc.TabIndex = 1;
            // 
            // btNamThuoc
            // 
            this.btNamThuoc.Location = new System.Drawing.Point(3, 9);
            this.btNamThuoc.Name = "btNamThuoc";
            this.btNamThuoc.Size = new System.Drawing.Size(75, 23);
            this.btNamThuoc.TabIndex = 0;
            this.btNamThuoc.Text = "Năm";
            this.btNamThuoc.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbThangThuoc);
            this.panel3.Controls.Add(this.btThangThuoc);
            this.panel3.Location = new System.Drawing.Point(9, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 38);
            this.panel3.TabIndex = 1;
            // 
            // cbbThangThuoc
            // 
            this.cbbThangThuoc.FormattingEnabled = true;
            this.cbbThangThuoc.Location = new System.Drawing.Point(84, 9);
            this.cbbThangThuoc.Name = "cbbThangThuoc";
            this.cbbThangThuoc.Size = new System.Drawing.Size(98, 23);
            this.cbbThangThuoc.TabIndex = 1;
            // 
            // btThangThuoc
            // 
            this.btThangThuoc.Location = new System.Drawing.Point(3, 9);
            this.btThangThuoc.Name = "btThangThuoc";
            this.btThangThuoc.Size = new System.Drawing.Size(75, 23);
            this.btThangThuoc.TabIndex = 0;
            this.btThangThuoc.Text = "Tháng";
            this.btThangThuoc.UseVisualStyleBackColor = true;
            // 
            // fLapBaoCaoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fLapBaoCaoThang";
            this.Text = "fLapBaoCaoThang";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoangThuTheoNgay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuDungThuoc)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Button btNam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Button bTThang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDoangThuTheoNgay;
        private System.Windows.Forms.Button btLapBC;
        private System.Windows.Forms.DataGridView dgvSuDungThuoc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbNamThuoc;
        private System.Windows.Forms.Button btNamThuoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbThangThuoc;
        private System.Windows.Forms.Button btThangThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTyLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTTThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLanDung;
    }
}