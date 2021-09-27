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
    public partial class frm_GiaoDien : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public frm_GiaoDien()
        {
            InitializeComponent();
            random = new Random();
        }
        // Thiết kế
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Bernard MT Condensed", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pn_title.BackColor = color;
                    pn_Logo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);

                }
            }

        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pn_Menu.Controls)
            {
                if (previousBtn.GetType()== typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 117, 214);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pn_GiaoDien.Controls.Add(childForm);
            this.pn_GiaoDien.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        //Xử lý các chức năng
        private void frm_GiaoDien_Load(object sender, EventArgs e)
        {
            frm_DangNhap login = new frm_DangNhap();
            if(login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }

        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formss.frm_trangchu(), sender);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formss.frm_sanpham(), sender);
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formss.frm_hoadon(), sender);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formss.frm_thongke(), sender);
        }

        private void btn_doitra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formss.frm_doitra(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
