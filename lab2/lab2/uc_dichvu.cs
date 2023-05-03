using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            btn_cook.Checked = true;
            btn_clean.Checked = false;
            btn_launchdry.Checked = false;
            DichVuNauAn();
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

        public void DichVuNauAn()
        {
            panelControl.Controls.Clear();
            ThemDichVu("11", "2 món", 150.000);
            ThemDichVu("12", "3 món", 200.000);
            ThemDichVu("13", "4 món", 250.000);
            ThemDichVu("14", "4 món", 250.000);
            ThemDichVu("15", "3 món", 200.000);
            ThemDichVu("16", "4 món", 250.000);
            ThemDichVu("17", "4 món", 250.000);
            ThemDichVu("18", "4 món", 250.000);
            ThemDichVu("19", "4 món", 250.000);
            ThemDichVu("20", "5 món", 300.000);
        }

        public void DichVuDonDep()
        {
            panelControl.Controls.Clear();
            ThemDichVu("6", "dưới 50m2", 250.000);
            ThemDichVu("7", "50-100m2", 250.000);
            ThemDichVu("8", "100-200m2", 250.000);
            ThemDichVu("9", "200-500m2", 250.000);
            ThemDichVu("10", "trên 500m2", 300.000);
        }

        public void DichVuGiat()
        {
            panelControl.Controls.Clear();
            ThemDichVu("22", "Giặt hấp", 200.000);
            ThemDichVu("24", "Giặt sấy", 250.000);
            ThemDichVu("21", "Ủi quần ảo", 150.000);
            ThemDichVu("25", "Tẩy trắng quần áo", 200.000);
            ThemDichVu("23", "Dịch vụ khác", 250.000);
        }
        private void btn_clean_Click(object sender, EventArgs e)
        {
            btn_cook.Checked = false;
            btn_clean.Checked = true;
            btn_launchdry.Checked = false;
            DichVuDonDep();
        }

        private void btn_cook_Click(object sender, EventArgs e)
        {
            btn_cook.Checked = true;
            btn_clean.Checked = false;
            btn_launchdry.Checked = false;
            DichVuNauAn();
        }

        private void btn_launchdry_Click(object sender, EventArgs e)
        {
            btn_cook.Checked = false;
            btn_clean.Checked = false;
            btn_launchdry.Checked = true;
            DichVuGiat();
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
