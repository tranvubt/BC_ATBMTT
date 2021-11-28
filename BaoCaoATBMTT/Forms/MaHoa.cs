using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaoCaoATBMTT.MaHoa;

namespace BaoCaoATBMTT.Forms
{
    public partial class MaHoa : Form
    {
        public delegate void truyenMain(string key, string input);
        public truyenMain truyenData;
        private bool inPutType = true;

        public MaHoa()
        {
            InitializeComponent();
        }

        #region Các hàm sự kiện
        private void rdNhapInput_CheckedChanged(object sender, EventArgs e)
        {
            btnChoosenFile.Enabled = false;
            txtInput.Enabled = true;
            inPutType = true;
        }

        private void rdFileInput_CheckedChanged(object sender, EventArgs e)
        {
            btnChoosenFile.Enabled = true;
            txtInput.Enabled = false;
            inPutType = false;
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (inPutType == true)
            {
                if (txtInput.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập vào chuỗi cần mã hoá");
                    txtInput.Focus();
                    return;
                }
                if (txtKey.Text == "" | txtKey.Text.Length < 8)
                {
                    MessageBox.Show("Bạn hãy nhập vào khóa :8 kí tự");
                    txtKey.Focus();
                    return;
                }
            }
            string khoa = txtKey.Text;
            string inPut = txtInput.Text;
            if (khoa.Length > 8)
            {
                khoa = txtKey.Text.Remove(8, khoa.Length - 8);
                txtKey.Text = khoa;
                MessageBox.Show("Lưu ý. Khoá của bạn đã được thay đổi cho phù hợp với thuật toán!");
            }
            txtKeyBit.Text = "";
            txtBanMaBit.Text ="";
            ModunDES modun = new ModunDES(StringToBinary(khoa).ToCharArray(), binarynhap(inPut));
            while (true)
            {
                if (modun.maHoa() == true)
                {
                    txtKeyBit.Text = modun.dayKhoaBit;
                    txtBanMaBit.Text = modun.banMaBit;
                    txtOutput.Text = doirachu(modun.banMaBit);
                    truyenData(txtKey.Text, txtOutput.Text);
                    break;
                }
            }
        }
        #endregion

        #region Các hàm chuyển đổi inPut và  outPut
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        public string[] binarynhap(string inPut)
        {
            string[] daynhap = new string[30];
            int i;
            int sokitudu = inPut.Length % 8;
            if (sokitudu > 0)
            {
                int sokituthem = 8 - sokitudu;
                for (i = 1; i <= sokituthem; i++)
                    inPut += " ";
            }
            int sodaynhap = inPut.Length / 8;
            daynhap = new string[sodaynhap - 1 + 1];
            for (i = 0; i <= sodaynhap - 1; i++)
            {
                daynhap[i] = inPut.Substring(i * 8, 8);
                daynhap[i] = StringToBinary(daynhap[i]);
            }
            return daynhap;
        }
        public string doirachu(string y)
        {
            string tam = y;
            string tam1 = "";
            int so = 0;
            int i = 0;
            int j;
            while (i < tam.Length - 1)
            {
                so = 0;
                for (j = i; j <= i + 7; j++)
                {
                    if (int.Parse(tam.Substring(j, 1)) == 1)
                    {
                        so += (int)Math.Pow(2, 7 - (j - i));
                    }
                }
                tam1 += (char)so;
                i = i + 8;
            }
            return tam1;
        }
        #endregion

        private void txtFilePathInput_TextChanged(object sender, EventArgs e)
        {
            btnMaHoa.Enabled = true;
        }
    }
}
