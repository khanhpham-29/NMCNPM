using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class THUOCBUS
    {
        THUOCDAO thuocDAO;

        public THUOCBUS()
        {
            this.thuocDAO = new THUOCDAO();
        }

        public List<THUOCDTO> LayBaoCaoSuDungThuoc(int month, int year, List<int> soLuong, List<int> soLanDung)
        {
            return thuocDAO.LayBaoCaoSuDungThuoc(month, year, soLuong, soLanDung);
        }

        public List<THUOCDTO> LayDanhSachThuoc()
        {
            return thuocDAO.LayDanhSachThuoc();
        }


        public int Them(String maThuoc, String tenThuoc, int gia, String donVi)
        {
            return thuocDAO.Them(maThuoc, tenThuoc, gia,donVi);
        }


        public int Xoa(String maThuoc)
        {
            return thuocDAO.Xoa(maThuoc);
        }

        public int Sua(String maThuocCu, String maThuocMoi, String tenThuoc, int gia, String donVi)
        {
            return thuocDAO.Sua(maThuocCu, maThuocMoi, tenThuoc, gia, donVi);
        }
    }
}
