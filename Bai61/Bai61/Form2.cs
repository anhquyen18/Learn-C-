using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai61
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string sqlConn =
            "SERVER=PAIDEPTRAI\\SQLEXPRESS; Database = CSDLTest; Integrated Security = True";

        private void Form2_Load(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from DanhMuc";
            command.Connection = conn;

            lbxDanhMuc.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string line = reader.GetInt32(0) + "-" + reader.GetString(1);
                lbxDanhMuc.Items.Add(line);
            }
            reader.Close();
        }

        private void lbxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxDanhMuc.SelectedIndex == -1) return;
            string line = lbxDanhMuc.SelectedItem.ToString();
            string[] arr = line.Split('-');
            int maDM = int.Parse(arr[0]);

            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from SanPham where MaDanhMuc=@madm";
            command.Connection = conn;

            SqlParameter parMaDM = new SqlParameter("@madm", SqlDbType.Int);
            parMaDM.Value = maDM;
            command.Parameters.Add(parMaDM);

            lvSanPham.Items.Clear();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int gia = reader.GetInt32(2);
                ListViewItem lvi = new ListViewItem(ma + "");
                lvi.SubItems.Add(ten);
                lvi.SubItems.Add(gia + "");

                lvSanPham.Items.Add(lvi);
            }
            reader.Close();

        }

    }
}
