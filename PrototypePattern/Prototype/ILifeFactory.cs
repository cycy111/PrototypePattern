using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypePattern.Model;

namespace PrototypePattern.Prototype
{
    interface ILifeFactory
    {
        DayLife GetDayLifeInstance();
    }
}
