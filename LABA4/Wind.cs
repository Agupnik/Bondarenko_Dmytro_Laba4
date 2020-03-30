using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    class Wind : Instrument
    {
        public Wind(string name)
        {
            Type = "Духовой";
            Sound = "Уух";
            Name = name;
        }
        public override void GetInfo()
        {
            Console.WriteLine("Тип: " + Type + "\n" + "Имя: " + Name + "\n");
        }
        public override void GetSound()
        {
            Console.WriteLine($"Звук {Name}: {Sound}");
        }
    }
}
