using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mostr
{
    internal class AirMonstr : Monstr
    {
        //конструктор
        public AirMonstr(string name,
            int dangerLevel)
        {
            Name = name;
            DangerLevel = dangerLevel;
            Type = MonstrType.Air; // тип назначается автоматически 
        }
        //переопределенный абстрактный метод
        public override void Interaction(MonstrType type)
        {
            switch (type)
            {
                case MonstrType.Marine:
                    Console.WriteLine("attack"); break;
                case MonstrType.Air:
                    Console.WriteLine("friend"); break;
                case MonstrType.Terrestrial:
                    Console.WriteLine("attack"); break;
                default: Console.WriteLine("unknown interaction"); break;
            }

        }
    }
}
