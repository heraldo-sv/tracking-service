using System;
using System.Collections.Generic;
using System.Text;
using TrackingService.InterfaceAdapter.Gateway;

namespace TrackingService.Application
{
    class Callback
    {
        private EventGateway _eventGateway;

        public void Set( string token
                       , string satelite
                       , string event_type
                       , string event_message
                       , string doc_type
                       , string doc_num
                       , string office
                       , string agent)
        {
            _eventGateway = new EventGateway();
            _eventGateway.Set(token, satelite, event_type, event_message, doc_type, doc_num, office, agent);
        }
    }
}
