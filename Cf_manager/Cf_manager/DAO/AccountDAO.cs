using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf_manager.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public  static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO()
        {

        }

        public bool Login(string UserName, string Password) 
        {

            string query = "Select * from Account where UserName = N'" + UserName + "' AND PassWord = N'"+ Password +"'";
            DataTable login = DataProvider.Instance.ExcuteQuery(query);
            return login.Rows.Count>0; 
        }
        
    }
}
