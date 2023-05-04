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
    public partial class uc_don_dep : UserControl
    {
        public uc_don_dep()
        {
            InitializeComponent();

        }

        private void uc_don_dep_Load(object sender, EventArgs e)
        {

        }

        private void radio_don_1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_don_1.Checked == true) { count = 1; }
        }

        private int count;

        private void radio_don_2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_don_2.Checked == true) { count = 2; }
        }

        private void radio_don_3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_don_3.Checked == true) { count = 3; }
        }

        private void radio_don_4_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_don_4.Checked == true) { count = 4; }
        }

        private void radio_don_5_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_don_5.Checked == true) { count = 5; }
        }

        public int Count { get => count; set => count = value; }
    }
}
