using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class OrderDetails : MakeOrder
    {
        public List<String> orderList = new List<String>();
        public List<Order> orderObject = new List<Order>();
        public void showOrder()
        {
            foreach (String s in orderList)
            {
                Console.WriteLine(s);
            }
        }
        public void showOrder2(Order order)
        {
            Console.WriteLine("客户：" + order.client);
            Console.WriteLine("商品名：" + order.name);
            Console.WriteLine("订单号：" + order.id);
            Console.WriteLine("价格：" + order.price);
        }
    }
}
