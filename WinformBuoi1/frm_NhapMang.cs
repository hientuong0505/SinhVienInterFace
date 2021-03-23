using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBuoi1
{
    public partial class frm_NhapMang : Form
    {
        public frm_NhapMang()
        {
            InitializeComponent();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            txt_MangA.Text = "";
            txt_TongCacSoMangA.Text = "";
            txt_TongSoChan.Text = "";
            txt_TongSoLe.Text = "";
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có thật sự muốn thoát hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_TinhToan_Click(object sender, EventArgs e)
        {
            int tongsole = 0, tongsochan = 0, tongso = 0;
            string[] A = txt_MangA.Text.Split(" ".ToCharArray());
            foreach (var item in A)
            {
                int sohientai = int.Parse(item);
                if (sohientai % 2 == 0)
                {
                    tongsochan += sohientai;
                }
                else
                {
                    tongsole += sohientai;
                }
                tongso += sohientai;
            }
            txt_TongSoLe.Text = tongsole.ToString();
            txt_TongSoChan.Text = tongsochan.ToString();
            txt_TongCacSoMangA.Text = tongso.ToString();
        }
    }
}
