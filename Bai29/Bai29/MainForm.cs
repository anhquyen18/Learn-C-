using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai29
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dangKyBt_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(tenTB, "");
            errorProvider1.SetError(tuoiTB, "");
            errorProvider1.SetError(ngayDangKyDTP, "");
            if (tenTB.Text == "")
            {
                errorProvider1.SetError(tenTB, "Đã nhập tên đâu thằng ngu?");
                return;
            }
            int tuoi = 0;
            if (int.TryParse(tuoiTB.Text,out tuoi) == false)
            {
                errorProvider1.SetError(tuoiTB, "Nhập sai tuổi rồi thằng óc chó!!");
                return;
            }
            else
            {
                if (tuoi < 18)
                {
                    errorProvider1.SetError(tuoiTB, "Tuổi phải lớn hơn 17 bố ạ!");
                    return;
                }
                    
            }

            if (ngayDangKyDTP.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                errorProvider1.SetError(ngayDangKyDTP, "Ai mà đi làm ngày Chủ nhật cho bố?");
                return;
            }

            MessageBox.Show("Đăng ký thành công!");
        }
    }
}
