using System;
using System.IO;
using TrackingService.Infraestructure.DataSource.Config.Oracle.DbModel;
using TrackingService.Infraestructure.DataSource.Interfaces;

namespace TrackingService.Infraestructure.DataSource
{
    public class EventDataSource : IEventDataSource
    {
        private EventEntity ev = new EventEntity();
        
        public void Set( string token
                       , string satelite
                       , string eventType
                       , string eventMessage
                       , string docType
                       , string docNum
                       , string office
                       , string agent)
        {
            Random r = new Random();
            
            ev.Tracking = r.Next();
            ev.Token = token;
            ev.Satelite = satelite;
            ev.Host = "BIOMETRÍA SERVICE";
            ev.EventType = eventType;
            ev.EventMessage = eventMessage;
            ev.DocType = docType;
            ev.DocNum = docNum;
            ev.Office = office;
            ev.Agent = agent;
            ev.CreatedAt = DateTime.Parse(DateTime.Now.Date.ToString().Split(' ')[0]);
            ev.Timestamp = DateTime.Now;


            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = File.AppendText(AppDomain.CurrentDomain.BaseDirectory+"\\local.txt");
                
                //Write a line of text
                sw.WriteLine($"{ev.Tracking} | {ev.Token} | {ev.Satelite} | {ev.Host} | {ev.EventType} | {ev.EventMessage} | {ev.DocType} | {ev.DocNum} | {ev.Office} | {ev.Agent} | {ev.CreatedAt} | {ev.Timestamp}");

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