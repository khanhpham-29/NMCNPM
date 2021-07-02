using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HS_KHAM_BENHDAO
    {
        //1 là xem trước danh sách chuẩn bị lâp., 0 là xem danh sách cũ
        public List<HS_KHAM_BENHDTO> LayDanhSachKhamBenh(DateTime dateTime, int mode)
        {
            List<HS_KHAM_BENHDTO> lHS_KHAM_BENHDTO = new List<HS_KHAM_BENHDTO>();

            String query = "SELECT TOP (40) [STT], HS_KHAM_BENH.Ma_Hs ,[Ho_Ten],[Gioi_Tinh],[Nam_Sinh],[Dia_Chi]" +
                      " FROM[BENHVIENTU].[dbo].[HS_KHAM_BENH] join [BENHVIENTU].[dbo].DS_KHAM_BENH on DS_KHAM_BENH.Ma_HS = HS_KHAM_BENH.Ma_HS where CONVERT(date, Ngay_Kham) = '" +
                      dateTime.ToString("yyyy - MM - dd") + "' or Ngay_Kham is null";
            if(mode == 0)
            {
                query = "SELECT TOP(40)[STT], HS_KHAM_BENH.Ma_Hs ,[Ho_Ten],[Gioi_Tinh],[Nam_Sinh],[Dia_Chi]" +
                      " FROM[BENHVIENTU].[dbo].[HS_KHAM_BENH] join [BENHVIENTU].[dbo].DS_KHAM_BENH on DS_KHAM_BENH.Ma_HS = HS_KHAM_BENH.Ma_HS where CONVERT(date, Ngay_Kham) = '" +
                      dateTime.ToString("yyyy - MM - dd") + "'";
            }
           


            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            int stt = 1;

            foreach (DataRow dr in dataTable.Rows)
            {
                HS_KHAM_BENHDTO hs = new HS_KHAM_BENHDTO();

                hs.Ma_HS1 = dr["Ma_HS"].ToString();
                hs.Ho_Ten1 = dr["Ho_Ten"].ToString();
                hs.Gioi_Tinh1 = dr["Gioi_Tinh"].ToString();
                hs.Nam_Sinh1 = dr["Nam_Sinh"].ToString();
                if(mode == 0)
                {
                    if(dr["STT"] != null)
                    {
                        hs.STT1 = Convert.ToInt32(dr["STT"].ToString());
                    }    
                }
                else
                {
                    hs.STT1 = stt;
                }    
                hs.Dia_Chi1 = dr["Dia_Chi"].ToString();

                stt++;

                lHS_KHAM_BENHDTO.Add(hs);
            }
            return lHS_KHAM_BENHDTO;
        }

        public int ThemSTTNgayKham(String Ma_HS, int STT, DateTime dateTime)
        {
            String query = "UPDATE [BENHVIENTU].[dbo].[DS_KHAM_BENH] SET [STT] = " +
                STT.ToString()+ ", [Ngay_Kham] ='" + dateTime.ToString("yyyy-MM-dd") +"' WHERE  Ma_HS = '" + Ma_HS +"'";
                
            return (DataProvider.Instance.ExecuteNonQuery(query));  
        }

        public List<HS_KHAM_BENHDTO> LayHoTen()
        {
            List<HS_KHAM_BENHDTO> lHS_KHAM_BENHDTO = new List<HS_KHAM_BENHDTO>();

            String query = "SELECT [Ma_HS],[Ho_Ten] FROM[BENHVIENTU].[dbo].[HS_KHAM_BENH] ";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dataTable.Rows)
            {
                HS_KHAM_BENHDTO hs = new HS_KHAM_BENHDTO();

                hs.Ma_HS1 = dr["Ma_HS"].ToString();
                hs.Ho_Ten1 = dr["Ho_Ten"].ToString();
                lHS_KHAM_BENHDTO.Add(hs);
            }
            return lHS_KHAM_BENHDTO;
        }

        public List<HS_KHAM_BENHDTO> LayDanhSachBenhNhan()
        {
            List<HS_KHAM_BENHDTO> lHS_KHAM_BENHDTO = new List<HS_KHAM_BENHDTO>();

            String query = "SELECT HS_KHAM_BENH.Ma_Hs ,[Ho_Ten],[Ngay_Kham],[Du_Doan_Loai_Benh],[Trieu_Chung] FROM [BENHVIENTU].[dbo].[HS_KHAM_BENH] join [BENHVIENTU].[dbo].DS_KHAM_BENH on DS_KHAM_BENH.Ma_HS = HS_KHAM_BENH.Ma_HS";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dataTable.Rows)
            {
                HS_KHAM_BENHDTO hs = new HS_KHAM_BENHDTO();

                hs.Ma_HS1 = dr["Ma_HS"].ToString();
                hs.Ho_Ten1 = dr["Ho_Ten"].ToString();
                hs.Ngay_Kham1 = dr["Ngay_Kham"].ToString();
                hs.Du_Doan_Loai_Benh1 = dr["Du_Doan_Loai_Benh"].ToString();
                hs.Trieu_Chung1 = dr["Trieu_Chung"].ToString();
                lHS_KHAM_BENHDTO.Add(hs);
            }
            return lHS_KHAM_BENHDTO;
        }

        public List<HS_KHAM_BENHDTO> TimBenhNhan(String ho_Ten)
        {
            List<HS_KHAM_BENHDTO> lHS_KHAM_BENHDTO = new List<HS_KHAM_BENHDTO>();

            String query = "SELECT HS_KHAM_BENH.Ma_Hs ,[Ho_Ten],[Ngay_Kham],[Du_Doan_Loai_Benh],[Trieu_Chung] " +
                "FROM[BENHVIENTU].[dbo].[HS_KHAM_BENH] join [BENHVIENTU].[dbo].DS_KHAM_BENH on DS_KHAM_BENH.Ma_HS = HS_KHAM_BENH.Ma_HS WHERE [Ho_Ten] LIKE '%" + ho_Ten +"%'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            int stt = 1;
            foreach (DataRow dr in dataTable.Rows)
            {
                HS_KHAM_BENHDTO hs = new HS_KHAM_BENHDTO();

                hs.STT1 = stt;
                hs.Ma_HS1 = dr["Ma_HS"].ToString();
                hs.Ho_Ten1 = dr["Ho_Ten"].ToString();
                hs.Ngay_Kham1 = dr["Ngay_Kham"].ToString();
                hs.Du_Doan_Loai_Benh1 = dr["Du_Doan_Loai_Benh"].ToString();
                hs.Trieu_Chung1 = dr["Trieu_Chung"].ToString();
                lHS_KHAM_BENHDTO.Add(hs);
                stt++;
            }
            return lHS_KHAM_BENHDTO;
        }

        public List<HS_KHAM_BENHDTO> TimBenhNhanTheoMa_HS(String Ma_HS)
        {
            List<HS_KHAM_BENHDTO> lHS_KHAM_BENHDTO = new List<HS_KHAM_BENHDTO>();

            String query = "SELECT HS_KHAM_BENH.Ma_Hs ,[Ho_Ten],[Ngay_Kham],[Du_Doan_Loai_Benh],[Trieu_Chung] " +
                "FROM[BENHVIENTU].[dbo].[HS_KHAM_BENH] join [BENHVIENTU].[dbo].DS_KHAM_BENH on DS_KHAM_BENH.Ma_HS = HS_KHAM_BENH.Ma_HS WHERE HS_KHAM_BENH.Ma_Hs = '" + Ma_HS +"'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dataTable.Rows)
            {
                HS_KHAM_BENHDTO hs = new HS_KHAM_BENHDTO();

                hs.Ma_HS1 = dr["Ma_HS"].ToString();
                hs.Ho_Ten1 = dr["Ho_Ten"].ToString();
                hs.Ngay_Kham1 = dr["Ngay_Kham"].ToString();
                hs.Du_Doan_Loai_Benh1 = dr["Du_Doan_Loai_Benh"].ToString();
                hs.Trieu_Chung1 = dr["Trieu_Chung"].ToString();
                lHS_KHAM_BENHDTO.Add(hs);
            }
            return lHS_KHAM_BENHDTO;
        }

        public List<int[]> LaySoBenhNhanKhamTrongNgayTheoThang(int month, int year)
        {
            List<int[]> list = new List<int[]>();

            String query = "SELECT COUNT(HS_KHAM_BENH.Ma_HS) , Day(Ngay_Kham) from[BENHVIENTU].[dbo].HS_KHAM_BENH join [BENHVIENTU].[dbo].DS_KHAM_BENH on DS_KHAM_BENH.Ma_HS = HS_KHAM_BENH.Ma_HS" +
                " where MONTH(Ngay_Kham) =" + month.ToString()  + " and YEAR(Ngay_Kham) = " + year.ToString() +" group by Ngay_Kham";


            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dataTable.Rows)
            {
                int[] temp = new int[2];

                temp[0] =  Convert.ToInt32( dr[0]);
                temp[1] = Convert.ToInt32(dr[1]);
                list.Add(temp);
            }
            return list;
        }
    }
}
