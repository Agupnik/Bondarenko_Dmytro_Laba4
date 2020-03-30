using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    class Percussion : Instrument
    {
        public Percussion(string name)
        {
            Type = "Ударный";
            Sound = "Бах";
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
