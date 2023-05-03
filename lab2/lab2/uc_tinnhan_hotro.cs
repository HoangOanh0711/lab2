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
    public partial class uc_tinnhan_hotro : UserControl
    {
        public uc_tinnhan_hotro()
        {
            InitializeComponent();
        }

        public string textHoTro { get => uc_tinnhan_text1.Text; set => uc_tinnhan_text1.Text = value; }
    }
}
