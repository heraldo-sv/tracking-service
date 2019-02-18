using System;
using TrackingService.InterfaceAdapter.Gateway;

namespace TrackingService.Application
{
    class EnrolamientoEvent
    {
        EventGateway _eventGateway;
        public void Start()
        {
            string documentNumber = null;
            string secretWord = null;

            _eventGateway = new EventGateway();

            Console.WriteLine("Digitar Número de DUI >>");
            documentNumber = Console.ReadLine();
            _eventGateway.Set("TR-ER001", "DUI", documentNumber, "...");

            Console.WriteLine("Buscando datos de cliente...  >>");
            _eventGateway.Set("TR-ER002", "DUI", documentNumber, "...");

            Console.WriteLine("Cliente verificado...  >>");
            _eventGateway.Set("TR-ER003", "DUI", documentNumber, "...");

            Console.WriteLine("Digitar palabra secreta  >>");
            secretWord = Console.ReadLine();
            _eventGateway.Set("TR-ER004", "DUI", documentNumber, "...");
            if (secretWord == "algo")
            {
                Console.WriteLine("Se creo el registro de enrolamiento...  >>");
                _eventGateway.Set("TR-ER005", "DUI", documentNumber, "...");
            } else
            {
                Console.WriteLine("Se denego el registro de enrolamiento...  >>");
                _eventGateway.Set("TR-ER006", "DUI", documentNumber, "...");
            }
            Console.WriteLine("Proceso terminado...");
        }
    }
}
