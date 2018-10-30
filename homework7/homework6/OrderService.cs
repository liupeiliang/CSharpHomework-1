using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace homework6
{
    public class OrderService
    {
        public BindingList<Order> orderObject = new BindingList<Order>();
        public void addOrder(string client, string name, int id, int price)
        {
            orderObject.Add(new Order(client, name, id, price));
        }
        public void deleteOrder(int id)
        {
            Order order = new Order("", "", 0, 0);
            foreach (Order e in orderObject)
            {
                if (e.id == id)
                {
                    order = e;
                }
            }
            orderObject.Remove(order);
        }
        public void changeOrder(int id, string newClient, string newName, int newId, int newPrice)
        {
            Order order = new Order("", "", 0, 0);
            foreach (Order e in orderObject)
            {
                if (e.id == id)
                {
                    order = e;
                }
            }
            orderObject.Remove(order);
            orderObject.Add(new Order(newClient, newName, newId, newPrice));
        }
        public Order searchOrder(int id)
        {
            Order order = new Order("", "", 0, 0);
            foreach(Order e in orderObject)
            {
                if(e.id == id)
                {
                    order = e;
                }
            }
            return order;
        }
    }
}
