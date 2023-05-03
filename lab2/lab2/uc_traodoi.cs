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
    public partial class uc_traodoi : UserControl
    {
        public uc_traodoi()
        {
            InitializeComponent();
        }

        private void tk_avatartk_Click(object sender, EventArgs e)
        {
            TinNhan tinNhan = new TinNhan();
            tinNhan.ShowDialog();
        }
    }
}
