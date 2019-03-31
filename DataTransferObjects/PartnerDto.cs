using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class PartnerDto
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public decimal Share { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
