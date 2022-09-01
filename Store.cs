using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUke4Marija
{
    internal class Store
    {
        public string StoreName { get; set; }

        public string StoreType { get; set; }
        public List<Employee> Employees { get; set; }
        
        public List<Item> Items { get; set; }

        public Store(string name, string storeType)
        {
            StoreName = name;
            StoreType = storeType;
            Employees = new List<Employee>();
            Items = new List<Item>();

        }

    }
}
