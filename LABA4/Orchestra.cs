using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    class Orchestra
    {
        private string name;
        private string instrument;
        public Orchestra(string name, string instrument)
        {
            this.name = name;
            this.instrument = instrument;
        }
        public  void GetInfo()
        {
            Console.WriteLine("Имя исполнителя: " + name +"; "+ "Инструмент: " + instrument);
        }
    }
}
