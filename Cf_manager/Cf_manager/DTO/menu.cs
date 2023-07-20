using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DTO
{
    public class menu
    {
        public menu(string foodname, int count, float price , float totalPrice)
        {
            this.FoodName = foodname;
            this.Count = count;
            this.Price = price;
            this.totalPrice = totalPrice;
        }

        public menu(DataRow row)
        {
            this.FoodName = row["Name"].ToString();
            this.Count = (int)row["count"];
            this.Price =  (float)Convert.ToDouble(row["price"].ToString());
            this.totalPrice = (float)Convert.ToDouble(row["totalprice"].ToString());
        }

        private string foodName;
        public string FoodName { get => foodName; set => foodName = value; }


        private int count;
        public int Count { get => count; set => count = value; }


        private float price;
        private float totalPrice;

        

        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        
    }
}
