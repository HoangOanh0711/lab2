using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace lab2
{
    public partial class uc_dichvu : UserControl
    {
        public uc_dichvu()
        {
            InitializeComponent();
        }

        private void uc_dichvu_Load(object sender, EventArgs e)
        {
            uc_nau_an uc_Nau_An = new uc_nau_an();
            addUserControl(uc_Nau_An);
            btn_cook.Checked = true;
            btn_clean.Checked = false;
            btn_launchdry.Checked = false;
        }

        public void ThemDichVu(string anh, string ten, double gia)
        {
            panelControl.Controls.Add(new uc_item()
            {
                tenAnh = anh,
                anhDichVu = Image.FromFile("G:\\Oanhhh\\c#\\lab2-git\\lab2\\lab2\\Resources\\" + anh + ".jpg"),
                tenDichVu = ten,
                giaDichVu = gia,
            });
        }

        private void addUserControl(UserControl userControl)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            uc_don_dep uc_Don_Dep = new uc_don_dep();
            addUserControl(uc_Don_Dep);
            btn_cook.Checked = false;
            btn_clean.Checked = true;
            btn_launchdry.Checked = false;
        }

        private void btn_cook_Click(object sender, EventArgs e)
        {
            uc_nau_an uc_Nau_An = new uc_nau_an();
            addUserControl(uc_Nau_An);
            btn_cook.Checked = true;
            btn_clean.Checked = false;
            btn_launchdry.Checked = false;
        }

        private void btn_launchdry_Click(object sender, EventArgs e)
        {
            uc_giat uc_Giat = new uc_giat();
            addUserControl(uc_Giat);
            btn_cook.Checked = false;
            btn_clean.Checked = false;
            btn_launchdry.Checked = true;
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_giohang_Click(object sender, EventArgs e)
        {
            GioHang gioHang = new GioHang();
            gioHang.ShowDialog();

        }
    }
}
