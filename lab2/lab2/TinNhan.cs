using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class TinNhan : Form
    {
        DataTable dt;
        public TinNhan()
        {
            InitializeComponent();
            LoadDataTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TinNhan_Load(object sender, EventArgs e)
        {
            ReadFile();
            ThemTinNhanNgDung("Xin chào");
            ThemTinNhanHoTro("Cảm ơn anh/chị đã liên hệ đến trung tâm hỗ trợ, em là Bông - Sẵn sàng hỗ trợ anh/chị ạ.");
            /*string s = "stt= " + 1;
            DataRow[] dr = dt.Select(s);
            text_input.Text = dr[0].ItemArray[2].ToString();

            if (dr[0].ItemArray[1].ToString().Equals("HoTro"))
            {
                ThemTinNhanHoTro(dr[0].ItemArray[2].ToString());
            }
            else if (dr[0].ItemArray[1].ToString() == "NgDung")
            {
                ThemTinNhanNgDung(dr[0].ItemArray[2].ToString());
            }*/

            /*int j = 0;
            for (; j <= 100;)
            {
                string s = "stt= " + j;
                DataRow[] dr = dt.Select(s);

                if (dr[0].ItemArray[1].ToString().Equals("HoTro"))
                {
                    ThemTinNhanHoTro(dr[0].ItemArray[2].ToString());
                }
                else if (dr[0].ItemArray[1].ToString() == "NgDung")
                {
                    ThemTinNhanNgDung(dr[0].ItemArray[2].ToString());
                }
                j += 1;
            }*/
            /*for (int i = 0; i < 100; i++)
            {
                string s = "stt= " + i;
                DataRow[] dr = dt.Select(s);

                if (dr[0].ItemArray[1].ToString() == "HoTro")
                {
                    ThemTinNhanHoTro(dr[0].ItemArray[2].ToString());
                }
                else if (dr[0].ItemArray[1].ToString() == "NgDung")
                {
                    ThemTinNhanNgDung(dr[0].ItemArray[2].ToString());
                }
            }*/
        }

        public void ThemTinNhanHoTro(String text)
        {
            controlPanel.Controls.Add(new uc_tinnhan_hotro()
            {
                textHoTro = text,
            });
        }

        public void ThemTinNhanNgDung(String text)
        {
            controlPanel.Controls.Add(new uc_tinnhan_ngdung()
            {
                textNgDung = text,
            });
        }

        private void send_Click(object sender, EventArgs e)
        {
            ThemTinNhanNgDung(text_input.Text);
            switch (text_input.Text)
            {
                case "liên hệ": ThemTinNhanHoTro("Email: giupviec@gmail.com \n Hotline: 0123456789"); break;
            }
            text_input.Clear();

        }

        void LuuTroChuyen()
        {

        }
        void LoadDataTable()
        {
            dt = new DataTable();

            dt.Columns.Add("stt", typeof(int));
            dt.Columns.Add("person", typeof(string));
            dt.Columns.Add("text", typeof(string));
        }

        void ReadFile()
        {
            string filename = "chatTuVan.txt";
            FileInfo fileInfo = new FileInfo(filename);
            if (fileInfo.Exists)
            {
                StreamReader reader = new StreamReader(filename);
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] st = str.Split("\t");
                    dt.Rows.Add(st[0], st[1], st[2]);
                }
                reader.Close();
            }

        }
    }
}
