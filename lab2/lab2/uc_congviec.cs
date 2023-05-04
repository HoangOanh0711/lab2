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
    public partial class uc_congviec : UserControl
    {
        public uc_congviec()
        {
            InitializeComponent();
        }

        public uc_congviec(string ten, double gia, string anh)
        {
            InitializeComponent();
            Ten = ten;
            Gia = gia;
            Gia2 = gia;
            Anh = Image.FromFile("Resources/" + anh + ".jpg");
        }

        public string Ten { get => ten_dvu.Text; set => ten_dvu.Text = value; }
        public double Gia { get => Convert.ToDouble(gia_dvu.Text); set => gia_dvu.Text = value.ToString("0.000"); }
        public double Gia2 { get => Convert.ToDouble(label1.Text); set => label1.Text = value.ToString("0.000"); }
        public Image Anh { get => anh_dvu.BackgroundImage; set => anh_dvu.BackgroundImage = value; }
    }
}
