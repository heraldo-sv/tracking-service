using System;
using TrackingService.Infraestructure.DataSource;
using TrackingService.Infraestructure.DataSource.Interfaces;
using TrackingService.UseCase.Repository.Interfaces;

namespace TrackingService.InterfaceAdapter.Repositories
{
    public class EventRepository : IEventRepository
    {
        private EventDataSource _eventDataSource = new EventDataSource();
        
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
