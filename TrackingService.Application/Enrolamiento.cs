using System;
using TrackingService.InterfaceAdapter.Gateway;

namespace TrackingService.Application
{
    public class Enrolamiento
    {
        Callback _callback;
        public void Start()
        {
            string documentNumber = string.Empty;
            string secretWord = string.Empty;

            _callback = new Callback();

            Console.WriteLine("Digitar Número de DUI >>");
            documentNumber = Console.ReadLine();
            _callback.Set( "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJ1c2VybmFtZSI6InNlcmdpb2R4YSJ9.Qu7rv5wqk6zGjiMU8ZixwvKQGBNW9hhj55DbSP50b1g"
                         , "AVAYA"
                         , "INFO"
                         , "TRR-EN001"
                         , "DUI"
                         , documentNumber
                         , "S0049"
                         , "RD25246" );

            Console.WriteLine("Buscando datos de cliente...  >>");
            _callback.Set( "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJ1c2VybmFtZSI6InNlcmdpb2R4YSJ9.Qu7rv5wqk6zGjiMU8ZixwvKQGBNW9hhj55DbSP50b1g"
                         , "AVAYA"
                         , "INFO"
                         , "TRR-EN002"
                         , "DUI"
                         , documentNumber
                         , "S0049"
                         , "RD25246");

            Console.WriteLine("Cliente verificado...  >>");
            _callback.Set("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJ1c2VybmFtZSI6InNlcmdpb2R4YSJ9.Qu7rv5wqk6zGjiMU8ZixwvKQGBNW9hhj55DbSP50b1g"
                         , "AVAYA"
                         , "INFO"
                         , "TRR-EN003"
                         , "DUI"
                         , documentNumber
                         , "S0049"
                         , "RD25246");

            Console.WriteLine("Digitar palabra secreta  >>");
            secretWord = Console.ReadLine();
            _callback.Set("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJ1c2VybmFtZSI6InNlcmdpb2R4YSJ9.Qu7rv5wqk6zGjiMU8ZixwvKQGBNW9hhj55DbSP50b1g"
                         , "AVAYA"
                         , "INFO"
                         , "TRR-EN004"
                         , "DUI"
                         , documentNumber
                         , "S0049"
                         , "RD25246");
            if (secretWord == "algo")
            {
                Console.WriteLine("Se creo el registro de enrolamiento...  >>");
                _callback.Set("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJ1c2VybmFtZSI6InNlcmdpb2R4YSJ9.Qu7rv5wqk6zGjiMU8ZixwvKQGBNW9hhj55DbSP50b1g"
                         , "AVAYA"
                         , "INFO"
                         , "TRR-EN005"
                         , "DUI"
                         , documentNumber
                         , "S0049"
                         , "RD25246");
            } else
            {
                Console.WriteLine("Se denego el registro de enrolamiento...  >>");
                _callback.Set("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJ1c2VybmFtZSI6InNlcmdpb2R4YSJ9.Qu7rv5wqk6zGjiMU8ZixwvKQGBNW9hhj55DbSP50b1g"
                         , "AVAYA"
                         , "WARN"
                         , "TRD-EN005"
                         , "DUI"
                         , documentNumber
                         , "S0049"
                         , "RD25246");
            }
            Console.WriteLine("Proceso terminado...");
        }
    }
}
