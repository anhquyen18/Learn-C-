using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai31
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void datHangBt_Click(object sender, EventArgs e)
        {
            string detail = "";
            detail = "Thông tin khách hàng: \n"+ "\nHọ và tên khách hàng: \n" + tenTB.Text;
            //detail += "\nHọ và tên khách hàng: \n"+tenTB.Text;
            detail += "\nSĐT khách hàng: \n" + soDTTB.Text;
            detail += "\nSản phầm khách hàng đặt: \n" + danhSachLB.SelectedItem;
            detail += "\nHình thức thanh toán: \n" + PTTTCB.SelectedItem;
            chiTietTB.Text = detail;

        }

        private void PTTTCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PTTTCB.SelectedIndex != -1)
            {
                MessageBox.Show("Bạn chọn thanh toán: " + PTTTCB.SelectedItem);
            }

            if (comboBox1.SelectedIndex != 1)
            {
                HinhThucThanhToan ht = comboBox1.SelectedItem as HinhThucThanhToan;

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            HinhThucThanhToan atm = new HinhThucThanhToan();
            atm.Ma = 1;
            atm.HinhThuc = "Chuyển khoản ATM";
            atm.PhiThanhToan = 0;
            comboBox1.Items.Add(atm);

            HinhThucThanhToan tructiep = new HinhThucThanhToan();
            tructiep.Ma = 2;
            tructiep.HinhThuc = "Thanh toán tại cửa hàng";
            tructiep.PhiThanhToan = 0;
            comboBox1.Items.Add(tructiep);
        }
    }
}
