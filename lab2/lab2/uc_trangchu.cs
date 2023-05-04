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
    public partial class uc_trangchu : UserControl
    {

        public int ImageNumber = 1;

        private DataTable _dt;
        private string _username, _pass;
        public DataRow[] dataRow;
        private void LoadNextImages()
        {
            timer1.Start();
            ImageNumber++;
            if (ImageNumber == 1)
            {
                ImageNumber = 1;
            }
            img_slide.ImageLocation = string.Format(@"G:\Oanhhh\c#\lab2-git\lab2\lab2\Resources\" + ImageNumber + ".jpg");
        }

        public uc_trangchu(DataTable dt, string username, string pass)
        {
            InitializeComponent();
            _dt = dt;
            _username = username;
            _pass = pass;
            string s = "pass= '" + _pass + "'and (phone = '" + _username + "' or email = '" + _username + "')";
            dataRow = _dt.Select( s );
            lb_ten.Text = "Xin chào " + dataRow[0].ItemArray[0].ToString() + "!";
            label2.Text = dataRow[0].ItemArray[3].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void uc_trangchu_Load(object sender, EventArgs e)
        {
            img_slide.ImageLocation = string.Format(@"G:\Oanhhh\c#\lab2-git\lab2\lab2\Resources\" + ImageNumber + ".jpg");
        }


        private void guna2GradientPanel1_Paint(object sender, EventArgs e)
        {

        }

    }
}
