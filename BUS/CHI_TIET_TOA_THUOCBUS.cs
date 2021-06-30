using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class CHI_TIET_TOA_THUOCBUS
    {
        private CHI_TIET_TOA_THUOCDAO chi_TIET_TOA_THUOCDAO;

        public CHI_TIET_TOA_THUOCBUS()
        {
            chi_TIET_TOA_THUOCDAO = new CHI_TIET_TOA_THUOCDAO();
        }
        //public Dictionary<THUOCDTO, CHI_TIET_TOA_THUOCDTO> LayToaThuoc(String Ma_HS)
        //{
        //    return chi_TIET_TOA_THUOCDAO.LayToaThuoc(Ma_HS);
        //}
        public DataTable LayToaThuoc(String Ma_HS)
        {
            return chi_TIET_TOA_THUOCDAO.LayToaThuoc(Ma_HS);
        }


    }
}
