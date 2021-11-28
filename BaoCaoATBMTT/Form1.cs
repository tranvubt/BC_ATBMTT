using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace BaoCaoATBMTT
{
    public partial class Form1 : Form
    {
        private string Key;
        private string inPut;

        public const int WM_NCLBUTTONDOWN = 0x112;
        public const int HT_CAPTION = 0xf012;
        private Form activateForm;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipe
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            plNav.Height = btnMahoa.Height;
            plNav.Top = btnMahoa.Top;
            plNav.Left = btnMahoa.Left;
            btnMahoa.BackColor = Color.FromArgb(46, 51, 73);
            Forms.MaHoa fmH = new Forms.MaHoa();
            fmH.truyenData = new Forms.MaHoa.truyenMain(saveData);
            OpenChildForm(fmH);
        }

        private void saveData(string key, string inPut)
        {
            Key = key;
            this.inPut = inPut;
        }

        private void OpenChildForm(Form childForm)
        {
            if(activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.palControl.Controls.Add(childForm);
            this.palControl.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            plNav.Height = btnMahoa.Height;
            plNav.Top = btnMahoa.Top;
            plNav.Left = btnMahoa.Left;
            btnMahoa.BackColor = Color.FromArgb(46, 51, 73);
            Forms.MaHoa fmH = new Forms.MaHoa();
            fmH.truyenData = new Forms.MaHoa.truyenMain(saveData);
            OpenChildForm(fmH);
        }

        public void btnGiaiMa_Click(object sender, EventArgs e)
        {
            plNav.Height = btnGiaiMa.Height;
            plNav.Top = btnGiaiMa.Top;
            plNav.Left = btnGiaiMa.Left;
            btnGiaiMa.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new Forms.GiaiMa(Key, inPut));
        }

        private void btnBangMa_Click(object sender, EventArgs e)
        {
            plNav.Height = btnBangMa.Height;
            plNav.Top = btnBangMa.Top;
            plNav.Left = btnBangMa.Left;
            btnBangMa.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new Forms.BangMa());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            plNav.Height = btnHepl.Height;
            plNav.Top = btnHepl.Top;
            plNav.Left = btnHepl.Left;
            btnHepl.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new Forms.Help());
        }

        private void btnMahoa_Leave(object sender, EventArgs e)
        {
            btnMahoa.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnGiaiMa_Leave(object sender, EventArgs e)
        {
            btnGiaiMa.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBangMa_Leave(object sender, EventArgs e)
        {
            btnBangMa.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHepl_Leave(object sender, EventArgs e)
        {
            btnHepl.BackColor = Color.FromArgb(24, 30, 54);
        }

        //Btn close
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Btn minisize
        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Di chuyển Form
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
