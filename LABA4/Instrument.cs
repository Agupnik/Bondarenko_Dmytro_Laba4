using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    abstract class Instrument
    {
        public string Type { get; set; }
        public string Sound { get; set; }
        public string Name { get; set; }
        public abstract void GetInfo();
        public abstract void GetSound();
    }
}
