﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe
{
    class NhanVien
    {
        MY_DB mydb = new MY_DB();
        public bool insertNhanVien(string manv, string fname, string lname, string gender, DateTime bdate, string phone,
            string address, string cmnd, MemoryStream ava, string type)
        {
            SqlCommand cmd = new SqlCommand("insert into NhanVien(MaNV,fName,lName,gender,Birthday,Phone,Address,Cmnd,Ava,type)" +
                "values (@makh,@fname,@lname,@gender,@bdate,@phone,@add,@cmnd,@ava,@type)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@bdate", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = ava.ToArray();
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;

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
        public DataTable getAllCus()
        {
            SqlCommand cmd = new SqlCommand("select *from NhanVien", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllTho()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where type='Tho'", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllVanPhong()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where type='Van Phong'", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllGS()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where type='Giam Sat'", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable refresh()
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool UpdateNhanVien(string manv, string fname, string lname, string gender, DateTime birthday, string phone, string address, string cmnd, MemoryStream pt, string type)
        {
            SqlCommand cmd = new SqlCommand("update NhanVien set fName=@fname,lName=@lName,Gender=@gender,Birthday=@birthday,Phone=@Phone," +
                "Address=@address,Cmnd=@cmnd,Ava=@ava,type=@type where MaNV=@manv", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = birthday;
            cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            cmd.Parameters.Add("@ava", SqlDbType.Image).Value = pt.ToArray();
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
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
        public bool insertVanPhong(string manv, string type, string note, string mahd)
        {
            SqlCommand cmd = new SqlCommand("insert into Tho(MaNV,MaHD,Note,MaHD)" +
                "values (@makh,@type,@note,@mahd)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = note;
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;

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
        public bool DeleteNhanVien(string manv)
        {
            SqlCommand cmd = new SqlCommand("delete from NhanVien where MaNV=@manv", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
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
        public bool insertTho(string manv, string type, string note, string mahd)
        {
            SqlCommand cmd = new SqlCommand("insert into Tho(MaNV,Type,Note,MaHD)" +
                "values (@makh,@type,@note,@mahd)", mydb.getConnection);
            cmd.Parameters.Add("@makh", SqlDbType.VarChar).Value = manv;
            cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = type;
            cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = note;
            cmd.Parameters.Add("@mahd", SqlDbType.VarChar).Value = mahd;

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
        public DataTable searchNhanVien(string manv)
        {
            SqlCommand cmd = new SqlCommand("select * from NhanVien where MaNV=@manv", mydb.getConnection);
            cmd.Parameters.Add("@manv", SqlDbType.VarChar).Value = manv;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllNV()
        {
            SqlCommand cmd = new SqlCommand("select *from NhanVien", mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}