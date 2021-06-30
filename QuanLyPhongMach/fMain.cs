using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMach
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            fLapPhieuKhamBenh f = new fLapPhieuKhamBenh();
            f.ShowDialog();
        }

        private void btTraCuuBenhNhan_Click(object sender, EventArgs e)
        {
            fTraCuuBenhNhan f = new fTraCuuBenhNhan();
            f.ShowDialog();
        }

        private void btDanhSachKhamBenh_Click(object sender, EventArgs e)
        {
            fDanhSachKhamBenh f = new fDanhSachKhamBenh();
            f.ShowDialog();
        }

        private void btLapHoaDonThanhToan_Click(object sender, EventArgs e)
        {
            fLapHoaDonThanhToan f = new fLapHoaDonThanhToan();
            f.ShowDialog();
        }

        private void btLapBaoCaoThang_Click(object sender, EventArgs e)
        {
            fLapBaoCaoThang f = new fLapBaoCaoThang();
            f.ShowDialog();
        }

        private void btThayDoiQuyDinh_Click(object sender, EventArgs e)
        {
            fThayDoiQuyDinh f = new fThayDoiQuyDinh();
            f.ShowDialog();
        }
    }
}
