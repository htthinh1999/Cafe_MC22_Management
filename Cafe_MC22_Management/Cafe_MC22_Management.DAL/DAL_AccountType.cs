using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe_MC22_Management.DTO;

namespace Cafe_MC22_Management.DAL
{
    public class DAL_AccountType
    {
        static DAL_AccountType instance;
        public static DAL_AccountType Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_AccountType();
                }
                return instance;
            }
            private set { instance = value; }
        }

        public List<AccountType> LoadAccountTypeList()
        {
            List<AccountType> accountTypeList = new List<AccountType>();
            string query = "USP_LoadAccountTypeList";
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                accountTypeList.Add(new AccountType(row));
            }
            return accountTypeList;
        }
    }

}
