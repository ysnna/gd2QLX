using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _17110094_NguyenAnh_Login
{
    class SCORE
    {
        MY_DB mydb = new MY_DB();
        public bool insertScore(int studentID, int courseID, float scoreValue, string description)
        {
            SqlCommand cmd = new SqlCommand("insert into score (student_id, course_id, student_score, description) values (@sid, @cid, @scr, @des)", mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            cmd.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
            cmd.Parameters.Add("@des", SqlDbType.VarChar).Value = description;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }
        //kiểm tra trùng
        public bool studentScoreExist(int studentID, int courseID)
        {
            SqlCommand cmd = new SqlCommand("select * from score where student_id = @ sid and course_id = @cid", mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0)
                return false;
            return true;
        }
        //tính trung bình
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = "select course.label, avg(score.student_score) as averageGrade from course, score where course.id = score.course_id group by course.label";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        //delete score bằng student_id và course_id
        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand cmd = new SqlCommand("delete from score where student_id = @sid and course_id = @cid", mydb.getConnection);
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
                return true;
            return false;
        }
        public DataTable getAllScore(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }
        public int totalCourse()
        {
            SqlCommand cmd = new SqlCommand("select id from score");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows.Count;
        }
        public DataTable getResultByScore()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = "select std.id, avg(score.student_score) as averageGrade from score, std where std.id = score.student_id group by std.id";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getRemove()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = "select student_id, fName, lName, course_id, label, student_score from course, score, std where course.id = score.course_id and std.id = score.student_id";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getShowStudent()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = "select id, fName, lName, bdate from std";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getScoreById(int id)
        {
            SqlCommand command = new SqlCommand("select Course.Label,Score.Student_Score from Score join Course on Score.Course_ID = Course.ID where Student_ID = " + "'" + id + "'" + " order by Label", mydb.getConnection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adap.Fill(table);
            return table;
        }
    }
}