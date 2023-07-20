using Cf_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set => MenuDAO.instance = value; }

        private MenuDAO() { }

        public List<menu> GetListMenuTable(int id)
        {
            List <menu> ListMenu = new List<menu>();

            string query = "SELECT Food.Name, BillInfo.count, Food.price, BillInfo.count*Food.price AS totalprice  FROM BillInfo, Food, Bill WHERE BillInfo.IdFood = Food.ID AND BillInfo.IdBill = Food.ID AND  Bill.status =0 AND  Bill.IdTable = " + id;
            DataTable MenuList = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in MenuList.Rows)
            {
                menu Menu = new menu(item);
                ListMenu.Add(Menu);
                
            }
            return ListMenu;
        }
    }


}
