﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiXe
{
    class MY_DB
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Desktop\QuanLiXe\QuanLiXe\DESKTOP-RRRHOP4.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\LTWindows\WindowsQLXe\QLXe\gd2QLX\QuanLiXe\QuanLiXe\DESKTOP-RRRHOP4.mdf;Integrated Security=True;Connect Timeout=30");
       // SqlConnection conn=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="E:\LTWindows\WindowsQLXe\QLXe\QLXe\QuanLiXe\QuanLiXe\DESKTOP-RRRHOP4(2).mdf";Integrated Security=True;Connect Timeout=30");
        public SqlConnection getConnection
        {
            get { return conn; }
        }
        public void openConnection()
        {
            if ((conn.State == ConnectionState.Closed))
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if ((conn.State == ConnectionState.Open))
            {
                conn.Close();
            }
        }
    }
}