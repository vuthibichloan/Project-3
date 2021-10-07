using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLDiemTHPT.Entities;
using QLDiemTHPT.DataAccess;

namespace QLDiemTHPT.Bussiness
{
    class DangnhapBUS
    {
        DangnhapDAO usdao = new DangnhapDAO(@"Data Source=DESKTOP-KBSLCQ1;Initial Catalog=DoAn_QuanlyDiemHSTHPT;Integrated Security=True");

        public DangnhapBUS() { }

        public DangnhapBUS(string stcon)
        {
            usdao = new DangnhapDAO(stcon);
        }

        public Users CheckUser(string tentk, string mk)
        {
            return usdao.GetUsers(tentk, mk);
        }
    }
}
