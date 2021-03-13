using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_MC22_Management.DTO
{
    public class BillInfo
    {
        public int ID { get; private set; }
        public int IDBill { get; private set; }
        public int IDFood { get; private set; }
        public int Count { get; private set; }

        public BillInfo() { }

        public BillInfo(int id, int idBill, int idFood, int count)
        {
            ID = id;
            IDBill = idBill;
            IDFood = idFood;
            Count = count;
        }
        public BillInfo(DataRow row)
        {
            ID = (int)row["id"];
            IDBill = (int)row["idBill"];
            IDFood = (int)row["idFood"];
            Count = (int)row["count"];
        }

    }
}
