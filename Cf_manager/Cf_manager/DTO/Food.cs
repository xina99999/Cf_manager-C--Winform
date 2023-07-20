using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DTO
{
    public class Food
    {
        public Food(int id, string name , int idcategory , float price)
        {
            this.ID = id;
            this.Name = name;
            this.IDCategory = idcategory;
            this.Price = price;
            
        }

        public Food( DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.IDCategory = (int)row["IDCategory"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private int iD; 
        private string name;
        private int iDCategory;
        private float price;

        public int ID { get => iD; set => iD = value; }
        public int IDCategory { get => iDCategory; set => iDCategory = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
    }
}
