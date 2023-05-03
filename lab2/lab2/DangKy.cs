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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            if (tb_email.Text == "" || tb_hoTen.Text == "" || tb_matKhau.Text == "" || tb_nhapLaiMatKhau.Text == "" || tb_soDT.Text == "" || tb_diaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (tb_matKhau.Text == tb_nhapLaiMatKhau.Text)
                {
                    string filepath = "userData.txt";
                    FileStream fs = new FileStream(filepath, FileMode.Append);
                    StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
                    writer.WriteLine(tb_hoTen.Text + "\t" + tb_email.Text + "\t" + tb_soDT.Text + "\t" + tb_diaChi.Text + "\t" + tb_matKhau.Text);
                    writer.Close();

                    MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


    }
}
