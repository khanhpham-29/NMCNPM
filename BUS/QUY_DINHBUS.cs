using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class QUY_DINHBUS
    {
        QUY_DINHDAO quyDinhDAO;

        public QUY_DINHBUS()
        {
            this.quyDinhDAO = new QUY_DINHDAO();
        }

        public List<QUYDINHDTO> LayQuyDinh()
        {
            return quyDinhDAO.LayQuyDinh();
        }
        public int DoiQuyDinh(int tienKham, int soCachDung, int benhNhanToiDa)
        {
            return quyDinhDAO.DoiQuyDinh(tienKham, soCachDung, benhNhanToiDa);
        }
    }
}
