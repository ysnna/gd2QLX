using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17110094_NguyenAnh_Login
{
    static class GlobalID
    {
        public static int IDGlobal = 0;
        public static int SetGlobalUserID(int userid)
        {
            IDGlobal = userid;
            return IDGlobal;
        }
    }
}