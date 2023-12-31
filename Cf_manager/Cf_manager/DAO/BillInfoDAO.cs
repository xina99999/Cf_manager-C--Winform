﻿using Cf_manager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance 
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance;}
             private set => instance = value;
        }

        private BillInfoDAO() { }

        public List<BillInfo> GetListInfo(int id )
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable TableList = DataProvider.Instance.ExcuteQuery("SELECT * FROM BillInfo WHERE idBill = " + id );

            foreach(DataRow item  in TableList.Rows )
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
    }
}
