using Cf_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance 
        { get { if (instance == null) instance = new CategoryDAO() ; return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }
        public List<Category> GetListCategory()
        {
            List<Category> listCategory = new List<Category>();
            string query = "SELECT * FROM FoodCategory ";
            DataTable TableListCategory = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in TableListCategory.Rows)
            {
                Category category = new Category(item);
                listCategory.Add(category);
            }
            return listCategory;
        }

        

    }
}
