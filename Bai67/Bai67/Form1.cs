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

namespace Bai67
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn =
            "SERVER=PAIDEPTRAI\\SQLEXPRESS; Database = CSDLTest; Integrated Security = True";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSDLTestDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.cSDLTestDataSet.SanPham);

        }
    }
}
