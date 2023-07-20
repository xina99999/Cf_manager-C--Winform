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

            string query = "USP_login @UserName , @PassWord";
            DataTable login = DataProvider.Instance.ExcuteQuery(query, new object[]{ UserName, Password});
            return login.Rows.Count>0; 
        }
        
    }
}
