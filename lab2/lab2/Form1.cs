using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace lab2
{
    public partial class Form1 : Form
    {
        private DataTable _dt;
        private string _username, _pass;
        public DataRow[] dataRow;

        public Form1(DataTable dt, string username, string pass )
        {
            InitializeComponent();
            _dt = dt;
            _username = username;
            _pass = pass;
            //string s = "pass= '" + _pass + "'and (phone = '" + _username + "' or email = '" + _username + "')";
            //dataRow = _dt.Select( s );

            //fullname = dataRow[0].ItemArray[0].ToString();
            //email = dataRow[0].ItemArray[1].ToString();
            //phone = dataRow[0].ItemArray[2].ToString();
            //address = dataRow[0].ItemArray[3].ToString();
            //password = dataRow[0].ItemArray[4].ToString();

        }

        private void addUserControl(UserControl userControl)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc_trangchu uc_Trangchu = new uc_trangchu(_dt,_username,_pass);
            addUserControl(uc_Trangchu);
            btn_trangchu.Checked = true;
            btn_dichvu.Checked = false;
            btn_traodoi.Checked = false;
            btn_taikhoan.Checked = false;
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            uc_trangchu uc_Trangchu = new uc_trangchu(_dt, _username, _pass);
            addUserControl(uc_Trangchu);
            btn_trangchu.Checked = true;
            btn_dichvu.Checked = false;
            btn_traodoi.Checked = false;
            btn_taikhoan.Checked = false;

        }

        private void btn_dichvu_Click(object sender, EventArgs e)
        {
            uc_dichvu uc_Dichvu = new uc_dichvu(_dt, _username, _pass);
            addUserControl(uc_Dichvu);
            btn_trangchu.Checked = false;
            btn_dichvu.Checked = true;
            btn_traodoi.Checked = false;
            btn_taikhoan.Checked = false;
        }

        private void btn_traodoi_Click(object sender, EventArgs e)
        {
            uc_traodoi uc_Traodoi = new uc_traodoi();
            addUserControl(uc_Traodoi);
            btn_trangchu.Checked = false;
            btn_dichvu.Checked = false;
            btn_traodoi.Checked = true;
            btn_taikhoan.Checked = false;
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            uc_taikhoan uc_Taikhoan = new uc_taikhoan(_dt, _username, _pass);
            addUserControl(uc_Taikhoan);
            btn_trangchu.Checked = false;
            btn_dichvu.Checked = false;
            btn_traodoi.Checked = false;
            btn_taikhoan.Checked = true;
        }
    }
}