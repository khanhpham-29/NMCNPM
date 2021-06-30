
namespace QuanLyPhongMach
{
    partial class fTraCuuBenhNhan
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvTraCuuBenhNhan = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btTraCuu = new System.Windows.Forms.Button();
            this.cbbHoTen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHo_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay_Kham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai_Benh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrieu_Chung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuBenhNhan)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTraCuuBenhNhan);
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 375);
            this.panel3.TabIndex = 2;
            // 
            // dgvTraCuuBenhNhan
            // 
            this.dgvTraCuuBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuuBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colHo_Ten,
            this.colNgay_Kham,
            this.colLoai_Benh,
            this.colTrieu_Chung});
            this.dgvTraCuuBenhNhan.Location = new System.Drawing.Point(3, 3);
            this.dgvTraCuuBenhNhan.Name = "dgvTraCuuBenhNhan";
            this.dgvTraCuuBenhNhan.RowTemplate.Height = 25;
            this.dgvTraCuuBenhNhan.Size = new System.Drawing.Size(622, 372);
            this.dgvTraCuuBenhNhan.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btTraCuu);
            this.panel2.Controls.Add(this.cbbHoTen);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 39);
            this.panel2.TabIndex = 1;
            // 
            // btTraCuu
            // 
            this.btTraCuu.Location = new System.Drawing.Point(341, 6);
            this.btTraCuu.Name = "btTraCuu";
            this.btTraCuu.Size = new System.Drawing.Size(117, 24);
            this.btTraCuu.TabIndex = 2;
            this.btTraCuu.Text = "TraCuuBenhNhan";
            this.btTraCuu.UseVisualStyleBackColor = true;
            this.btTraCuu.Click += new System.EventHandler(this.btTraCuu_Click);
            // 
            // cbbHoTen
            // 
            this.cbbHoTen.FormattingEnabled = true;
            this.cbbHoTen.Location = new System.Drawing.Point(91, 7);
            this.cbbHoTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbHoTen.Name = "cbbHoTen";
            this.cbbHoTen.Size = new System.Drawing.Size(227, 23);
            this.cbbHoTen.TabIndex = 1;
            this.cbbHoTen.SelectedIndexChanged += new System.EventHandler(this.cbHoTen_SelectedIndexChanged);
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
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT1";
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // colHo_Ten
            // 
            this.colHo_Ten.DataPropertyName = "Ho_Ten1";
            this.colHo_Ten.HeaderText = "Họ và tên";
            this.colHo_Ten.Name = "colHo_Ten";
            // 
            // colNgay_Kham
            // 
            this.colNgay_Kham.DataPropertyName = "Ngay_Kham1";
            this.colNgay_Kham.HeaderText = "Ngày Khám";
            this.colNgay_Kham.Name = "colNgay_Kham";
            // 
            // colLoai_Benh
            // 
            this.colLoai_Benh.DataPropertyName = "Du_Doan_Loai_Benh1";
            this.colLoai_Benh.HeaderText = "Loại Bệnh";
            this.colLoai_Benh.Name = "colLoai_Benh";
            this.colLoai_Benh.Width = 150;
            // 
            // colTrieu_Chung
            // 
            this.colTrieu_Chung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrieu_Chung.DataPropertyName = "Trieu_Chung1";
            this.colTrieu_Chung.HeaderText = "Triệu chứng";
            this.colTrieu_Chung.Name = "colTrieu_Chung";
            // 
            // fTraCuuBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 450);
            this.Controls.Add(this.panel1);
            this.Name = "fTraCuuBenhNhan";
            this.Text = "fTraCuuBenhNhan";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuuBenhNhan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTraCuu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTraCuuBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHo_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay_Kham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai_Benh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrieu_Chung;
    }
}