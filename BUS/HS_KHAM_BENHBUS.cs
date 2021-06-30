using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HS_KHAM_BENHBUS
    {
        private HS_KHAM_BENHDAO hs_KHAM_BENHDAO;

        public HS_KHAM_BENHBUS()
        {
            hs_KHAM_BENHDAO = new HS_KHAM_BENHDAO();
        }

        public List<HS_KHAM_BENHDTO> LayDanhSachKhamBenh(DateTime dateTime, int mode)
        {
            return hs_KHAM_BENHDAO.LayDanhSachKhamBenh(dateTime, mode);
        }

        public int ThemSTT(String Ma_HS, int STT, DateTime dateTime)
        {
            return hs_KHAM_BENHDAO.ThemSTTNgayKham(Ma_HS, STT, dateTime);
        }

        public List<HS_KHAM_BENHDTO> LayHoTen()
        {
            return hs_KHAM_BENHDAO.LayHoTen();
        }

        public List<HS_KHAM_BENHDTO> LayDanhSachBenhNhan()
        {
            return hs_KHAM_BENHDAO.LayDanhSachBenhNhan();
        }

        public List<HS_KHAM_BENHDTO> TimBenhNhan(String ho_Ten)
        {
            return hs_KHAM_BENHDAO.TimBenhNhan(ho_Ten);
        }

        public List<HS_KHAM_BENHDTO> TimBenhNhanTheoMa_HS(String Ma_HS)
        {
            return hs_KHAM_BENHDAO.TimBenhNhanTheoMa_HS(Ma_HS);
        }

        public List<int[]> LaySoBenhNhanKhamTrongNgayTheoThang(int month, int year)
        {
            return hs_KHAM_BENHDAO.LaySoBenhNhanKhamTrongNgayTheoThang(month, year);
        }
    }
}
