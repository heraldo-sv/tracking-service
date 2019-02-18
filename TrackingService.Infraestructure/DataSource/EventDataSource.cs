using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TrackingService.Infraestructure.DataSource.Config.Oracle.DbModel;
using TrackingService.Infraestructure.DataSource.Interfaces;

namespace TrackingService.Infraestructure.DataSource
{
    public class EventDataSource : IEventDataSource
    {
        private EventEntity ev = new EventEntity();
        
        public void Get(string eventID, string documentType, string documentNumber, string message)
        {
            ev.EventID = eventID;
            ev.DocumentType = documentType;
            ev.DocumentNumber = documentNumber;
            ev.CreatedAt = DateTime.Now;
            ev.Message = message;

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory+"\\local.txt");
                
                //Write a line of text
                sw.WriteLine($"{ev.EventID} | {ev.DocumentType} | {ev.DocumentNumber} | {ev.Message} | {ev.CreatedAt}");

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                
            }

        }
    }
}