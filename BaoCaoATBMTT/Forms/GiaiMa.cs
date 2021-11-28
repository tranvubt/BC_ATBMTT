using BaoCaoATBMTT.MaHoa;
using System;
using BaoCaoATBMTT.Ults;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCaoATBMTT.Forms
{
    public partial class GiaiMa : Form
    {
        private bool inPutType = true;
        private string input;
        private string Key;

        public GiaiMa(string key, string inPut)
        {
            InitializeComponent();
            this.input = inPut;
            this.Key = key;
        }
        private void GiaiMa_Load(object sender, EventArgs e)
        {
            txtKey.Text = Key;
            txtInput.Text = input;
        }

        private void rdFileInput_CheckedChanged(object sender, EventArgs e)
        {
            btnChoosenFile.Enabled = true;
            btnChoosenPathSever.Enabled = true;
            txtInput.Enabled = false;
            inPutType = false;
        }

        private void rdNhapInput_CheckedChanged(object sender, EventArgs e)
        {
            btnChoosenFile.Enabled = false;
            btnChoosenPathSever.Enabled = false;
            txtInput.Enabled = true;
            inPutType = true;
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "" | txtKey.Text.Length < 8)
            {
                MessageBox.Show("Bạn hãy nhập khóa : 8 kí tự");
                txtKey.Focus();
                return;
            }
            if (txtInput.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập vào chuỗi cần giải mã");
                txtInput.Focus();
                return;
            }
            txtBanRoBit.Text = "";
            txtOutput.Text = "";
            string khoa = txtKey.Text;
            string inPut = txtInput.Text;
            ModunDES modun = new ModunDES(StringToBinary(khoa).ToCharArray(), binaybanma(inPut));
            while (true)
            {
                if (modun.giaiMa() == true)
                {
                    txtBanRoBit.Text = modun.banMaBit;
                    txtOutput.Text = doirachu(modun.banMaBit);
                    break;
                }
            }
        }

        public string[] binaybanma(string input)
        {
            string[] daybanma = new string[30];
            var sodaybanma = input.Length / 8;
            daybanma = new string[sodaybanma - 1 + 1];
            for (int i = 0; i <= sodaybanma - 1; i++)
            {
                daybanma[i] = input.Substring(i * 8, 8);
                daybanma[i] = StringToBinary(daybanma[i]);
            }
            return daybanma;
        }
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
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

        
    }
}
