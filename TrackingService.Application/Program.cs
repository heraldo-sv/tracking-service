using System;

namespace TrackingService.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Digitar opción");
            Console.WriteLine("1 Enrolamiento");
            Console.WriteLine("2 Comprobacion Sobrevivencia");
            line = Console.ReadLine();
            switch (line) {
                case "1" :
                    EnrolamientoEvent en = new EnrolamientoEvent();
                    en.Start();
                    break;
            }
            Console.ReadKey();
        }
    }
}
