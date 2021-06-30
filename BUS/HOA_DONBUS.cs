using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HOA_DONBUS
    {
        private HOA_DONDAO hoa_DONDAO;

        public HOA_DONBUS()
        {
            hoa_DONDAO = new HOA_DONDAO();
        }

        public List<HOA_DONDTO> LayTienKhamTienThuoc(String Ma_HS)
        {
            return hoa_DONDAO.LayTienKhamTienThuoc(Ma_HS);
        }

        public int LayTongTienKhamTrongNgay(int day, int month, int year)
        {
            return hoa_DONDAO.LayTongTienKhamTrongNgay(day, month, year);
        }

        public int LayTongTienThuocTrongNgay(int day, int month, int year)
        {
            return hoa_DONDAO.LayTongTienThuocTrongNgay(day, month, year);
        }

        public int LayTongDoanhThuTrongThang(int month, int year)
        {
            return hoa_DONDAO.LayTongDoanhThuTrongThang(month, year);
        }
    }
}
