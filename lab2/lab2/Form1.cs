namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int ImageNumber = 1;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img_slide.ImageLocation = string.Format(@"G:\Oanhhh\c#\lab2-git\lab2\lab2\Resources\" + ImageNumber + ".jpg");
        }
    }
}