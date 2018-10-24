using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypePattern.Model;
using PrototypePattern.Prototype;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ILifeFactory lifeFactory = new LifeFactoryImplt();
            DayLife dayLife = lifeFactory.GetDayLifeInstance();
            Console.WriteLine("the daylife display:");

            dayLife.PrintInfo();

            //
            Console.WriteLine("clone daylife object:");
            DayLife dayLife1 = dayLife.MemberwiseClone();//浅复制
            DayLife dayLife2 = dayLife.clone();//深复制
            dayLife1.iArr[0] = 111;
            Console.WriteLine("after alter light clone object the daylife display:");
            dayLife.PrintInfo();

            Console.WriteLine("after alter deep clone object the daylife display:");
            dayLife2.iArr[0] = 222;           
           
            dayLife.PrintInfo(); //深度复制克隆后进行修改后，不影响原来的对象，对象间互相独立

            Console.ReadKey();
            
        }
    }
}
