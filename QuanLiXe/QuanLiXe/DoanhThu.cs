using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace QuanLiXe
{
    class DoanhThu
    {
        MY_DB mydb = new MY_DB();
        
        //Get tu bang QLLXe ra
        public DataTable getDoanhThu(DateTime ngaylay)
        {
            SqlCommand cmd = new SqlCommand("select loaixe,ngaylayxe,count (loaixe) as loaixe,sum (tongtien) as tongtien from QLLAYXE where ngaylayxe= @ngaylay group by loaixe, ngaylayxe", mydb.getConnection);
            cmd.Parameters.Add("@ngaylay", SqlDbType.Date).Value = ngaylay;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Insert vao bang doanh thu
        public bool insertDoanhThu(string loaixe, DateTime ngaylay, int soluong, int tongtien)
        {
            SqlCommand cmd = new SqlCommand("insert into DOANHTHUGUIXE(loaixe,ngaylay,soluong,tongtien)" +
                             "values(@loaixe,@ngaylay,@soluong,@tongtien)", mydb.getConnection);
            cmd.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
            cmd.Parameters.Add("@ngaylay", SqlDbType.Date).Value = ngaylay;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@tongtien", SqlDbType.Int).Value = tongtien;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        //Get tu bang DoanhThuGiuXe de lay thong ke
        public DataTable getThongKe()
        {
            SqlCommand cmd = new SqlCommand("select * from DOANHTHUGUIXE", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool search(DateTime date,string loaixe)
        {
            SqlCommand cmd = new SqlCommand("select * from DOANHTHUGUIXE where ngaylay=@ngaylay and loaixe=@loaixe", mydb.getConnection);
            cmd.Parameters.Add("@ngaylay", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0) return true;
            return false;
        }
        public bool updateDoanhThu(int soluong, int tongtien, string loaixe)
        {
            SqlCommand cmd = new SqlCommand("update DOANHTHUGUIXE set soluong=@soluong, tongtien=@tongtien where loaixe=@loaixe ", mydb.getConnection);
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("@tongtien", SqlDbType.Int).Value = tongtien;
            cmd.Parameters.Add("@loaixe", SqlDbType.NVarChar).Value = loaixe;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}