using System;
using System.Collections.Generic;
using System.Text;

namespace TrackingService.Infraestructure.DataSource.Config.Oracle.DbModel
{
    class EventEntity
    {
        public int? TrackingID { get; set; }
        public string EventID { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string Message { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
