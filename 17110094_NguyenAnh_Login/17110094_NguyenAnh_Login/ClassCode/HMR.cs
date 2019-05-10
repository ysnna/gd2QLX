using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace _17110094_NguyenAnh_Login
{
    class HMR
    {
        MY_DB mydb = new MY_DB();
        public bool insertContact(string fname, string lname, int groupid, string phone, string email, string address, MemoryStream pic, int userid)
        {
            SqlCommand cmd = new SqlCommand("insert into Contact ( fname,lname, group_id, phone,email, address,pic,userid)" +
                " values ( @fn, @ln, @groupid, @phn,@email, @add, @pic,@uid)", mydb.getConnection);
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
            cmd.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

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
        public DataTable getContact(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public bool updateContact(string fname, string lname, int groupid, string phone, string email, string address, MemoryStream pic, int userid)
        {
            SqlCommand cmd = new SqlCommand("update Contact set fname=@fn,lname=@ln, group_id=@groupid, phone=@phn,email=@email, address=@add,pic=@pic where userid=@uid"
                , mydb.getConnection);
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@groupid", SqlDbType.Int).Value = groupid;
            cmd.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

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
