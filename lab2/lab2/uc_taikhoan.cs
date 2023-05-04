using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace lab2
{
    public partial class uc_taikhoan : UserControl
    {
        private DataTable _dt;
        private string _username, _pass;
        public DataRow[] dataRow;
        public event EventHandler Click;

        public uc_taikhoan(DataTable dt, string username, string pass)
        {
            InitializeComponent();
            _dt = dt;
            _username = username;
            _pass = pass;

            string s = "pass= '" + _pass + "'and (phone = '" + _username + "' or email = '" + _username + "')";
            dataRow = _dt.Select( s );

            tk_tentk.Text = dataRow[0].ItemArray[0].ToString();
            //email = dataRow[0].ItemArray[1].ToString();
            //phone = dataRow[0].ItemArray[2].ToString();
            //address = dataRow[0].ItemArray[3].ToString();
            //password = dataRow[0].ItemArray[4].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.ParentForm?.Hide();
            Click?.Invoke(this, e);
            ThayDoiThongTin thayDoiThongTin = new ThayDoiThongTin(_dt,_username,_pass);
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
