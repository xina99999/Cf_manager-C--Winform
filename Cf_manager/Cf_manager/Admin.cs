using Cf_manager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cf_manager
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        void LoadAccountList()
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            String sql = "Select * FROM Account";
            dtgvTk.DataSource = DataProvider.Instance.ExcuteQuery(sql);
        }
    }
}
