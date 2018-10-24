using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace PrototypePattern.Model
{
    [Serializable]
    public class DayLife
    {
        private string Getup;
        private string GetBus;
        private string Noon;
        public int[] iArr = { 1, 2, 3 };

        public void SetGetUp(string getup)
        {
            this.Getup = getup;
        }
        public string GetGetUp()
        {
            return Getup;
        }
        public void SetGetBus(string getbus)
        {
            this.GetBus = getbus;
        }
        public string GetGetBusp()
        {
            return GetBus;
        }
        public new  DayLife MemberwiseClone()  //浅CLONE
        {
            return  (DayLife)base.MemberwiseClone();
            
        }

        public DayLife clone() //深clone
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream) as DayLife;
         
        }
        public void PrintInfo()
        {
            Console.WriteLine(GetGetUp());
            Console.WriteLine(GetGetBusp());
            foreach (var item in iArr)
            {
                Console.WriteLine(item);
            }
            
        }

    }
}
