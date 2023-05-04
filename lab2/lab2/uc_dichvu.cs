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
        uc_don_dep uc_Don_Dep;
        uc_nau_an uc_Nau_An;
        uc_giat uc_Giat;
        private void uc_dichvu_Load(object sender, EventArgs e)
        {

            uc_Don_Dep = new uc_don_dep();
            panelControl.Controls.Add(uc_Don_Dep);

            uc_Giat = new uc_giat();
            panelControl.Controls.Add(uc_Giat);

            uc_Nau_An = new uc_nau_an();
            panelControl.Controls.Add(uc_Nau_An);



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
            /*panelControl.Controls.Clear();*/
            /*panelControl.Controls.Add(userControl);*/
            userControl.BringToFront();
            /* userControl.Show();*/
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {

            addUserControl(uc_Don_Dep);
            btn_cook.Checked = false;
            btn_clean.Checked = true;
            btn_launchdry.Checked = false;


        }

        private void btn_cook_Click(object sender, EventArgs e)
        {
            addUserControl(uc_Nau_An);
            btn_cook.Checked = true;
            btn_clean.Checked = false;
            btn_launchdry.Checked = false;
        }

        private void btn_launchdry_Click(object sender, EventArgs e)
        {

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
            GioHang gioHang = new GioHang(uc_Don_Dep.Count, uc_Giat.Count, uc_Nau_An.Count);
            gioHang.ShowDialog();

        }
    }
}
