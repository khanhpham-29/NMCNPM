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
    public partial class fThayDoiQuyDinh : Form
    {

        private String tenBenhDGV = null;
        private String maThuocCu = null;


        public fThayDoiQuyDinh()
        {
            InitializeComponent();
            KhoiTaoThuoc();
            khoiTaoLoaiBenh();
            khoiTaoQuyDinhChung();
        }

        void KhoiTaoThuoc()
        {
            dgvThuoc.Rows.Clear();
            THUOCBUS thuocBUS = new THUOCBUS();
            List<THUOCDTO> list = thuocBUS.LayDanhSachThuoc();

            for (int i = 0; i < list.Count(); i++)
            {
                dgvThuoc.Rows.Add(list[i].Ma_Thuoc1, list[i].Ten_Thuoc1, list[i].Don_Vi1, list[i].Gia1);
            }
        }
        void khoiTaoLoaiBenh()
        {
            dgvLoaiBenh.Rows.Clear();
            LOAI_BENHBUS loai_BENHBUS = new LOAI_BENHBUS();
            List<LOAI_BENHDTO> list = loai_BENHBUS.LayDanhSachLoaiBenh();

            for (int i = 0; i < list.Count(); i++)
            {
                dgvLoaiBenh.Rows.Add(i, list[i].LOAI_BENH1);
            }
        }


        void khoiTaoQuyDinhChung()
        {

            QUY_DINHBUS quy_DINHBUS = new QUY_DINHBUS();
            List<QUYDINHDTO> listQuyDinh = quy_DINHBUS.LayQuyDinh();

            tbBenhNhanToiDa.Text = Convert.ToInt32(listQuyDinh[0].BENH_NHAN_TOI_DA1).ToString();
            tbTienKham.Text = Convert.ToInt32( listQuyDinh[0].TIEN_KHAM1).ToString();
            tbSoCachDung.Text = Convert.ToInt32(listQuyDinh[0].SO_CACH_DUNG1).ToString();
        }

        private void btThayDoiQuyDinhChung_Click(object sender, EventArgs e)
        {
            QUY_DINHBUS quy_DINHBUS = new QUY_DINHBUS();

            int tienKham = Convert.ToInt32(tbTienKham.Text);
            int soCachDung = Convert.ToInt32(tbSoCachDung.Text);
            int benhNhanToiDa = Convert.ToInt32(tbBenhNhanToiDa.Text);
            if (quy_DINHBUS.DoiQuyDinh(tienKham, soCachDung, benhNhanToiDa) > 0)
            {
                MessageBox.Show("Thay đổi thành công");
            }
            else
            {
                MessageBox.Show("Thay đổi không thành công");
            }    
        }

        private void dgvLoaiBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvLoaiBenh.Rows[e.RowIndex];
            if(row.Cells[1].Value!= null)
            {
                tbTenBenh.Text = row.Cells[1].Value.ToString();
                tenBenhDGV = row.Cells[1].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            LOAI_BENHBUS loai_BENHBUS = new LOAI_BENHBUS();

            String tenBenhMoi = tbTenBenh.Text;

            int isSuccess = loai_BENHBUS.Them(tenBenhMoi);
            if (isSuccess > 0)
            {
                MessageBox.Show("Đã thêm bệnh mới");
                khoiTaoLoaiBenh();
            }
            else
            {
                MessageBox.Show("Không thể thêm bệnh mới.");
            }        

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            LOAI_BENHBUS loai_BENHBUS = new LOAI_BENHBUS();

            String tenBenh = tbTenBenh.Text;

            int isSuccess = loai_BENHBUS.Xoa(tenBenh);
            if (isSuccess > 0)
            {
                MessageBox.Show("Đã xóa bệnh");
                khoiTaoLoaiBenh();
            }
            else
            {
                MessageBox.Show("Không thể xóa bệnh.");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            LOAI_BENHBUS loai_BENHBUS = new LOAI_BENHBUS();

            String tenBenhCu = tenBenhDGV;
            String tenBenhMoi = tbTenBenh.Text;

            int isSuccess = loai_BENHBUS.Sua(tenBenhCu, tenBenhMoi);
            if (isSuccess > 0)
            {
                MessageBox.Show("Đã sửa bệnh.");
                khoiTaoLoaiBenh();
            }
            else
            {
                MessageBox.Show("Không thể sửa bệnh.");
            }
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvThuoc.Rows[e.RowIndex];
            if (row.Cells[1].Value != null)
            {
                tbThuoc.Text = row.Cells[1].Value.ToString();
                tbMaThuoc.Text = row.Cells[0].Value.ToString();
                tbDonViTinh.Text = row.Cells[2].Value.ToString();
                tbDonGia.Text = row.Cells[3].Value.ToString();

                maThuocCu = tbMaThuoc.Text;
            }

        }

        private void btThemThuoc_Click(object sender, EventArgs e)
        {
            THUOCBUS thuocBUS = new THUOCBUS();
            if (thuocBUS.Them(tbMaThuoc.Text, tbThuoc.Text, Convert.ToInt32(tbDonGia.Text), tbDonViTinh.Text) > 0)
            {
                MessageBox.Show("Thêm thành công");
                KhoiTaoThuoc();
             }
            else
            {
                MessageBox.Show("Thêm Không thành công");
            }
        }

        private void btXoaThuoc_Click(object sender, EventArgs e)
        {
            THUOCBUS thuocBUS = new THUOCBUS();
            if (thuocBUS.Xoa(tbMaThuoc.Text) > 0)
            {
                MessageBox.Show("Xóa thành công");
                KhoiTaoThuoc();
            }
            else
            {
                MessageBox.Show("Xóa Không thành công");
            }
        }

        private void btSuaThuoc_Click(object sender, EventArgs e)
        {
            THUOCBUS thuocBUS = new THUOCBUS();
            if (thuocBUS.Sua(maThuocCu, tbMaThuoc.Text, tbThuoc.Text, Convert.ToInt32(tbDonGia.Text), tbDonViTinh.Text) > 0)
            {
                MessageBox.Show("Sửa thành công");
                KhoiTaoThuoc();
            }
            else
            {
                MessageBox.Show("Sửa Không thành công");
            }
        }
    }
}
