using System;

namespace TrackingService.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Digitar opción");
            Console.WriteLine("1 Enrolamiento");
            Console.WriteLine("2 Comprobacion Sobrevivencia");
            line = Console.ReadLine();
            switch (line) {
                case "1" :
                    Enrolamiento en = new Enrolamiento();
                    en.Start();
                    break;
            }
            Console.ReadKey();
        }
    }
}
