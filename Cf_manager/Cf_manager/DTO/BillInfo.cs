using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DTO
{
    public class BillInfo
    {
        public BillInfo(int id , int idbill, int idfood, int count)
        {
            this.ID = id;
            this.IdBill = idbill;
            this.IdFood = idFood;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IdBill = (int)row["IdBill"];
            this.IdFood = (int)row["IdFood"];
            this.Count = (int)row["count"];
        }

        private int iD;
        private int idBill;
        private int idFood;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
