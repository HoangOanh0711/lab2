using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class GioHang : Form
    {
        private DataTable _dt;
        private string _username, _pass;
        public DataRow[] dataRow;
        double tong = 0;

        int giat;
        public int Giat { get => giat; set => giat = value; }

        int nauan;
        public int Nauan { get => nauan; set => nauan = value; }

        int dondep;
        public int Dondep { get => dondep; set => dondep = value; }

        public GioHang(int dondep, int giat, int nauan, DataTable dt, string username, string pass)
        {
            InitializeComponent();
            this.dondep = dondep;
            this.giat = giat;
            this.nauan = nauan;

            _dt = dt;
            _username = username;
            _pass = pass;

            string s = "pass= '" + _pass + "'and (phone = '" + _username + "' or email = '" + _username + "')";
            dataRow = _dt.Select(s);

            label6.Text = dataRow[0].ItemArray[0].ToString();
            label7.Text = dataRow[0].ItemArray[2].ToString();
            label8.Text = dataRow[0].ItemArray[3].ToString();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            switch (dondep)
            {
                case 1:

                    uc_congviec uc_Congviec1 = new uc_congviec("Dưới 50m2", 100.000, "6");
                    flowLayoutPanel1.Controls.Add(uc_Congviec1);
                    tong += 100.000;
                    break;
                case 2:
                    uc_congviec uc_Congviec2 = new uc_congviec("50m2 đến 100m2", 150.000, "7");
                    flowLayoutPanel1.Controls.Add(uc_Congviec2);
                    tong += 150.000;
                    break;
                case 3:
                    uc_congviec uc_Congviec3 = new uc_congviec("100m2 đến 200m2", 200.000, "8");
                    flowLayoutPanel1.Controls.Add(uc_Congviec3);
                    tong += 200.000;
                    break;
                case 4:
                    uc_congviec uc_Congviec4 = new uc_congviec("200m2 đến 300m2", 250.000, "9");
                    flowLayoutPanel1.Controls.Add(uc_Congviec4);
                    tong += 250.000;
                    break;
                case 5:
                    uc_congviec uc_Congviec5 = new uc_congviec("Trên 500m2", 300.000, "10");
                    flowLayoutPanel1.Controls.Add(uc_Congviec5);
                    tong += 300.000;
                    break;
            }

            switch (giat)
            {
                case 1:
                    uc_congviec uc_Congviec1 = new uc_congviec("Giặt hấp", 100.000, "22");
                    flowLayoutPanel1.Controls.Add(uc_Congviec1);
                    tong += 100.000;
                    break;
                case 2:
                    uc_congviec uc_Congviec2 = new uc_congviec("Giặt xấy", 150.000, "23");
                    flowLayoutPanel1.Controls.Add(uc_Congviec2);
                    tong += 150.000;
                    break;
                case 3:
                    uc_congviec uc_Congviec3 = new uc_congviec("Ủi", 80.000, "21");
                    flowLayoutPanel1.Controls.Add(uc_Congviec3);
                    tong += 80.000;
                    break;
                case 4:
                    uc_congviec uc_Congviec4 = new uc_congviec("Tẩy trắng", 130.000, "25");
                    flowLayoutPanel1.Controls.Add(uc_Congviec4);
                    tong += 130.000;
                    break;
                case 5:
                    uc_congviec uc_Congviec5 = new uc_congviec("Dịch vụ khác", 150.000, "24");
                    flowLayoutPanel1.Controls.Add(uc_Congviec5);
                    tong += 150.000;
                    break;

            }

            switch (nauan)
            {
                case 1:
                    uc_congviec uc_Congviec1 = new uc_congviec("2 món", 100.000, "11");
                    flowLayoutPanel1.Controls.Add(uc_Congviec1);
                    tong += 100.000;
                    break;
                case 2:
                    uc_congviec uc_Congviec2 = new uc_congviec("3 món", 150.000, "12");
                    flowLayoutPanel1.Controls.Add(uc_Congviec2);
                    tong += 150.000;
                    break;
                case 3:
                    uc_congviec uc_Congviec3 = new uc_congviec("4 món", 200.000, "13");
                    flowLayoutPanel1.Controls.Add(uc_Congviec3);
                    tong += 200.000;
                    break;
                case 4:
                    uc_congviec uc_Congviec4 = new uc_congviec("5 món", 250.000, "14");
                    flowLayoutPanel1.Controls.Add(uc_Congviec4);
                    tong += 250.000;
                    break;
                case 5:
                    uc_congviec uc_Congviec5 = new uc_congviec("6 món", 300.000, "15");
                    flowLayoutPanel1.Controls.Add(uc_Congviec5);
                    tong += 300.000;
                    break;
            }

            label13.Text = tong.ToString("0.000");
        }
    }
}
