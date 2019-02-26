using System;

namespace TrackingService.DomainEvents
{
    public class Events
    {
        public int? Tracking { get; set; }
        public string Token { get; set; }
        public string Satelite { get; set; }
        public string Host { get; set; }
        public string EventType { get; set; }
        public string EventMessage { get; set; }
        public string DocType { get; set; }
        public string DocNum { get; set; }
        public string Office { get; set; }
        public string Agent { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
