using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;


namespace QuanLyPhongMach
{
    public partial class fLapPhieuKhamBenh : Form
    {
        public fLapPhieuKhamBenh()
        {
            InitializeComponent();
            LoadComboboxHoTen();
        }

        public void LoadComboboxHoTen()
        {
            HS_KHAM_BENHBUS hs_KHAM_BENHBUS = new HS_KHAM_BENHBUS();
            cbbHoTen.DataSource = hs_KHAM_BENHBUS.LayDanhSachBenhNhan();
            cbbHoTen.DisplayMember = "Ho_Ten1";
            cbbHoTen.ValueMember = "Ma_HS1";
        }

        private void cbbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            //láy mã HS
            HS_KHAM_BENHBUS hs_KHAM_BENHBUS = new HS_KHAM_BENHBUS();
            List<HS_KHAM_BENHDTO> hs_KHAM_BENHDTO = new List<HS_KHAM_BENHDTO>();
            hs_KHAM_BENHDTO = hs_KHAM_BENHBUS.TimBenhNhanTheoMa_HS(cbbHoTen.SelectedValue.ToString());

            CHI_TIET_TOA_THUOCBUS chi_TIET_TOA_THUOCBUS = new CHI_TIET_TOA_THUOCBUS();
            DataTable toaThuoc = chi_TIET_TOA_THUOCBUS.LayToaThuoc(hs_KHAM_BENHDTO[0].Ma_HS1);
            


            tbTrieu_Chung.Text = hs_KHAM_BENHDTO[0].Trieu_Chung1.ToString();
            tbDuDoanLoaiBenh.Text = hs_KHAM_BENHDTO[0].Du_Doan_Loai_Benh1;
            tbNgayKham.Text = hs_KHAM_BENHDTO[0].Ngay_Kham1;
            dgvLapDanhSachKhamBenh.DataSource = toaThuoc;
        }
    }
}
