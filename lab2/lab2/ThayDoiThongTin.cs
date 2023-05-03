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
    public partial class ThayDoiThongTin : Form
    {
        public ThayDoiThongTin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Close();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("userData.txt");
            string[][] data = lines.Select(line => line.Split('\t')).ToArray();
            string email = tb_email.Text;
            string phone = tb_soDT.Text;

            int index = Array.FindIndex(data,arr => arr[1] == email);

            if (index == -1)
            {
                data[index][0] = tb_hoTen.Text;
                data[index][4] = tb_matKhau.Text;

                string updateLine = string.Join("\t", data[index]);

                lines[index] = updateLine;
                File.WriteAllLines("userData.txt", lines);
                MessageBox.Show("Cập nhật thông tin người dùng thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng");

            }
        }
    }
}
