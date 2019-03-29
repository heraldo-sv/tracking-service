using System;
using System.Collections.Generic;
using System.Text;

namespace tracking_service.Domain
{
    class User
    {
        public long Id { get; set; }
        public string Nick { get; set; }
        public string Mail { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
