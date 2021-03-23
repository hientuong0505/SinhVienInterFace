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
    public partial class frm_TIMTHU : Form
    {
        public frm_TIMTHU()
        {
            InitializeComponent();
        }

        private void btn_TIM_Click(object sender, EventArgs e)
        {
            int thu;
            thu = int.Parse(txt_THU.Text);
            switch (thu)
            {
                case 2: MessageBox.Show("Thứ 2"); break;
                case 3: MessageBox.Show("Thứ 3"); break;
                case 4: MessageBox.Show("Thứ 4"); break;
                case 5: MessageBox.Show("Thứ 5"); break;
                case 6: MessageBox.Show("Thứ 6"); break;
                case 7: MessageBox.Show("Thứ 7"); break;
                case 8: MessageBox.Show("Chủ Nhật"); break;
                default: MessageBox.Show("Bạn đã nhập sai!!!!"); break;
            }
        }

        private void txt_THU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
