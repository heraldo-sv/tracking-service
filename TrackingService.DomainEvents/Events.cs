using System;

namespace TrackingService.DomainEvents
{
    public class Events
    {
        public int? TrackingID { get; set; }
        public string EventID { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
