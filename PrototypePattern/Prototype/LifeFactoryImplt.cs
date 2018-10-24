using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypePattern.Model;
namespace PrototypePattern.Prototype
{
    public class LifeFactoryImplt:ILifeFactory
    {
        public static DayLife DayLife;
        DayLife ILifeFactory.GetDayLifeInstance()
        {
            if (DayLife == null)
            {
                DayLife = new DayLife();
                DayLife.SetGetUp("7:00!");
                DayLife.SetGetBus("7:30!");
                DayLife.iArr =new int[] { 0, 1, 2 };
                return DayLife;
            }
            else
            {
                DayLife dayLife = DayLife.MemberwiseClone();
                return dayLife;
            }
            
           
        }
    }
}
