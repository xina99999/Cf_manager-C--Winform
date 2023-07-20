using Cf_manager.DTO;
using Cf_manager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cf_manager.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }   

        private TableDAO() { }

        public static int table_wight = 100;
        public static int table_height = 100;
            
           
        

        public  List<TableDTO> LoadTableList()
        {
            List<TableDTO> tablelist = new List<TableDTO>();

           
            DataTable  data =  DataProvider.Instance.ExcuteQuery("EXEC USP_GetTableList");
            foreach( DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tablelist.Add(table);

            }
          
            return tablelist;
        }
    }
}
