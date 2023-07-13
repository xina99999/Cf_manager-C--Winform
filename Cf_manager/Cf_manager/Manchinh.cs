using Cf_manager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cf_manager
{
    public partial class btn_exit : Form
    {
        public btn_exit()
        {
            InitializeComponent();
        }

        private void BtnDN_Click(object sender, EventArgs e)
        {
            string UserName = txtUser_name.Text;
            string PassWord = txtPass.Text;
           if(Login(UserName,PassWord))
            {
                Manhinh manhinh = new Manhinh();
                
                this.Hide();
                manhinh.ShowDialog();
                this.Show();

            }
           else
            {
                MessageBox.Show("Tài khoản không hợp lệ ");
            }
        }

        bool Login(string UserName,string Password)
        {
            return AccountDAO.Instance.Login(UserName,Password);
        }

        private void Manchinh_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("c:LOGO.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
