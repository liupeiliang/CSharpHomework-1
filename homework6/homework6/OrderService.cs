using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace homework6
{
    public class OrderService : OrderDetails
    {
        public override void addOrder()
        {
            string order;
            Console.WriteLine("输入姓名：");
            order = Console.ReadLine();
            order += "-";
            Console.WriteLine("输入商品名：");
            order += Console.ReadLine();
            order += "-";
            Console.WriteLine("输入订单号：");
            order += Console.ReadLine();
            orderList.Add(order);
            Console.WriteLine("添加成功");
            showOrder();
            creatOrder();
        }
        public override void addOrder2()
        {
            Order order = new Order("", "", 0, 0);
            Console.WriteLine("输入姓名：");
            order.client = Console.ReadLine();
            Console.WriteLine("输入商品名：");
            order.name = Console.ReadLine();
            Console.WriteLine("输入订单号：");
            order.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输入价格：");
            order.price = Convert.ToInt32(Console.ReadLine());
            orderObject.Add(order);
            Console.WriteLine("添加成功");
            creatOrder();
        }
        public override void deleteOrder()
        {
            String orderNum;
            Console.WriteLine("输入订单号：");
            orderNum = Console.ReadLine();
            foreach (String s in orderList)
            {
                try
                {
                    int position = s.LastIndexOf("-");
                    string subString = s.Substring(position + 1, 3);
                    if (subString == orderNum)
                    {
                        orderList.Remove(s);
                        Console.WriteLine("删除完成");
                        break;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("删除失败");
                }

            }
            showOrder();
            creatOrder();
        }
        public override void changeOrder()
        {
            String orderNum;
            Console.WriteLine("输入订单号：");
            orderNum = Console.ReadLine();
            foreach (String s in orderList)
            {
                try
                {
                    int position = s.LastIndexOf("-");
                    string subString = s.Substring(position + 1, 3);
                    if (subString == orderNum)
                    {
                        Console.WriteLine("输入新商品名：");
                        String good = Console.ReadLine();
                        string[] orderArray = s.Split('-');
                        orderArray[1] = good;
                        String newOrder = "";
                        for (int i = 0; i < 3; i++)
                        {
                            newOrder += orderArray[i];
                            if (i < 2)
                            {
                                newOrder += "-";
                            }
                        }
                        orderList.Remove(s);
                        orderList.Add(newOrder);
                        Console.WriteLine("修改完成");
                        break;
                    }
                }
                catch (ArrayTypeMismatchException e)
                {
                    Console.WriteLine("修改失败");
                }
            }
            showOrder();
            creatOrder();
        }
        public override void searchOrder()
        {
            Console.WriteLine("1:按客户姓名查询\n2:按商品名称查询\n3:按订单号查询\n其他:退出");
            string type = Console.ReadLine();
            if (type == "1")
            {
                foreach (String s in orderList)
                {
                    Console.WriteLine("输入姓名：");
                    String name = Console.ReadLine();
                    string[] orderArray = s.Split('-');
                    if (orderArray[0] == name)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else if (type == "2")
            {
                foreach (String s in orderList)
                {
                    Console.WriteLine("输入商品名：");
                    String good = Console.ReadLine();
                    string[] orderArray = s.Split('-');
                    if (orderArray[1] == good)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else if (type == "3")
            {
                foreach (String s in orderList)
                {
                    Console.WriteLine("输入订单号：");
                    String num = Console.ReadLine();
                    string[] orderArray = s.Split('-');
                    if (orderArray[0] == num)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else
            {
                Console.WriteLine("您已退出！\n");
            }
            creatOrder();
        }
        public override void searchOrder2()
        {
            Console.WriteLine("1:按客户姓名查询\n2:按商品名称查询\n3:按订单号查询\n4:查询价格大于一万的商品\n其他:退出");
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    Console.WriteLine("输入客户姓名：");
                    string client = Console.ReadLine();
                    var result1 = orderObject.Where(a => a.client == client);
                    foreach (var n in result1)
                    {
                        showOrder2(n);
                    }
                    break;
                case "2":
                    Console.WriteLine("输入商品名称：");
                    string name = Console.ReadLine();
                    var result2 = orderObject.Where(a => a.name == name);
                    foreach (var n in result2)
                    {
                        showOrder2(n);
                    }
                    break;
                case "3":
                    Console.WriteLine("输入订单号：");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var result3 = orderObject.Where(a => a.id == id);
                    foreach (var n in result3)
                    {
                        showOrder2(n);
                    }
                    break;
                case "4":
                    Console.WriteLine("价格大于一万的订单：");
                    var result4 = orderObject.Where(a => a.price > 10000);
                    foreach (var n in result4)
                    {
                        showOrder2(n);
                    }
                    break;
            }
            creatOrder();
        }
        public void Export()
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            String xmlFileName = "Export.xml";
            XmlSerialize(xmlser, xmlFileName, orderObject);
        }
        public static void XmlSerialize(XmlSerializer xmlser, String fileName, List<Order> orders)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            xmlser.Serialize(fs, orders);
            fs.Close();
        }
        public void Import(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                List<Order> list = xs.Deserialize(fs) as List<Order>;
                orderObject.AddRange(list);
            }
        }
    }
}
