using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DTO
{
     public class TableDTO
    {
        public TableDTO(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public TableDTO(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();

            
        }

        private int iD;
        public int ID { get { return iD; } set => iD = value; }
        
        private string status;
        public string Status { get { return status; } set => status = value; }

        private string name;
        public string Name { get { return name; } set => name = value; 
    }
}
    }
