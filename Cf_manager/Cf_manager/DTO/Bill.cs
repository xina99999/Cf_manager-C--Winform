using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? datecheckin , DateTime? datecheckout, int status)
        {
            this.ID = id;
            this.dateCheckIn = datecheckin;
            this.dateCheckOut = datecheckout;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.dateCheckIn = (DateTime?)row["DateCheckIn"];
            var datecheckouttemp = row["DateCheckOut"];
            if (datecheckouttemp.ToString() != "")
            {
                this.dateCheckOut = (DateTime?)row["DateCheckOut"];
            }
            this.Status = (int)row["status"] ;
        }

        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;


        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
    }
}
