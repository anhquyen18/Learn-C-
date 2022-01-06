using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsNv = new List<NhanVien>();
            dsNv.Add(new NhanVien() { Ma = 1, Ten = "Trần Anh Quyền", Phone="0383798211" });
            dsNv.Add(new NhanVien() { Ma = 2, Ten = "Trần Anh Nguyên", Phone = "0383218211" });
            dsNv.Add(new NhanVien() { Ma = 3, Ten = "Trần Anh Quân", Phone = "0383793211" });

            nhanVienGV.DataSource = dsNv;
        }

        private void nhanVienGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = nhanVienGV.Rows[e.RowIndex];
            string ten = row.Cells[1].Value + "";
            MessageBox.Show(ten);
        }
    }
}
