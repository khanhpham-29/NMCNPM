using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using BUS;

namespace QuanLyPhongMach
{
    public partial class fTraCuuBenhNhan : Form
    {
        public fTraCuuBenhNhan()
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
            dgvTraCuuBenhNhan.AutoGenerateColumns = false;


        }

        private void cbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            HS_KHAM_BENHBUS hs_KHAM_BENHBUS = new HS_KHAM_BENHBUS();
            String ho_Ten = cbbHoTen.Text;

            dgvTraCuuBenhNhan.DataSource = hs_KHAM_BENHBUS.TimBenhNhan(ho_Ten);
        }
    }
}
