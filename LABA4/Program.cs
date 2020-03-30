using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Instrument> instruments = new List<Instrument>();
            List<Orchestra> orc = new List<Orchestra>();
            string[] little_orchestra = new string[] {"Флейта", "Флейта", "Гобой", "Гобой", "Кларнет", "Кларнет", "Фагот", "Скрипка", "Альт", "Контрабас", "Контрабас", "Барабаны", "ТамТам", "ТамТам"};
            string[] names = new string[] { "Антипенко Артем", "Богайчук Юрий", "Бойко Элизавета", "Василенко Александр", "Волошин Алексей", "Гилюн Денис", "Бондаренко Дмитрий", "Гриник Валентина", "Кучеренко Артем", "Михайлов Павло", "Рафалюк Роман", "Шенфельд Валентин", "Шуляк Борис", "Щербаков Антон"};
            for (int i = 0; i < 7; i++)
            {
                instruments.Add(new Wind(little_orchestra[i]));
            }
            for(int i = 7; i < 11; i++)
            {
                instruments.Add(new Stringed(little_orchestra[i]));
            }
            for(int i = 11; i < little_orchestra.Length; i++)
            {
                instruments.Add(new Percussion(little_orchestra[i]));
            }
            for(int i = 0; i < instruments.Count; i++)
            {
                orc.Add(new Orchestra(names[i], instruments[i].Name));
            }
            foreach (Instrument i in instruments)
                i.GetSound();
            foreach (Orchestra i in orc)
                i.GetInfo();
            Console.ReadKey();
        }
    }
}
