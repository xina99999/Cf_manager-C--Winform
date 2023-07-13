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
    public partial class Manhinh : Form
    {
        public Manhinh()
        {
            InitializeComponent();
        }

        private void thôngTinTàiKhoảngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.ShowDialog();

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void tạoMớiTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangky dangky = new Dangky();
            dangky.ShowDialog();
        }
    }
}
