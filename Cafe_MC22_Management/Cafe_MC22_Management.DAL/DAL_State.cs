using Cafe_MC22_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_MC22_Management.DAL
{
    public class DAL_State
    {
        static DAL_State instance;
        public static DAL_State Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_State();
                }
                return instance;
            }
            private set { instance = value; }
        }

        public List<State> LoadStateList()
        {
            List<State> accountTypeList = new List<State>();
            string query = "USP_LoadStateList";
            DataTable dataTable = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in dataTable.Rows)
            {
                accountTypeList.Add(new State(row));
            }
            return accountTypeList;
        }
    }
}
