using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LOAI_BENHDAO
    {
        public List<LOAI_BENHDTO> LayDanhSachLoaiBenh()
        {
            List<LOAI_BENHDTO> list = new List<LOAI_BENHDTO>();

            String query = "SELECT * FROM[BENHVIENTU].[dbo].[LOAI_BENH] ";           



            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dataTable.Rows)
            {
                LOAI_BENHDTO lb = new LOAI_BENHDTO();

                lb.LOAI_BENH1 = dr["LOAI_BENH"].ToString();


                list.Add(lb);
            }
            return list;
        }

        public int Them(String tenBenh)
        {
            String query = "INSERT INTO [BENHVIENTU].[dbo].[LOAI_BENH] VALUES ('" + tenBenh+ "')";

            return DataProvider.Instance.ExecuteNonQuery(query);         
        }
        public int Xoa(String tenBenh)
        {
            String query = "DELETE  FROM [BENHVIENTU].[dbo].[LOAI_BENH]  WHERE LOAI_BENH = '"+ tenBenh + "'";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int Sua(String tenBenhCu, String  tenBenhMoi)
        {
            String query = "UPDATE [BENHVIENTU].[dbo].[LOAI_BENH] SET LOAI_BENH = '" 
                + tenBenhMoi + "' WHERE LOAI_BENH = '" + tenBenhCu + "'";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
