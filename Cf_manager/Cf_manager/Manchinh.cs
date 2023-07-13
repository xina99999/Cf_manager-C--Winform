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
            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=cf_manager;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtUser_name.Text;
                string mk = txtPass.Text;
                string sql = "select *from Account where UserName='" + tk + "' and Password='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công");
                    Manhinh manhinh = new Manhinh();
                    manhinh.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    txtUser_name.Clear();
                    txtPass.Clear();
                    MessageBox.Show("Tài khoảng không hợp lệ");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi ket noi");
            }
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
    }
}
