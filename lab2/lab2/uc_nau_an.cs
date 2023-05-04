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
    public partial class uc_nau_an : UserControl
    {
        public uc_nau_an()
        {
            InitializeComponent();
        }

        private void radio_nau_1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nau_1.Checked == true) { count = 1; }
        }

        private int count;

        private void radio_nau_2_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nau_2.Checked == true) { count = 2; }
        }

        private void radio_nau_3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nau_3.Checked == true) { count = 3; }
        }

        private void radio_nau_4_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nau_4.Checked == true) { count = 4; }
        }

        private void radio_nau_5_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nau_5.Checked == true) { count = 5; }
        }

        public int Count { get => count; set => count = value; }
    }
}
