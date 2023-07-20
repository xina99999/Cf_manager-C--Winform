using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cf_manager
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=cf_manager;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtUserName.Text;
                string mk = txtPass.Text;
                string mka = txtPassToo.Text;
                string name = txtName.Text;
                string pass = txtPass.Text;
                string Chuc_vu = txtChuc.Text;

                //nhap lai mk

                if (mk.Length < 6)
                {
                    MessageBox.Show("Mật khẩu quá ngắn vui lòng nhập lại");
                }
                else if (tk != null && mk == mka)
                {

                    SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Account WHERE (UserName = @UserName)", conn);
                    check_User_Name.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    int UserExist = (int)check_User_Name.ExecuteScalar();
                    if (UserExist > 0)
                    { 
                        MessageBox.Show("Tài khoản không hợp lệ");

                    }
                    else
                    {

                        conn.Open();
                        string query = "INSERT INTO Account (Name, UserName, Password, chuc) VALUES ('" + name + "', '" + tk + "','" + pass + "', '" + Chuc_vu + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader dta = cmd.ExecuteReader();
                        MessageBox.Show("ban da tao tai khoan  thanh cong");
                    }
                }

            }
            catch (Exception  ex)
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }
    }
}
