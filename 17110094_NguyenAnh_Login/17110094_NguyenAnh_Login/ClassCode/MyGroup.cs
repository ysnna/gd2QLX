using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
namespace _17110094_NguyenAnh_Login
{
    class MyGroup
    {
        MY_DB mydb = new MY_DB();
        public bool insertGroup(int id, string groupname, int userid)
        {
            SqlCommand cmd = new SqlCommand("insert into Grouptable (id,name,userid)"+" values(@id,@gn,@uid)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@gn", SqlDbType.VarChar).Value = groupname;
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
        public bool updateGroup(int id, string groupname)
        {
            SqlCommand cmd = new SqlCommand("update Grouptable set name=@gn where id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@gn", SqlDbType.VarChar).Value = groupname;
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
        public bool deleteGroup(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Grouptable where id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
        public DataTable getGroups(int uid)
        {
            SqlCommand cmd = new SqlCommand("select * from Grouptable where userid=@uid", mydb.getConnection);
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public bool groupExist(string name, string operation, int userid = 0, int groupid = 0)
        {
            string query = "";
            SqlCommand cmd = new SqlCommand();
            if (operation == "add")
            {
                query = "select *from Grouptable where name=@name and userid = @uid";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            }
            else if (operation == "edit")
            {
                query = "select *from grouptable where name=@name and userid = @uid and id <>@gid";
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
                cmd.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}