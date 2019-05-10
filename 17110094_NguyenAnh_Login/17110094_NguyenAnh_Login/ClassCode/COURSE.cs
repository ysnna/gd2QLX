using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _17110094_NguyenAnh_Login
{
    class Course
    {
        MY_DB mydb = new MY_DB();
        public bool insertCourse(int id, string label, int period, string description)
        {
            SqlCommand cmd = new SqlCommand("insert into COURSE (id, label,period, description)" +
                " values (@id, @lb, @pr, @des)", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@lb", SqlDbType.VarChar).Value = label;
            cmd.Parameters.Add("@pr", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = description;


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
        public DataTable getCourseById(int id)
        {
            SqlCommand cmd = new SqlCommand("select label from COURSE where id = @id", mydb.getConnection);
            //cmd.Parameters.Add("@label", SqlDbType.VarChar).Value = id;
            //mydb.openConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
            //if (cmd.ExecuteNonQuery() == 1)
            //{
            //    mydb.closeConnection();
            //    return true;
            //}
            //else
            //{
            //    mydb.closeConnection();
            //    return false;
            //}
        }
        public bool deleteCourse(int id)
        {
            SqlCommand cmd = new SqlCommand("delete  from COURSE where id = @id", mydb.getConnection);
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
        public bool checkCourseName(string courseName, int courseID = 0)
        {
            SqlCommand cmd = new SqlCommand("select * from course where label=@cName and id <> @cID", mydb.getConnection);
            cmd.Parameters.Add("cName", SqlDbType.VarChar).Value = courseName;
            cmd.Parameters.Add("cID", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public bool updateCourse(int id, string label, int period, string description)
        {
            SqlCommand cmd = new SqlCommand("update course set id = @id, label = @lb, period = @pr, description = @desc where id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@lb", SqlDbType.VarChar).Value = label;
            cmd.Parameters.Add("@pr", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = description;
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
        public DataTable getAllCourse(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public int totalCourse()
        {
            SqlCommand cmd = new SqlCommand("select * from course",mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table.Rows.Count;
        }
    }
}