using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class THUOCDAO
    {
        public List<THUOCDTO> LayBaoCaoSuDungThuoc(int month,int year, List<int> soLuong, List<int> soLanDung)
        {

            List<THUOCDTO> list = new List<THUOCDTO>();

            String query = "select THUOC.Ma_thuoc, THUOC.Ten_thuoc, THUOC.Don_Vi, sum(So_luong), COUNT(CHI_TIET_TOA_THUOC.Ma_HS) " +
                "from THUOC, CHI_TIET_TOA_THUOC, DS_KHAM_BENH where THUOC.Ma_thuoc = CHI_TIET_TOA_THUOC.Ma_thuoc" +
                " and DS_KHAM_BENH.Ma_HS = CHI_TIET_TOA_THUOC.Ma_HS and MONTH(DS_KHAM_BENH.Ngay_Kham)= " + month.ToString() +
                "and YEAR(DS_KHAM_BENH.Ngay_Kham)=" + year.ToString() + "group by THUOC.Ma_thuoc, THUOC.Ten_thuoc, THUOC.Don_Vi";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dataTable.Rows)
            {
                THUOCDTO thuoc = new THUOCDTO();

                thuoc.Ma_Thuoc1 = dr["Ma_Thuoc"].ToString();
                thuoc.Ten_Thuoc1 = dr["Ten_Thuoc"].ToString();
                thuoc.Don_Vi1 = dr["Don_Vi"].ToString();

                soLuong.Add(Convert.ToInt32(dr[3]));
                soLanDung.Add(Convert.ToInt32(dr[4]));
                list.Add(thuoc);
            }
            return list;
        }

        public List<THUOCDTO> LayDanhSachThuoc()
        {
            List<THUOCDTO> list = new List<THUOCDTO>();

            String query = "SELECT * FROM[BENHVIENTU].[dbo].[THUOC] ";



            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dataTable.Rows)
            {
                THUOCDTO thuoc = new THUOCDTO();

                thuoc.Gia1 = Convert.ToInt32(dr["Gia"]);
                thuoc.Don_Vi1 = dr["Don_Vi"].ToString();
                thuoc.Ten_Thuoc1 = dr["Ten_Thuoc"].ToString();
                thuoc.Ma_Thuoc1 = dr["Ma_Thuoc"].ToString();

                list.Add(thuoc);
            }
            return list;
        }

        public int Them(String maThuoc, String tenThuoc, int gia, String donVi )
        {
            String query = "INSERT INTO [BENHVIENTU].[dbo].[THUOC] VALUES ('" +
                maThuoc + "', '" + tenThuoc + "', '" + donVi + "'," + gia + ")" ;

            return DataProvider.Instance.ExecuteNonQuery(query);
        }


        public int Xoa(String maThuoc)
        {
            String query = "DELETE  FROM [BENHVIENTU].[dbo].[THUOC]  WHERE Ma_thuoc = '" + maThuoc + "'";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int Sua(String maThuocCu, String maThuocMoi, String tenThuoc, int gia, String donVi)
        {
            String query = "UPDATE [BENHVIENTU].[dbo].[THUOC] SET Ma_thuoc = '"
                + maThuocMoi + "' , Ten_thuoc ='" + tenThuoc +"', Don_Vi = '" + donVi + "', Gia = "+
                gia.ToString() + " WHERE Ma_thuoc = '" + maThuocCu + "'";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
