using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class Order : MakeOrder
    {
        public string client { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        public int price { get; set; }
        public Order() { }
        public Order(string client, string name, int id, int price)
        {
            this.client = client;
            this.name = name;
            this.id = id;
            this.price = price;
        }
    }
}
