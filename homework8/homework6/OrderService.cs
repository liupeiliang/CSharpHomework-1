using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace homework6
{
    public class OrderService
    {
        public BindingList<Order> orderObject = new BindingList<Order>();
        public string addOrder(string client, string name, string id, int price)
        {
            string rightId = "^(2[0-9]{3})((0[1-9])|(1[0-2]))([0-3][0-9])([0-9]{3})$";
            string rightClient = "^1[0-9]{10}$";
            if(id == null)
            {
                return "订单号不能为空！";
            }
            else if(!Regex.IsMatch(id, rightId))
            {
                return "订单号错误！";
            }
            else if(client != null && !Regex.IsMatch(client, rightClient))
            {
                return "客户手机号码错误！";
            }
            else
            {
                foreach(Order e in orderObject)
                {
                    if(e.id.Equals(id))
                    {
                        return "订单号不能重复";
                    }
                }
                orderObject.Add(new Order(client, name, id, price));
                return "成功";
            }
        }
        public void deleteOrder(int id)
        {
            Order order = new Order("", "", "", 0);
            foreach (Order e in orderObject)
            {
                if (e.id.Equals(id))
                {
                    order = e;
                }
            }
            orderObject.Remove(order);
        }
        public string changeOrder(string id, string newClient, string newName, string newId, int newPrice)
        {
            Order order = new Order("", "", "", 0);
            string rightId = "^(2[0-9]{3})((0[1-9])|(1[0-2]))([0-3][0-9])([0-9]{3})$";
            string rightClient = "^1[0-9]{10}$";
            if (newId == null)
            {
                return "订单号不能为空！";
            }
            else if (!Regex.IsMatch(newId, rightId))
            {
                return "订单号错误！";
            }
            else if (newClient != null && !Regex.IsMatch(newClient, rightClient))
            {
                return "客户手机号码错误！";
            }
            else
            {
                foreach (Order e in orderObject)
                {
                    if (e.id.Equals(newId))
                    {
                        return "订单号不能重复";
                    }
                }
                foreach (Order e in orderObject)
                {
                    if (e.id.Equals(id))
                    {
                        order = e;
                    }
                }
                orderObject.Remove(order);
                orderObject.Add(new Order(newClient, newName, newId, newPrice));
                return "成功";
            }        
        }
        public Order searchOrder(int id)
        {
            Order order = new Order("", "", "", 0);
            foreach(Order e in orderObject)
            {
                if(e.id.Equals(id))
                {
                    order = e;
                }
            }
            return order;
        }
        public void Export()
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(BindingList<Order>));
            String xmlFileName = "Export.xml";
            XmlSerialize(xmlser, xmlFileName, orderObject);

            XmlDocument doc = new XmlDocument();
            doc.Load(@"Export.xml");

            XPathNavigator nav = doc.CreateNavigator();
            nav.MoveToRoot();

            XslCompiledTransform xt = new XslCompiledTransform();
            xt.Load(@"../../Export.xslt");

            FileStream outFileStream = File.OpenWrite(@"Export.html");
            XmlTextWriter writer =
                new XmlTextWriter(outFileStream, Encoding.UTF8);
            xt.Transform(nav, null, writer);
        }
        public static void XmlSerialize(XmlSerializer xmlser, String fileName, BindingList<Order> orders)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            xmlser.Serialize(fs, orders);
            fs.Close();
        }
    }
}
