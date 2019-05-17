using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe
{
    static class Global
    {
        public static string IDKH = "";
        public static string getID(string id)
        {
            IDKH = id;
            return IDKH;
        }
        public static string manv = "0";
        public static string MANV(string Manv)
        {
            manv = Manv;
            return manv;
        }
        public static string fName = "0";
        public static string FNAME(string fname)
        {
            fName = fname;
            return fName;
        }
        public static string lName = "0";
        public static string LNAME(string lname)
        {
            lName = lname;
            return lName;
        }
        public static string Gender = "0";
        public static string gender(string GenDer)
        {
            Gender = GenDer;
            return Gender;
        }
        public static DateTime bday;
        public static DateTime Birthday(DateTime BDAY)
        {
            bday = BDAY;
            return bday;
        }
        public static string phone = "0";
        public static string PHONE(string Phone)
        {
            phone = Phone;
            return phone;
        }
        //public static DateTime bday = "0";
        //public static DateTime BDAY(string BDay)
        //{
        //    Address = address;
        //    return Address;
        //}
        public static string Address = "0";
        public static string ADDRESS(string address)
        {
            Address = address;
            return Address;
        }
        public static string Cmnd = "0";
        public static string CMND(string cmnd)
        {
            Cmnd = cmnd;
            return Cmnd;
        }
        public static string type = "0";
        public static string TYPE(string Type)
        {
            type = Type;
            return type;
        }
        public static Image pic = null;
        public static Image Pic(Image picture)
        {
            pic = picture;
            return pic;
        }

    }
}
