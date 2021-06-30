
namespace QuanLyPhongMach
{
    partial class fMain
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
            this.btPhieuKhamBenh = new System.Windows.Forms.Button();
            this.btTraCuuBenhNhan = new System.Windows.Forms.Button();
            this.btLapBaoCaoThang = new System.Windows.Forms.Button();
            this.btLapHoaDonThanhToan = new System.Windows.Forms.Button();
            this.btDanhSachKhamBenh = new System.Windows.Forms.Button();
            this.btThayDoiQuyDinh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btThayDoiQuyDinh);
            this.panel1.Controls.Add(this.btPhieuKhamBenh);
            this.panel1.Controls.Add(this.btTraCuuBenhNhan);
            this.panel1.Controls.Add(this.btLapBaoCaoThang);
            this.panel1.Controls.Add(this.btLapHoaDonThanhToan);
            this.panel1.Controls.Add(this.btDanhSachKhamBenh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 195);
            this.panel1.TabIndex = 0;
            // 
            // btPhieuKhamBenh
            // 
            this.btPhieuKhamBenh.Location = new System.Drawing.Point(162, 3);
            this.btPhieuKhamBenh.Name = "btPhieuKhamBenh";
            this.btPhieuKhamBenh.Size = new System.Drawing.Size(153, 88);
            this.btPhieuKhamBenh.TabIndex = 4;
            this.btPhieuKhamBenh.Text = "Lập phiếu khám bệnh";
            this.btPhieuKhamBenh.UseVisualStyleBackColor = true;
            this.btPhieuKhamBenh.Click += new System.EventHandler(this.btPhieuKhamBenh_Click);
            // 
            // btTraCuuBenhNhan
            // 
            this.btTraCuuBenhNhan.Location = new System.Drawing.Point(321, 3);
            this.btTraCuuBenhNhan.Name = "btTraCuuBenhNhan";
            this.btTraCuuBenhNhan.Size = new System.Drawing.Size(153, 88);
            this.btTraCuuBenhNhan.TabIndex = 3;
            this.btTraCuuBenhNhan.Text = "Tra cứu bệnh nhân";
            this.btTraCuuBenhNhan.UseVisualStyleBackColor = true;
            this.btTraCuuBenhNhan.Click += new System.EventHandler(this.btTraCuuBenhNhan_Click);
            // 
            // btLapBaoCaoThang
            // 
            this.btLapBaoCaoThang.Location = new System.Drawing.Point(162, 97);
            this.btLapBaoCaoThang.Name = "btLapBaoCaoThang";
            this.btLapBaoCaoThang.Size = new System.Drawing.Size(153, 88);
            this.btLapBaoCaoThang.TabIndex = 2;
            this.btLapBaoCaoThang.Text = "Lập báo cáo tháng";
            this.btLapBaoCaoThang.UseVisualStyleBackColor = true;
            this.btLapBaoCaoThang.Click += new System.EventHandler(this.btLapBaoCaoThang_Click);
            // 
            // btLapHoaDonThanhToan
            // 
            this.btLapHoaDonThanhToan.Location = new System.Drawing.Point(3, 97);
            this.btLapHoaDonThanhToan.Name = "btLapHoaDonThanhToan";
            this.btLapHoaDonThanhToan.Size = new System.Drawing.Size(153, 88);
            this.btLapHoaDonThanhToan.TabIndex = 1;
            this.btLapHoaDonThanhToan.Text = "Lập Hóa Đơn Thanh Toán";
            this.btLapHoaDonThanhToan.UseVisualStyleBackColor = true;
            this.btLapHoaDonThanhToan.Click += new System.EventHandler(this.btLapHoaDonThanhToan_Click);
            // 
            // btDanhSachKhamBenh
            // 
            this.btDanhSachKhamBenh.Location = new System.Drawing.Point(3, 3);
            this.btDanhSachKhamBenh.Name = "btDanhSachKhamBenh";
            this.btDanhSachKhamBenh.Size = new System.Drawing.Size(153, 88);
            this.btDanhSachKhamBenh.TabIndex = 0;
            this.btDanhSachKhamBenh.Text = "Danh sách khám bệnh";
            this.btDanhSachKhamBenh.UseVisualStyleBackColor = true;
            this.btDanhSachKhamBenh.Click += new System.EventHandler(this.btDanhSachKhamBenh_Click);
            // 
            // btThayDoiQuyDinh
            // 
            this.btThayDoiQuyDinh.Location = new System.Drawing.Point(321, 97);
            this.btThayDoiQuyDinh.Name = "btThayDoiQuyDinh";
            this.btThayDoiQuyDinh.Size = new System.Drawing.Size(153, 88);
            this.btThayDoiQuyDinh.TabIndex = 5;
            this.btThayDoiQuyDinh.Text = "Thay đổi quy định";
            this.btThayDoiQuyDinh.UseVisualStyleBackColor = true;
            this.btThayDoiQuyDinh.Click += new System.EventHandler(this.btThayDoiQuyDinh_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 219);
            this.Controls.Add(this.panel1);
            this.Name = "fMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btDanhSachKhamBenh;
        private System.Windows.Forms.Button btPhieuKhamBenh;
        private System.Windows.Forms.Button btTraCuuBenhNhan;
        private System.Windows.Forms.Button btLapBaoCaoThang;
        private System.Windows.Forms.Button btLapHoaDonThanhToan;
        private System.Windows.Forms.Button btThayDoiQuyDinh;
    }
}

