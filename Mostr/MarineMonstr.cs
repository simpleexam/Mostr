using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostr
{
    internal class MarineMonstr : Monstr
    {
        //конструктор
        public MarineMonstr(string name, 
            int dangerLevel) 
        {
            Name = name;
            DangerLevel = dangerLevel;
            Type = MonstrType.Marine;   // тип назначается автоматически 
        }
        //переопределенный абстрактный метод
        public override void Interaction(MonstrType type)
        {
            switch (type)
            { 
                case MonstrType.Marine:
                    Console.WriteLine("friend"); break;
                case MonstrType.Air:
                    Console.WriteLine("plunges into the depths"); break;
                case MonstrType.Terrestrial:
                    Console.WriteLine("eat"); break;
                default: Console.WriteLine("unknown interaction"); break;
            }

        }
    }
}
