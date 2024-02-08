using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostr
{
    enum MonstrType {Marine, Air, Terrestrial };
    internal abstract class Monstr
    {
        private string name; //поле именя монстра
        public string Name //свойство имени
        {
            get => name; //при чтении выдает содержимое поля
            set // записывает в name только строки от 3 до 20 смиволов или строку undefined
            {
                if (value.Length > 3 && value.Length < 21)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("имя должно быть от 3 до 20 символов");
                    name = "undefined";
                }
            }
        }

        public MonstrType Type { get; set; }    //автосвойство тип монстра
        public int DangerLevel { get; set; }    // уровень опасности 

        public abstract void Interaction(MonstrType type); //метод, описывающий взаимодействие с другими монстрами
        

    }
}
