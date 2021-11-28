using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCaoATBMTT.Ults;

namespace BaoCaoATBMTT.MaHoa
{
    class ModunDES
    {
        private DESConstants DESConstainer;
        private string[] daykhoa = new string[16];
        private char[] key;
        private string[] inPut;
        public bool status;
        public string dayKhoaBit;
        public string banMaBit;

        public ModunDES(char[] key, string[] inPut)
        {
            DESConstainer = new DESConstants();
            this.key = key;
            this.inPut = inPut;
            status = false;
        }
        public bool maHoa()
        {
            dayKhoaBit = taodaykhoa(this.key);
            banMaBit = mahoa(this.inPut);
            return true;
        }
        public bool giaiMa()
        {
            dayKhoaBit = taodaykhoa(this.key);
            banMaBit = giaima(this.inPut);
            return true;
        }

        //Tạo khoá
        private string taodaykhoa(char[] khoas)
        {
            status = false;
            string dayKhoaTemp = "";
            char[] khoa1 = hvpc1(khoas);
            string[] d = new string[17];
            string[] c = new string[17];
            c[0] = new string(new ArraySegment<char>(khoa1, 0, 28));
            c[0] = ls(c[0], 1);
            d[0] = new string(new ArraySegment<char>(khoa1, 28, 28));
            d[0] = ls(d[0], 1);
            string b = c[0] + d[0];
            daykhoa[0] = new string(hvpc2((b).ToCharArray()));
            dayKhoaTemp += daykhoa[0] + (char)(9) + "\n";
            int i;
            for (i = 1; i <= 15; i++)
            {
                if (i == 2 - 1 | i == 9 - 1 | i == 16 - 1)
                {
                    c[i] = ls(c[i - 1], 1);
                    d[i] = ls(d[i - 1], 1);
                }
                else
                {
                    c[i] = ls(c[i - 1], 2);
                    d[i] = ls(d[i - 1], 2);
                }
                daykhoa[i] = new string(hvpc2((c[i] + d[i]).ToCharArray()));
                dayKhoaTemp += daykhoa[i] + (char)(9) + "\n";
            }
            return dayKhoaTemp;
        }

        //Mã hoá
        public string mahoa(string[] daynhap)
        {
            int k;
            string x;
            string y = "";
            for (k = 0; k <= daynhap.Length - 1; k++)
            {
                x = daynhap[k];
                char[] x0 = hvip(x.ToCharArray());
                string[] l = new string[16];
                string[] r = new string[16];
                int i, j;
                string l0 = new string(new ArraySegment<char>(x0, 0, 32));
                string r0 = new string(new ArraySegment<char>(x0, 32, 32));
                l[0] = r0;
                for (i = 0; i <= 31; i++)
                {
                    r[0] += (int.Parse(l0.Substring(i, 1)) ^ int.Parse(f(r0, daykhoa[0])[i].ToString())).ToString();
                }

                for (i = 1; i <= 15; i++)
                {
                    l[i] = r[i - 1];
                    char[] a = f(r[i - 1], daykhoa[i]);
                    for (j = 0; j <= 31; j++)
                    {
                        r[i] += (int.Parse(l[i - 1].Substring(j, 1)) ^ int.Parse(a[j].ToString())).ToString();
                    }
                }
                string v = new string(hviptru((r[15] + l[15]).ToCharArray()));
                y += v;
            }
            return y;
        }

        //Giải mã
        public string giaima(string[] daybanma)
        {
            int k;
            string x = "";
            for (k = 0; k <= daybanma.Length - 1; k++)
            {
                char[] y0 = hvip(daybanma[k].ToCharArray());
                string rr = new string(new ArraySegment<char>(y0, 0, 32));
                string ll = new string(new ArraySegment<char>(y0, 32, 32));
                int i, j;
                string[] l = new string[16];
                string[] r = new string[16];
                r[15] = ll;
                for (i = 0; i <= 31; i++)
                {
                    l[15] += (int.Parse(rr.Substring(i, 1)) ^ int.Parse(f(ll, daykhoa[15])[i].ToString())).ToString();
                }
                for (i = 14; i >= 0; i += -1)
                {
                    r[i] = l[i + 1];
                    char[] a = f(l[i + 1], daykhoa[i]);
                    for (j = 0; j <= 31; j++)
                        l[i] += (int.Parse(r[i + 1].Substring(j, 1)) ^ int.Parse(a[j].ToString())).ToString();
                }
                string y = new string(hviptru((l[0] + r[0]).ToCharArray()));
                x += y;
            }
            return x;
        }

