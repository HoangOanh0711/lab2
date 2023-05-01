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
    public partial class uc_item : UserControl
    {
        public uc_item()
        {
            InitializeComponent();
        }

        private string tenanh;
        public string tenAnh { get => tenanh; set => tenanh = value; }

        public Image anhDichVu { get => pic_item.Image; set => pic_item.Image = value; }

        public string tenDichVu { get => radio_item.Text; set => radio_item.Text = value; }

        private double giatien;
        public double giaDichVu { get => giatien; set => giatien = value; }

    }
}
