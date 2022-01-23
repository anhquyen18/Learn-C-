﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strConn = "SERVER=PAIDEPTRAI\\SQLEXPRESS; Database = CSDL_QLDB; Integrated Security = True";
        private void btKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                MessageBox.Show("Kết nối CSDL thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDongKetNoi_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Đóng kết nối CSDL thành công");
            }
        }
    }
}
