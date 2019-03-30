using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class PartnerDto
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long CompanyId { get; set; }
        public decimal Share { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
