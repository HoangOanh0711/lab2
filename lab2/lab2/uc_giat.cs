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
    public partial class uc_giat : UserControl
    {
        public uc_giat()
        {
            InitializeComponent();
        }

        private void anh_giat_1_Click(object sender, EventArgs e)
        {

        }

        private void radio_giat_1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_giat_1.Checked == true) { count = 1; }
        }

        private int count;

        private void radio_giat_2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_giat_2.Checked == true) { count = 2; }
        }

        private void radio_giat_3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_giat_3.Checked == true) { count = 3; }
        }

        private void radio_giat_4_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_giat_4.Checked == true) { count = 4; }
        }

        private void radio_giat_5_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_giat_5.Checked == true) { count = 5; }
        }

        public int Count { get => count; set => count = value; }
    }
}