        //Hàm F
        public char[] f(string r, string k)
        {
            int i;
            string e = "";
            string hv = new string(hve(r.ToCharArray()));
            for (i = 0; i <= 47; i++)
                e += (int.Parse(hv.Substring(i, 1)) ^ int.Parse(k.Substring(i, 1))).ToString();
            string[] b = new string[8];
            char[] c = { };
            for (i = 0; i <= 7; i++)
            {
                b[i] = e.Substring(i * 6, 6);
                string haibitcuoi = b[i].Substring(0, 1) + b[i].Substring(5, 1);
                string bonbitgiua = b[i].Substring(1, 4);
                var srow = Convert.ToInt32(haibitcuoi, 2);
                var scol = Convert.ToInt32(bonbitgiua, 2);
                int sij = int.Parse(DESConstainer.s[i].Rows[srow][scol].ToString());
                c = c.Concatenate(binary(sij));
            }
            c = hvp(c);
            return c;
        }

        #region Các hàm chuyển đổi
        public string ls(string s, int n)
        {
            return s.Substring(n, s.Length - n) + s.Substring(0, n);
        }

        public static char[] binary(int a)
        {
            int i;
            char[] tam = new char[4];
            for (i = 0; i <= 3; i++)
            {
                tam[i] = char.Parse((a % 2).ToString());
                a = a / 2;
            }
            Array.Reverse(tam);
            return tam;
        }

        public char[] catbitcuoi(char[] k) // dua vao 64 bit tra ra 56 bit
        {
            int i = 0;
            int j;
            string tam = "";
            while (i < 63)
            {
                for (j = i; j <= i + 6; j++)
                    tam += k[j];
                i = i + 8;
            }
            return tam.ToCharArray();
        }
        #endregion

        #region Các hàm hoán vị
        public char[] hvpc1(char[] k)
        {
            char[] tam = catbitcuoi(k);
            for (int i = 0; i <= 55; i++)
            {
                int p = int.Parse(DESConstainer.pc1[i]) - 1;
                tam[i] = k[p];
            }
            return tam;
        }

        public char[] hvpc2(char[] str)
        {
            char[] tam = new char[48];
            int i;
            for (i = 0; i <= 47; i++)
            {
                var h = int.Parse(DESConstainer.pc2[i]) - 1;
                tam[i] = str[h];
            }
            return tam;
        }

        public char[] hvip(char[] x)
        {
            string po = new string(x);
            char[] tam = new char[64];
            int i;
            for (i = 0; i <= 63; i++)
            {
                int bxgd = int.Parse(DESConstainer.ip[i]) - 1;
                tam[i] = x[bxgd];
            }
            return tam;
        }

        public char[] hve(char[] r)
        {
            char[] tam = new char[48];
            int i;
            for (i = 0; i <= 47; i++)
                tam[i] = r[int.Parse(DESConstainer.E[i]) - 1];
            return tam;
        }

        public char[] hvp(char[] c)
        {
            char[] tam = new char[32];
            int i;
            for (i = 0; i <= 31; i++)
                tam[i] = c[int.Parse(DESConstainer.p[i]) - 1];
            return tam;
        }

        public char[] hviptru(char[] c)
        {
            char[] tam = new char[64];
            int i;
            for (i = 0; i <= 63; i++)
                tam[int.Parse(DESConstainer.ip[i]) - 1] = c[i];
            return tam;
        }
        #endregion

    }
}
