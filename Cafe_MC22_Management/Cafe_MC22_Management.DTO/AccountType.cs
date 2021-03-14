using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_MC22_Management.DTO
{
     public class AccountType
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public AccountType() { }

        public AccountType(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public AccountType(DataRow row)
        {
            ID = (int)row["id"];
            Name = row["name"].ToString();
        }
    }
}
