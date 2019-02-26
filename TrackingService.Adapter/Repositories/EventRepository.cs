using System;
using TrackingService.Infraestructure.DataSource.Interfaces;
using TrackingService.InterfaceAdapter.Repositories.Interfaces;

namespace TrackingService.InterfaceAdapter.Repositories
{
    public class EventRepository : IEventRepository
    {
        private IEventDataSource _eventDataSource;
        public EventRepository(IEventDataSource eventDataSource)
        {
            _eventDataSource = eventDataSource ?? throw new ArgumentNullException(nameof(eventDataSource));
        }

        public void Set( string token
                       , string satelite
                       , string eventType
                       , string eventMessage
                       , string docType
                       , string docNum
                       , string office
                       , string agent)
        {
            _eventDataSource.Set(token,satelite,eventType,eventMessage,docType,docNum,office,agent);
        }
    }
}
