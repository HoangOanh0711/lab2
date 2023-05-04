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
        public TinNhan()
        {
            InitializeComponent();
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
            ThemTinNhanNgDung("Xin chào");
            ThemTinNhanHoTro("Cảm ơn anh/chị đã liên hệ đến trung tâm hỗ trợ, em là Bông - Sẵn sàng hỗ trợ anh/chị ạ.");
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
                case "123": ThemTinNhanHoTro("chào123"); break;
            }
            text_input.Clear();

        }
    }
}
