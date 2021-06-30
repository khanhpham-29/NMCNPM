using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;

namespace QuanLyPhongMach
{
    public partial class fDanhSachKhamBenh : Form
    {
        public fDanhSachKhamBenh()
        {
            InitializeComponent();
        }


        private void dtpDanhSachKhamBenh_ValueChanged(object sender, EventArgs e)
        {
                     

        }

        private void btLapDanhSachKhamBenh_Click(object sender, EventArgs e)
        {            
            HS_KHAM_BENHBUS hs_KHAM_BENHBUS = new HS_KHAM_BENHBUS();
            DateTime dateTime = dtpDanhSachKhamBenh.Value;

            if(dtpDanhSachKhamBenh.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày lên lịch đã qua!!!");
            }   
            else
            {
                for (int i = 0; i < dgvDanhSachKhamBenh.Rows.Count; i++)
                {
                    String ma_HS = dgvDanhSachKhamBenh.Rows[i].Cells["colMa_HS"].Value.ToString();
                    int stt = i;

                    if (hs_KHAM_BENHBUS.ThemSTT(ma_HS, i, dateTime) == 0)
                        MessageBox.Show("Khong the them " + dgvDanhSachKhamBenh.Rows[i].Cells["colMa_HS"].Value.ToString());
                }

                MessageBox.Show("Lập Danh sách khám bệnh thành công");
            }    
        }

        private void btXemTruocDanhSach_Click(object sender, EventArgs e)
        {
            if(dtpDanhSachKhamBenh.Value < DateTime.Now)
            {
                MessageBox.Show("Vui lòng chọn này trong tương lai");
            }
            else
            {
                HS_KHAM_BENHBUS hs_KHAM_BENHBUS = new HS_KHAM_BENHBUS();
                DateTime dateTime = dtpDanhSachKhamBenh.Value;
                dgvDanhSachKhamBenh.AutoGenerateColumns = false;
                dgvDanhSachKhamBenh.DataSource = hs_KHAM_BENHBUS.LayDanhSachKhamBenh(dateTime, 1);
            }    
            
        }

        private void btXemDanhSachCu_Click(object sender, EventArgs e)
        {
            if (dtpDanhSachKhamBenh.Value > DateTime.Now)
            {
                MessageBox.Show("Vui lòng chọn này trong Quá khứ");
            }
            else
            {
                HS_KHAM_BENHBUS hs_KHAM_BENHBUS = new HS_KHAM_BENHBUS();
                DateTime dateTime = dtpDanhSachKhamBenh.Value;
                dgvDanhSachKhamBenh.AutoGenerateColumns = false;
                dgvDanhSachKhamBenh.DataSource = hs_KHAM_BENHBUS.LayDanhSachKhamBenh(dateTime, 0);
            }    
        }
    }

}
