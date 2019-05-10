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
    class UserRegister
    {
        MY_DB mydb = new MY_DB();
        public DataTable getUserById(Int32 userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("select * from hr where id=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public bool insertUser(int ID, string fname, string lname, string user, string pass, MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("insert into Login(Id,f_name,l_name,username,password,figure)" +
                "values (@id,@fname,@lname,@user,@pass,@pic)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
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
        public bool updateUser(int ID, string fname, string lname, string user, string pass, MemoryStream pic)
        {
            SqlCommand cmd = new SqlCommand("update Login set Id=@id,f_name=@fname," +
                "l_name=@lname,username=@user,password=@pass,figure=@pic"
                , mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
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
        public bool usernameExist(int ID, string user)
        {
            SqlCommand cmd = new SqlCommand("select * from Login", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                if (user == dt.Rows[i]["username"].ToString().Trim() || ID ==Convert.ToInt32(dt.Rows[i]["id"].ToString().Trim()))
                    return false;
            }
            return true;
        }
    }
}