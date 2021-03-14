using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_MC22_Management.DTO
{
    public class State
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public State() { }

        public State(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public State(DataRow row)
        {
            ID = (int)row["id"];
            Name = row["name"].ToString();
        }
    }
}
