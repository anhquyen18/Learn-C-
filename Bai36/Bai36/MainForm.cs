using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai36
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btSoKiTu_Click(object sender, EventArgs e)
		{
			tbKetQua.Text = tbDuLieuGoc.Text.Length + "";
		}

		private void btInHoa_Click(object sender, EventArgs e)
		{
			tbKetQua.Text = tbDuLieuGoc.Text.ToUpper();
		}

		private void btInThuong_Click(object sender, EventArgs e)
		{
			tbKetQua.Text = tbDuLieuGoc.Text.ToLower();
		}

		private void btDemChuHoa_Click(object sender, EventArgs e)
		{
			string s = tbDuLieuGoc.Text;
			int dem = 0;
			foreach(char c in s)
			{
				if (char.IsUpper(c))
					dem++;
			}
			tbKetQua.Text = "Có" + dem + " ký tự là in Hoa";
		}

		private void btDemChuThuong_Click(object sender, EventArgs e)
		{
			string s = tbDuLieuGoc.Text;
			int dem = 0;
			foreach (char c in s)
			{
				if (char.IsLower(c))
					dem++;
			}
			tbKetQua.Text = "Có" + dem + " ký tự là in Thường";
		}

		private void btDemSo_Click(object sender, EventArgs e)
		{
			string s = tbDuLieuGoc.Text;
			int dem = 0;
			foreach (char c in s)
			{
				if (char.IsDigit(c))
					dem++;
			}
			tbKetQua.Text = "Có " + dem + " ký tự là Số";
		}

		private void btDaoChuoi_Click(object sender, EventArgs e)
		{
			string s = tbDuLieuGoc.Text;
			//string s2 = "";
			//for (int i = s.Length-1; i >= 0; i--)
			//{
			//    s2 += s[i];
			//}
			//tbKetQua.Text = s2;

			// Cách 2:
			List<char> s2 = s.Reverse().ToList();
			tbKetQua.Text = "";
			foreach(char c in s2)
				tbKetQua.Text += c;
		}

		private void btToiUuChuoi_Click(object sender, EventArgs e)
		{
			string s = tbDuLieuGoc.Text.Trim();
			string[] arr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			tbKetQua.Text = "";
			
			foreach (string word in arr)
			{
				tbKetQua.Text += word + " ";
			}
			tbKetQua.Text = tbKetQua.Text.Trim();
		}

		private void btViTriDau_Click(object sender, EventArgs e)
		{
			int vt = tbDuLieuGoc.Text.IndexOf(tbViTriDau.Text);
			
			if (vt == -1)
			{
				tbKetQua.Text = "Không tìm thấy [" + tbViTriDau.Text + "]";
			}
			else
			{
				tbKetQua.Text = "Tìm thấy [" + tbViTriDau.Text + "] tại vị trí đầu tiền là " + vt;
			}
		}

		private void btViTriCuoi_Click(object sender, EventArgs e)
		{
			int vt = tbDuLieuGoc.Text.LastIndexOf(tbViTriCuoi.Text);

			if (vt == -1)
			{
				tbKetQua.Text = "Không tìm thấy [" + tbViTriCuoi.Text + "]";
			}
			else
			{
				tbKetQua.Text = "Tìm thấy [" + tbViTriCuoi.Text + "] tại vị trí cuối cùng là " + vt;
			}
		}

		private void btSoLanXuatHien_Click(object sender, EventArgs e)
		{
			int dem = 0;
			string s = tbDuLieuGoc.Text;
			int vt = tbDuLieuGoc.Text.IndexOf(tbSoLanXuatHien.Text);
			if (vt == -1)
			{
				tbKetQua.Text = "Không có [" + tbSoLanXuatHien.Text + "] trong chuỗi";
			}
			else
			{
				while (vt != -1)
				{
					dem++;
					s = s.Substring(vt + tbSoLanXuatHien.Text.Length);
					vt = s.IndexOf(tbSoLanXuatHien.Text);
				}
				tbKetQua.Text = "Tìm thấy [" + dem + "] lần xuất hiện [" + tbSoLanXuatHien.Text + "] ";
			}
		}

        private void btTachTu_Click(object sender, EventArgs e)
        {
			char[] arrKT = tbTachTu.Text.ToCharArray();
			string[] arrWord = tbDuLieuGoc.Text.Split(arrKT);
			tbKetQua.Text = "";
			foreach (string s in arrWord)
				tbKetQua.Text += s + "\r\n";
        }

        private void btThayDoi_Click(object sender, EventArgs e)
        {
			tbKetQua.Text = tbDuLieuGoc.Text.Replace(tbThayDoiCu.Text, tbThayDoiMoi.Text);
        }

        private void btXoaChuoi_Click(object sender, EventArgs e)
        {
			int vt = tbDuLieuGoc.Text.IndexOf(tbXoaChuoi.Text);
			if (vt != -1)
            {
				string s = tbDuLieuGoc.Text;
				s = s.Remove(vt, tbXoaChuoi.Text.Length);
				tbKetQua.Text = s;
            }

        }

        private void btChenChuoi_Click(object sender, EventArgs e)
        {
			string s = tbDuLieuGoc.Text;
			string s2 = s.Insert(int.Parse(tbViTriChenChuoi.Text), tbChenChuoi.Text);
			tbKetQua.Text = s2;
        }

        private void btTrichLoc_Click(object sender, EventArgs e)
        {

        }
    }
}
