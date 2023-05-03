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
    public partial class DangNhap : Form
    {
        DataTable dt;
        public DangNhap()
        {
            InitializeComponent();
            LoadDataTable();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string user = tb_sdt.Text;
            string pass = tb_matkhau.Text;
            string s = "pass= '" + pass + "'and (phone = '" + user + "' or email = '" + user + "')";
            DataRow[] dr = dt.Select(s);
            if (dr.Length > 0)
            {
                if (cb_nhoTK.Checked == true)
                {
                    string st = "";
                    st = tb_sdt.Text;
                    WriteFile(st);
                }
                else
                {
                    WriteFile("");
                }
                this.Hide();
                Form1 form = new Form1(dt, user, pass);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ReadFileCurrent();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
            this.Close();
        }

        void LoadDataTable()
        {
            dt = new DataTable();

            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("email", typeof(string));
            dt.Columns.Add("phone", typeof(string));
            dt.Columns.Add("address", typeof(string));
            dt.Columns.Add("pass", typeof(string));
        }
        void WriteFile(string s)
        {
            string filename = "userCurrent.txt";
            StreamWriter writer = new StreamWriter(filename);
            writer.Write(s);
            writer.Close();
        }

        void ReadFileCurrent()
        {

            string filename = "userCurrent.txt";
            FileInfo fileInfo = new FileInfo(filename);
            if (fileInfo.Exists)
            {
                StreamReader reader = new StreamReader(filename);
                string str;
                while ((str = reader.ReadLine()) != null) { tb_sdt.Text = str; }
                reader.Close();
            }
        }

        void ReadFile()
        {
            string filename = "userData.txt";
            FileInfo fileInfo = new FileInfo(filename);
            if (fileInfo.Exists)
            {
                StreamReader reader = new StreamReader(filename);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] st = str.Split("\t");
                    dt.Rows.Add(st[0], st[1], st[2], st[3], st[4]);
                }
                reader.Close();
            }

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            ReadFile();
            ReadFileCurrent();
        }
    }
}
