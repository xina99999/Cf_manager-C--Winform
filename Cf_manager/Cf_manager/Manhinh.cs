using Cf_manager.DAO;
using Cf_manager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            LoadTable();
            LoadCategory();

        }

        #region Methon
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            comboBox1.DataSource = listCategory;
            comboBox1.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listfood = FoodDAO.Instance.GetListFoodDAO(id);
            cbFood.DataSource = listfood;
            cbFood.DisplayMember = "Name";
        }

        void LoadTable()
        {
            List<TableDTO> tableList = TableDAO.Instance.LoadTableList();

            foreach (TableDTO item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.table_wight, Height = TableDAO.table_height };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                flowLayoutPanel1.Controls.Add(btn);

                switch(item.Status)
                {
                    case "NO":
                        btn.BackColor = Color.Blue;
                        break;
                    default:
                        btn.BackColor = Color.White;
                        break;
                }

                btn.Click += Btn_Click;
                btn.Tag = item;



            }
        }

        void ShowBill(int id)
        {
            listView1.Items.Clear();
            List<menu> listMenu = MenuDAO.Instance.GetListMenuTable(id);
            float TongTien = 0;
            foreach(menu item in listMenu)
            {
                ListViewItem lstView = new ListViewItem(item.FoodName.ToString());

                lstView.SubItems.Add(item.Count.ToString());
                lstView.SubItems.Add(item.Price.ToString());
                
                lstView.SubItems.Add(item.TotalPrice.ToString());
                TongTien += item.TotalPrice;
                listView1.Items.Add(lstView);
                
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            
            txtTongtien.Text = TongTien.ToString("c",culture);
        }

        #endregion



        #region Event
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableDTO).ID;
            listView1.Tag = (sender as Button).Tag;

           ShowBill(tableID);
           
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

        private void Manhinh_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cbCategoryChangeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb != null && cb.SelectedItem != null)
            {
                Category selected = cb.SelectedItem as Category;
                if (selected != null)
                {
                    id = selected.ID;
                }
            }
            else return;
            LoadFoodListByCategoryID(id);
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
