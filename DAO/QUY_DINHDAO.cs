using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QUY_DINHDAO
    {
        public List<QUYDINHDTO> LayQuyDinh()
        {
            List<QUYDINHDTO> list = new List<QUYDINHDTO>();

            String query = "SELECT * FROM[BENHVIENTU].[dbo].[QUY_DINH] ";



            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dr in dataTable.Rows)
            {
                QUYDINHDTO qd = new QUYDINHDTO();

                qd.BENH_NHAN_TOI_DA1 = Convert.ToInt32( dr["BENH_NHAN_TOI_DA"]);
                qd.TIEN_KHAM1 = Convert.ToInt32(dr["TIEN_KHAM"]);
                qd.SO_CACH_DUNG1 = Convert.ToInt32(dr["CACH_DUNG"]);
                list.Add(qd);
            }
            return list;
        }

        public int DoiQuyDinh(int tienKham, int soCachDung, int benhNhanToiDa)
        {
            String query = "INSERT INTO [BENHVIENTU].[dbo].[QUY_DINH] VALUES (" + tienKham.ToString() +
                ","+ benhNhanToiDa.ToString() + "," + soCachDung.ToString() + ")";

           return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
