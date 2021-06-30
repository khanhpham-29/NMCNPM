using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CHI_TIET_TOA_THUOCDAO
    {
        public DataTable LayToaThuoc(String Ma_HS)
        {
            String query = "SELECT  THUOC.Ten_thuoc, THUOC.Don_Vi, CHI_TIET_TOA_THUOC.So_luong," +
                " CHI_TIET_TOA_THUOC.Cach_dung FROM [BENHVIENTU].[dbo].HS_KHAM_BENH, " +
                "[BENHVIENTU].[dbo].CHI_TIET_TOA_THUOC, [BENHVIENTU].[dbo].THUOC" +
                " WHERE HS_KHAM_BENH.Ma_HS = CHI_TIET_TOA_THUOC.Ma_HS AND THUOC.Ma_thuoc = CHI_TIET_TOA_THUOC.Ma_thuoc" +
                " AND CHI_TIET_TOA_THUOC.Ma_HS = '"+ Ma_HS +"'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            //Dictionary<THUOCDTO, CHI_TIET_TOA_THUOCDTO> result = new Dictionary<THUOCDTO, CHI_TIET_TOA_THUOCDTO>();

            //foreach (DataRow dr in dataTable.Rows)
            //{

            //    THUOCDTO thuocDTO = new THUOCDTO();
            //    CHI_TIET_TOA_THUOCDTO chi_TIET_TOA_THUOCDTO = new CHI_TIET_TOA_THUOCDTO();
            //    thuocDTO.Ten_Thuoc1 = dr["Ten_Thuoc"].ToString();
            //    thuocDTO.Don_Vi1 = dr["Don_Vi"].ToString();
            //    chi_TIET_TOA_THUOCDTO.So_Luong1 = Convert.ToInt32( dr["So_Luong"]);
            //    chi_TIET_TOA_THUOCDTO.Cach_Dung1 = dr["Cach_Dung"].ToString();


            //    result.Add(thuocDTO, chi_TIET_TOA_THUOCDTO);
            //}

            //return result;
            return dataTable;
        }

    }
}
