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

        string username;
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

        public uc_trangchu(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void uc_trangchu_Load(object sender, EventArgs e)
        {
            lb_ten.Text = "Xin chào " + username +"!";
            img_slide.ImageLocation = string.Format(@"G:\Oanhhh\c#\lab2-git\lab2\lab2\Resources\" + ImageNumber + ".jpg");
        }


        private void guna2GradientPanel1_Paint(object sender, EventArgs e)
        {

        }

    }
}
