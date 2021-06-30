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
    public partial class fLapHoaDonThanhToan : Form
    {
        public fLapHoaDonThanhToan()
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

            List<HS_KHAM_BENHDTO> hs_KHAM_BENHDTO = new List<HS_KHAM_BENHDTO>();
            String Ma_HS = cbbHoTen.SelectedValue.ToString();
            hs_KHAM_BENHDTO = hs_KHAM_BENHBUS.TimBenhNhanTheoMa_HS(Ma_HS);

            HOA_DONBUS hoa_DONBUS = new HOA_DONBUS();
            List<HOA_DONDTO> hoa_DONDTO = new List<HOA_DONDTO>();
            hoa_DONDTO = hoa_DONBUS.LayTienKhamTienThuoc(Ma_HS);

            tbNgayKham.Text = hs_KHAM_BENHDTO[0].Ngay_Kham1.ToString();
            tbTienThuoc.Text = hoa_DONDTO[0].Tien_Kham1.ToString();
            tbTien_Kham.Text = hoa_DONDTO[0].Tien_Thuoc1.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HS_KHAM_BENHBUS hs_KHAM_BENHBUS = new HS_KHAM_BENHBUS();
            List<HS_KHAM_BENHDTO> hs_KHAM_BENHDTO = new List<HS_KHAM_BENHDTO>();
            String Ma_HS = cbbHoTen.SelectedValue.ToString();
            hs_KHAM_BENHDTO = hs_KHAM_BENHBUS.TimBenhNhanTheoMa_HS(Ma_HS);

            HOA_DONBUS hoa_DONBUS = new HOA_DONBUS();
            List<HOA_DONDTO> hoa_DONDTO = new List<HOA_DONDTO>();
            hoa_DONDTO = hoa_DONBUS.LayTienKhamTienThuoc(Ma_HS);

            tbNgayKham.Text = hs_KHAM_BENHDTO[0].Ngay_Kham1.ToString();
            tbTienThuoc.Text = hoa_DONDTO[0].Tien_Kham1.ToString();
            tbTien_Kham.Text = hoa_DONDTO[0].Tien_Thuoc1.ToString();
        }

        private void cbbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
