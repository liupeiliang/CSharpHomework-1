﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class Order
    {
        public string client { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public int price { get; set; }
        public Order(string client, string name, string id, int price)
        {
            this.client = client;
            this.name = name;
            this.id = id;
            this.price = price;
        }
        public Order() { }
    }
}
