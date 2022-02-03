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
using Microsoft.Reporting.WinForms;
namespace Bai68
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
                "SERVER=PAIDEPTRAI\\SQLEXPRESS; Database = CSDLTest; Integrated Security = True");
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from SanPham", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "SanPham");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bai68.ReportSanPham.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
