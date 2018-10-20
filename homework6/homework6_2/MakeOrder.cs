using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6_2
{
    public class MakeOrder
    {
        string type;
        public void creatOrder()
        {
            Console.WriteLine("1:添加订单\n2:删除订单\n3:修改订单\n4:查询订单\n其他:退出");
            type = Console.ReadLine();
            if (type == "1")
            {
                addOrder2();
            }
            else if (type == "2")
            {
                deleteOrder();
            }
            else if (type == "3")
            {
                changeOrder();
            }
            else if (type == "4")
            {
                searchOrder2();
            }
            else
            {
                Console.WriteLine("您已退出！\n");
            }
        }
        public virtual void addOrder()
        {
        }
        public virtual void addOrder2()
        {
        }
        public virtual void deleteOrder()
        {
        }
        public virtual void changeOrder()
        {
        }
        public virtual void searchOrder()
        {
        }
        public virtual void searchOrder2()
        {
        }
    }
}
