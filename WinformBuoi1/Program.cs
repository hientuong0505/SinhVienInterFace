using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBuoi1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_DANGNHAP());
            //Application.Run(new frm_NhapMang());
            //Application.Run(new frm_QLSinhVien());
            //Application.Run(new frm_GiaiPTBac2());
            //Application.Run(new frm_TIMTHU());
        }
    }
}
