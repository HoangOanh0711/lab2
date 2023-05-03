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
    public partial class LichSuMuaHang : Form
    {
        public LichSuMuaHang()
        {
            InitializeComponent();
        }

        private void LichSuMuaHang_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("Dịch vụ", typeof(string));
            dt.Columns.Add("Lựa chọn", typeof(string));
            dt.Columns.Add("Thành tiền", typeof(double));
            dt.Columns.Add("Ngày đặt", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            dt.Columns.Add("Đánh giá", typeof(string));

            dt.Rows.Add("1", "Nấu ăn", "5 món", 300.000, "08/08/2020", "Hoàn thành", "10/08/2020");
            dt.Rows.Add("2", "Nấu ăn", "5 món", 300.000, "08/08/2020", "Hoàn thành", "10/08/2020");
            dt.Rows.Add("3", "Nấu ăn", "5 món", 300.000, "08/08/2020", "Hoàn thành", "10/08/2020");
            dt.Rows.Add("4", "Nấu ăn", "5 món", 300.000, "08/08/2020", "Hoàn thành", "10/08/2020");
            dt.Rows.Add("5", "Nấu ăn", "5 món", 300.000, "08/08/2020", "Hoàn thành", "10/08/2020");
            dt.Rows.Add("6", "Nấu ăn", "5 món", 300.000, "08/08/2020", "Hoàn thành", "10/08/2020");
            dt.Rows.Add("7", "Nấu ăn", "5 món", 300.000, "08/08/2020", "Hoàn thành", "10/08/2020");

            dtg_lich_su.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
