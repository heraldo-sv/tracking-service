using System;
using System.Collections.Generic;
using System.Text;

namespace DataTransferObjects
{
    public class UserDto
    {
        public long Id { get; set; }
        public string Nick { get; set; }
        public string Mail { get; set; }
        public List<PartnerDto> Partners { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
