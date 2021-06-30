using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyPhongMach
{
    public partial class fLapBaoCaoThang : Form
    {
        public fLapBaoCaoThang()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            for (int i = 1995; i < 2100; i++)
            {
                cbbNam.Items.Add(i);
                cbbNamThuoc.Items.Add(i);
            }

            for (int i = 1; i < 13; i++)
            {
                cbbThang.Items.Add(i);
                cbbThangThuoc.Items.Add(i);
            }
        }

        private void btLapBC_Click(object sender, EventArgs e)
        {
           
            if(cbbThang.Text != "" && cbbNam.Text != "" )
            {
                int mouth = Convert.ToInt32(cbbThang.Text);
                int year = Convert.ToInt32(cbbNam.Text);

                HS_KHAM_BENHBUS hs_KHAM_BENHBUS = new HS_KHAM_BENHBUS();
                HOA_DONBUS hoa_DONBUS = new HOA_DONBUS();

                List<int[]> list = hs_KHAM_BENHBUS.LaySoBenhNhanKhamTrongNgayTheoThang(mouth, year);

                int TongDoangThu = hoa_DONBUS.LayTongDoanhThuTrongThang(mouth, year);

                for (int i = 0; i < list.Count; i++)
                {
                    int tienKham = hoa_DONBUS.LayTongTienKhamTrongNgay(list[i][1], mouth, year);
                    int tienThuoc = hoa_DONBUS.LayTongTienThuocTrongNgay(list[i][1], mouth, year);
                    int doangThu = tienKham + tienThuoc;
                    decimal tyLe = doangThu / TongDoangThu * 100;

                    dgvDoangThuTheoNgay.Rows.Add(i, list[i][1], list[i][0], doangThu, Math.Round(tyLe, 2));//1 là ngày, 0 là số bệnh nhân

                }
            }
            else
            { 
                MessageBox.Show("Vui lòng nhập ngày tháng.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbbThangThuoc.Text != "" && cbbNamThuoc.Text != "")
            {
                int mouth = Convert.ToInt32(cbbThangThuoc.Text);
                int year = Convert.ToInt32(cbbNamThuoc.Text);

                THUOCBUS thuocBUS = new THUOCBUS();

                List<int> listSoLuong =new List<int>();
                List<int> listSoLanDung = new List<int>();

                List<THUOCDTO> list = thuocBUS.LayBaoCaoSuDungThuoc(mouth, year, listSoLuong, listSoLanDung);


                for (int i = 0; i < list.Count; i++)
                {
                    dgvSuDungThuoc.Rows.Add(i, list[i].Ten_Thuoc1, list[i].Don_Vi1, listSoLuong[i], listSoLanDung[i]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ngày tháng.");
            }

        }
    }
}
