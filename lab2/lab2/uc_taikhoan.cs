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
    public partial class uc_taikhoan : UserControl
    {
        public uc_taikhoan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ThayDoiThongTin thayDoiThongTin = new ThayDoiThongTin();
            thayDoiThongTin.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            LichSuMuaHang lichSuMuaHang = new LichSuMuaHang();
            lichSuMuaHang.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            thongKe.ShowDialog();
        }
    }
}
