namespace Mostr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MarineMonstr marine1 = new MarineMonstr("ktulhu", 1000);

            AirMonstr air1 = new AirMonstr("viverna", 100);

            marine1.Interaction(air1.Type);

            air1.Interaction(marine1.Type);    
        }
    }
}