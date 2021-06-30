using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;      

namespace DAO
{
    public class HOA_DONDAO
    {
        public List<HOA_DONDTO> LayTienKhamTienThuoc(String Ma_HS)
        {
            List<HOA_DONDTO> lHS_KHAM_BENHDTO = new List<HOA_DONDTO>();

            String query = "SELECT Tien_Kham, Tien_thuoc " +
                "FROM[BENHVIENTU].[dbo].[HOA_DON] WHERE [Ma_HS] = '" + Ma_HS + "'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dataTable.Rows)
            {
                HOA_DONDTO hs = new HOA_DONDTO();

                hs.Tien_Kham1 = Convert.ToInt32( dr["Tien_Kham"]);
                hs.Tien_Thuoc1 = Convert.ToInt32(dr["Tien_thuoc"]);
                lHS_KHAM_BENHDTO.Add(hs);
            }
            return lHS_KHAM_BENHDTO;
        }

        public int LayTongTienKhamTrongNgay(int day, int month, int year)
        {
            int resutl = 0;

            String query = "Select sum(HOA_DON.Tien_Kham) from [BENHVIENTU].[dbo].HS_KHAM_BENH, [BENHVIENTU].[dbo].HOA_DON" +
                " where HS_KHAM_BENH.Ma_HS = HOA_DON.Ma_HS and day(HS_KHAM_BENH.Ngay_Kham) = " + day.ToString() +
                "and month(HS_KHAM_BENH.Ngay_Kham) ="+month.ToString() +" and year(HS_KHAM_BENH.Ngay_Kham) = " + year.ToString();
            if (DataProvider.Instance.ExecuteSaclar(query) == DBNull.Value)
            {
                return 0;
            }

            resutl = Convert.ToInt32(DataProvider.Instance.ExecuteSaclar(query));
            return resutl;
        }

        public int LayTongTienThuocTrongNgay(int day, int month, int year)
        {
            int resutl = 0;

            String query = "Select sum(HOA_DON.Tien_Thuoc) from [BENHVIENTU].[dbo].HS_KHAM_BENH, [BENHVIENTU].[dbo].HOA_DON" +
                " where HS_KHAM_BENH.Ma_HS = HOA_DON.Ma_HS and day(HS_KHAM_BENH.Ngay_Kham) = " + day.ToString() +
                "and month(HS_KHAM_BENH.Ngay_Kham) =" + month.ToString() + " and year(HS_KHAM_BENH.Ngay_Kham) = " + year.ToString();

            if (DataProvider.Instance.ExecuteSaclar(query) == DBNull.Value)
            {
                return 0;
            }

            resutl = Convert.ToInt32(DataProvider.Instance.ExecuteSaclar(query));
            return resutl;
        }

        public int LayTongDoanhThuTrongThang(int month, int year)
        {
            int resutl = 0;

            String query = "Select sum(HOA_DON.Tien_Kham) + sum(HOA_DON.Tien_thuoc) " +
                "from [BENHVIENTU].[dbo].HS_KHAM_BENH, [BENHVIENTU].[dbo].HOA_DON where HS_KHAM_BENH.Ma_HS = HOA_DON.Ma_HS and" +
                " month(HS_KHAM_BENH.Ngay_Kham) = "+ month.ToString()+ " and year(HS_KHAM_BENH.Ngay_Kham) =" + year.ToString();

            if(DataProvider.Instance.ExecuteSaclar(query) == DBNull.Value)
            {
                return 0;
            }    
            resutl = Convert.ToInt32(DataProvider.Instance.ExecuteSaclar(query));
            return resutl;
        }


    }
}
