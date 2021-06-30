using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class LOAI_BENHBUS
    {
        LOAI_BENHDAO loaiBenhDAO;

        public LOAI_BENHBUS()
        {
            this.loaiBenhDAO = new LOAI_BENHDAO();
        }
        public List<LOAI_BENHDTO> LayDanhSachLoaiBenh()
        {
            return loaiBenhDAO.LayDanhSachLoaiBenh();
        }

        public int Them(String tenBenh)
        {
            return loaiBenhDAO.Them(tenBenh);
        }

        public int Xoa(String tenBenh)
        {
            return loaiBenhDAO.Xoa(tenBenh);
        }

        public int Sua(String tenBenhCu, String tenBenhMoi)
        {
            return loaiBenhDAO.Sua(tenBenhCu, tenBenhMoi);
        }

    }
}
