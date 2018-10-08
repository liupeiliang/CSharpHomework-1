using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    public delegate void MyDelegate(int times);

    public class Alarm
    {
        public void Time(int times)
        {
            Console.WriteLine(times + "秒到了！");
        }
    }
    public class Create
    {
        public MyDelegate createDelegate()
        {
            Alarm alarm = new Alarm();
            MyDelegate d = new MyDelegate(alarm.Time);
            return d;
        }
    }
    public class MyClock
    {
        public void timeOut(MyDelegate d, int times)
        {
            d(times);
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Create create = new Create();
            MyDelegate d = create.createDelegate();
            int times;
            Console.WriteLine("设置时间：");
            string st = Console.ReadLine();
            times = Convert.ToInt32(st);
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            dateTime = dateTime.AddSeconds(times);
            MyClock myClock = new MyClock();
            while (true)
            {
                if (DateTime.Now >= dateTime)
                {
                    myClock.timeOut(d, times);
                    break;
                }
            }
        }
    }
}
