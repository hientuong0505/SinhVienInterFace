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
    public partial class frm_GiaiPTBac2 : Form
    {
        public frm_GiaiPTBac2()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_GIAI_Click(object sender, EventArgs e)
        {
            if (txt_HeSoA.Text != "" && txt_HeSoB.Text != "" && txt_HeSoC.Text != "")
            {
                float a, b, c;
                a = float.Parse(txt_HeSoA.Text);
                b = float.Parse(txt_HeSoB.Text);
                c = float.Parse(txt_HeSoC.Text);
                float delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    txt_KetQua.Text = "X1 = " + ((-b - Math.Sqrt(delta)) / 2 * a) + ", X2 = " + ((-b + Math.Sqrt(delta)) / 2 * a);
                }
                else if (delta == 0)
                {
                    txt_KetQua.Text = "X1 = X2 = " + (-b / 2 * a);
                }
                else if (delta < 0)
                {
                    txt_KetQua.Text = "Phương trình vô nghiệm";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ 3 hệ số!");
            }

        }

        private void btn_THOAT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
