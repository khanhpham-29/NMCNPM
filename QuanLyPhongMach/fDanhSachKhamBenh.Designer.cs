
namespace QuanLyPhongMach
{
    partial class fDanhSachKhamBenh
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
            this.dgvDanhSachKhamBenh = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa_HS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHo_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNam_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btXemTruocDanhSach = new System.Windows.Forms.Button();
            this.btLapDanhSachKhamBenh = new System.Windows.Forms.Button();
            this.dtpDanhSachKhamBenh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btXemDanhSachCu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhamBenh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachKhamBenh
            // 
            this.dgvDanhSachKhamBenh.AllowUserToOrderColumns = true;
            this.dgvDanhSachKhamBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhamBenh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMa_HS,
            this.colHo_Ten,
            this.colGioi_Tinh,
            this.colNam_Sinh,
            this.colDia_Chi});
            this.dgvDanhSachKhamBenh.Location = new System.Drawing.Point(4, 3);
            this.dgvDanhSachKhamBenh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDanhSachKhamBenh.Name = "dgvDanhSachKhamBenh";
            this.dgvDanhSachKhamBenh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDanhSachKhamBenh.Size = new System.Drawing.Size(738, 431);
            this.dgvDanhSachKhamBenh.TabIndex = 4;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT1";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 50;
            // 
            // colMa_HS
            // 
            this.colMa_HS.DataPropertyName = "Ma_HS1";
            this.colMa_HS.HeaderText = "Mã HS";
            this.colMa_HS.Name = "colMa_HS";
            // 
            // colHo_Ten
            // 
            this.colHo_Ten.DataPropertyName = "Ho_Ten1";
            this.colHo_Ten.HeaderText = "Họ và tên";
            this.colHo_Ten.Name = "colHo_Ten";
            this.colHo_Ten.Width = 150;
            // 
            // colGioi_Tinh
            // 
            this.colGioi_Tinh.DataPropertyName = "Gioi_Tinh1";
            this.colGioi_Tinh.HeaderText = "Giới Tính";
            this.colGioi_Tinh.Name = "colGioi_Tinh";
            // 
            // colNam_Sinh
            // 
            this.colNam_Sinh.DataPropertyName = "Nam_Sinh1";
            this.colNam_Sinh.HeaderText = "Năm Sinh";
            this.colNam_Sinh.Name = "colNam_Sinh";
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDia_Chi.DataPropertyName = "Dia_Chi1";
            this.colDia_Chi.HeaderText = "Địa chỉ";
            this.colDia_Chi.Name = "colDia_Chi";
            this.colDia_Chi.Width = 195;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 493);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDanhSachKhamBenh);
            this.panel3.Location = new System.Drawing.Point(4, 59);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(742, 434);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btXemDanhSachCu);
            this.panel2.Controls.Add(this.btXemTruocDanhSach);
            this.panel2.Controls.Add(this.btLapDanhSachKhamBenh);
            this.panel2.Controls.Add(this.dtpDanhSachKhamBenh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 53);
            this.panel2.TabIndex = 0;
            // 
            // btXemTruocDanhSach
            // 
            this.btXemTruocDanhSach.Location = new System.Drawing.Point(436, 10);
            this.btXemTruocDanhSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btXemTruocDanhSach.Name = "btXemTruocDanhSach";
            this.btXemTruocDanhSach.Size = new System.Drawing.Size(144, 27);
            this.btXemTruocDanhSach.TabIndex = 3;
            this.btXemTruocDanhSach.Text = "Xem trước danh sách";
            this.btXemTruocDanhSach.UseVisualStyleBackColor = true;
            this.btXemTruocDanhSach.Click += new System.EventHandler(this.btXemTruocDanhSach_Click);
            // 
            // btLapDanhSachKhamBenh
            // 
            this.btLapDanhSachKhamBenh.Location = new System.Drawing.Point(588, 10);
            this.btLapDanhSachKhamBenh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btLapDanhSachKhamBenh.Name = "btLapDanhSachKhamBenh";
            this.btLapDanhSachKhamBenh.Size = new System.Drawing.Size(150, 27);
            this.btLapDanhSachKhamBenh.TabIndex = 2;
            this.btLapDanhSachKhamBenh.Text = "Lập DS Khám bệnh";
            this.btLapDanhSachKhamBenh.UseVisualStyleBackColor = true;
            this.btLapDanhSachKhamBenh.Click += new System.EventHandler(this.btLapDanhSachKhamBenh_Click);
            // 
            // dtpDanhSachKhamBenh
            // 
            this.dtpDanhSachKhamBenh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDanhSachKhamBenh.Location = new System.Drawing.Point(131, 10);
            this.dtpDanhSachKhamBenh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDanhSachKhamBenh.Name = "dtpDanhSachKhamBenh";
            this.dtpDanhSachKhamBenh.Size = new System.Drawing.Size(107, 23);
            this.dtpDanhSachKhamBenh.TabIndex = 1;
            this.dtpDanhSachKhamBenh.ValueChanged += new System.EventHandler(this.dtpDanhSachKhamBenh_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày khám bệnh";
            // 
            // btXemDanhSachCu
            // 
            this.btXemDanhSachCu.Location = new System.Drawing.Point(283, 10);
            this.btXemDanhSachCu.Name = "btXemDanhSachCu";
            this.btXemDanhSachCu.Size = new System.Drawing.Size(146, 27);
            this.btXemDanhSachCu.TabIndex = 4;
            this.btXemDanhSachCu.Text = "Xem danh sách cũ";
            this.btXemDanhSachCu.UseVisualStyleBackColor = true;
            this.btXemDanhSachCu.Click += new System.EventHandler(this.btXemDanhSachCu_Click);
            // 
            // fDanhSachKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 512);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fDanhSachKhamBenh";
            this.Text = "Danh sách khám bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhamBenh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpDanhSachKhamBenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btLapDanhSachKhamBenh;
        private System.Windows.Forms.DataGridView dgvDanhSachKhamBenh;
        private System.Windows.Forms.Button btXemTruocDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa_HS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHo_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioi_Tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNam_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia_Chi;
        private System.Windows.Forms.Button btXemDanhSachCu;
    }
}