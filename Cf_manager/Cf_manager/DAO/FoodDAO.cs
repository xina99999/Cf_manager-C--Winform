using Cf_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance 
        { get { if (instance == null) instance =  new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; } 
        }

        private FoodDAO() { }

        public List<Food> GetListFoodDAO(int id)
        {
            List<Food> listfood = new List<Food>();
            string query = "SELECT * FROM Food where IDCategory = " + id;
            DataTable tablelist = DataProvider.Instance.ExcuteQuery(query);
            foreach ( DataRow item in tablelist.Rows)
            {
                Food food = new Food(item);
                listfood.Add(food);
                
            }
            return listfood;
        }
    }
}
