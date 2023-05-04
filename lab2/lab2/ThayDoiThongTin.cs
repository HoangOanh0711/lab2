using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ThayDoiThongTin : Form
    {
        private DataTable _dt;
        private string _username, _pass;
        public DataRow[] dataRow;

        public event EventHandler Click;

        public ThayDoiThongTin(DataTable dt, string username, string pass)
        {
            InitializeComponent();
            _dt = dt;
            _username = username;
            _pass = pass;

            string s = "pass= '" + _pass + "'and (phone = '" + _username + "' or email = '" + _username + "')";
            dataRow = _dt.Select(s);

            tb_hoTen.Text = dataRow[0].ItemArray[0].ToString();
            tb_email.Text = dataRow[0].ItemArray[1].ToString();
            tb_soDT.Text = dataRow[0].ItemArray[2].ToString();
            tb_diaChi.Text = dataRow[0].ItemArray[3].ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 form = new Form1(_dt, _username, _pass);
            form.ShowDialog();
            this.Close();
        }
        //chatTuVan.txt
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("userData.txt");
            string[][] data = lines.Select(line => line.Split('\t')).ToArray();
            string email = tb_email.Text;
            string phone = tb_soDT.Text;

            int index = Array.FindIndex(data, arr => arr[1] == email);

            if (index != -1)
            {
                data[index][0] = tb_hoTen.Text;
                data[index][3] = tb_diaChi.Text;

                if (tb_matKhau.Text != "")
                {
                    data[index][4] = tb_matKhau.Text;
                } else
                {
                    data[index][4] = _pass;
                }
                

                string updateLine = string.Join("\t", data[index]);

                lines[index] = updateLine;
                File.WriteAllLines("userData.txt", lines);
                MessageBox.Show("Cập nhật thông tin người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng");

            }

        }
    }
}
