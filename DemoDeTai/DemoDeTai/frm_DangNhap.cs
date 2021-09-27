using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDeTai
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var user = txt_user.Text;
            var pass = txt_pass.Text;
            if ( user.CompareTo("")== 0 && pass.CompareTo("")==0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lb_tb.Text = " Sai tên đăng nhập hoặc mật khẩu";
            }
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
