using Cf_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        { get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
          set => instance  = value; }

        private BillDAO() { }

        public int GetUncheckBillByTableID(int id)
        {
            DataTable TableList = DataProvider.Instance.ExcuteQuery("select * from bill where idTable = "  + id  +" and status = 0");

            if(TableList.Rows.Count>0)
            {
                Bill bill = new Bill(TableList.Rows[0]);
                return bill.ID;
            }
            return -1;
           
        }
    }
}
