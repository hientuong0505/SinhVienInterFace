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
    public partial class frm_DANGNHAP : Form
    {
        int nhapsai = 0;
        public frm_DANGNHAP()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_DANGNHAP_Load(object sender, EventArgs e)
        {

        }

        private void btn_DANGNHAP_Click(object sender, EventArgs e)
        {
            
            if (txt_TAIKHOAN.Text.ToLower() =="admin" && txt_MATKHAU.Text.ToLower() == "123456")
            {
                var QLSinhVien = new frm_QLSinhVien();
                QLSinhVien.Show();
                this.Hide();
                //frm_Main main = new frm_Main();
                //main.Show();
                //MessageBox.Show("Đăng nhập thanh công");
            } else
            {
                nhapsai++;
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu" + nhapsai.ToString() + " lần!");
                if (nhapsai >= 3)
                {
                    Application.Exit();
                }
            }
        }

        private void btn_NHAPLAI_Click(object sender, EventArgs e)
        {
            txt_TAIKHOAN.Text = "";
            txt_MATKHAU.Text = "";
        }

        private void btn_THOAT_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có thật sự muốn thoát hay không","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
