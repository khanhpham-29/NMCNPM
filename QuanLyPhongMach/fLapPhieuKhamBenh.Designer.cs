
namespace QuanLyPhongMach
{
    partial class fLapPhieuKhamBenh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbNgayKham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btLapPhieuKhamBenh = new System.Windows.Forms.Button();
            this.dgvLapDanhSachKhamBenh = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbDuDoanLoaiBenh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbTrieu_Chung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbHoTen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDon_Vi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSo_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCach_Dung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapDanhSachKhamBenh)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXem);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btLapPhieuKhamBenh);
            this.panel1.Controls.Add(this.dgvLapDanhSachKhamBenh);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 356);
            this.panel1.TabIndex = 0;
            // 
            // btXem
            // 
            this.btXem.Location = new System.Drawing.Point(265, 313);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(132, 38);
            this.btXem.TabIndex = 5;
            this.btXem.Text = "Xem Trước";
            this.btXem.UseVisualStyleBackColor = true;
            this.btXem.Click += new System.EventHandler(this.btXem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbNgayKham);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(247, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 39);
            this.panel4.TabIndex = 2;
            // 
            // tbNgayKham
            // 
            this.tbNgayKham.Location = new System.Drawing.Point(121, 7);
            this.tbNgayKham.Name = "tbNgayKham";
            this.tbNgayKham.Size = new System.Drawing.Size(147, 23);
            this.tbNgayKham.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày khám";
            // 
            // btLapPhieuKhamBenh
            // 
            this.btLapPhieuKhamBenh.Location = new System.Drawing.Point(403, 313);
            this.btLapPhieuKhamBenh.Name = "btLapPhieuKhamBenh";
            this.btLapPhieuKhamBenh.Size = new System.Drawing.Size(116, 38);
            this.btLapPhieuKhamBenh.TabIndex = 4;
            this.btLapPhieuKhamBenh.Text = "Lập Phiếu Khám Bệnh";
            this.btLapPhieuKhamBenh.UseVisualStyleBackColor = true;
            // 
            // dgvLapDanhSachKhamBenh
            // 
            this.dgvLapDanhSachKhamBenh.AllowUserToAddRows = false;
            this.dgvLapDanhSachKhamBenh.AllowUserToDeleteRows = false;
            this.dgvLapDanhSachKhamBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLapDanhSachKhamBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTHUOC,
            this.colDon_Vi,
            this.colSo_Luong,
            this.colCach_Dung});
            this.dgvLapDanhSachKhamBenh.Location = new System.Drawing.Point(4, 95);
            this.dgvLapDanhSachKhamBenh.Name = "dgvLapDanhSachKhamBenh";
            this.dgvLapDanhSachKhamBenh.ReadOnly = true;
            this.dgvLapDanhSachKhamBenh.RowTemplate.Height = 25;
            this.dgvLapDanhSachKhamBenh.Size = new System.Drawing.Size(515, 212);
            this.dgvLapDanhSachKhamBenh.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbDuDoanLoaiBenh);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(247, 50);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 39);
            this.panel5.TabIndex = 2;
            // 
            // tbDuDoanLoaiBenh
            // 
            this.tbDuDoanLoaiBenh.Location = new System.Drawing.Point(121, 10);
            this.tbDuDoanLoaiBenh.Name = "tbDuDoanLoaiBenh";
            this.tbDuDoanLoaiBenh.Size = new System.Drawing.Size(151, 23);
            this.tbDuDoanLoaiBenh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dự đoán loại bệnh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbTrieu_Chung);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(4, 50);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 39);
            this.panel3.TabIndex = 2;
            // 
            // tbTrieu_Chung
            // 
            this.tbTrieu_Chung.Location = new System.Drawing.Point(91, 10);
            this.tbTrieu_Chung.Name = "tbTrieu_Chung";
            this.tbTrieu_Chung.Size = new System.Drawing.Size(144, 23);
            this.tbTrieu_Chung.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Triệu chứng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbHoTen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 39);
            this.panel2.TabIndex = 0;
            // 
            // cbbHoTen
            // 
            this.cbbHoTen.FormattingEnabled = true;
            this.cbbHoTen.Location = new System.Drawing.Point(91, 8);
            this.cbbHoTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbHoTen.Name = "cbbHoTen";
            this.cbbHoTen.Size = new System.Drawing.Size(144, 23);
            this.cbbHoTen.TabIndex = 2;
            this.cbbHoTen.SelectedIndexChanged += new System.EventHandler(this.cbbHoTen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // colTHUOC
            // 
            this.colTHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTHUOC.DataPropertyName = "Ten_Thuoc";
            this.colTHUOC.HeaderText = "Thuốc";
            this.colTHUOC.Name = "colTHUOC";
            this.colTHUOC.ReadOnly = true;
            // 
            // colDon_Vi
            // 
            this.colDon_Vi.DataPropertyName = "Don_Vi";
            this.colDon_Vi.HeaderText = "Đơn Vị";
            this.colDon_Vi.Name = "colDon_Vi";
            this.colDon_Vi.ReadOnly = true;
            // 
            // colSo_Luong
            // 
            this.colSo_Luong.DataPropertyName = "So_Luong";
            this.colSo_Luong.HeaderText = "Số Lượng";
            this.colSo_Luong.Name = "colSo_Luong";
            this.colSo_Luong.ReadOnly = true;
            // 
            // colCach_Dung
            // 
            this.colCach_Dung.DataPropertyName = "Cach_Dung";
            this.colCach_Dung.HeaderText = "Cách dùng";
            this.colCach_Dung.Name = "colCach_Dung";
            this.colCach_Dung.ReadOnly = true;
            // 
            // fLapPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 374);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fLapPhieuKhamBenh";
            this.Text = "fLapPhieuKhamBenh";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapDanhSachKhamBenh)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTrieu_Chung;
        private System.Windows.Forms.DataGridView dgvLapDanhSachKhamBenh;
        private System.Windows.Forms.ComboBox cbbHoTen;
        private System.Windows.Forms.Button btLapPhieuKhamBenh;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.TextBox tbDuDoanLoaiBenh;
        private System.Windows.Forms.TextBox tbNgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDon_Vi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSo_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCach_Dung;
    }
}