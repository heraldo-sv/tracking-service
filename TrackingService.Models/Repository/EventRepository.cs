using System;
using TrackingService.Infraestructure.DataSource;
using TrackingService.Infraestructure.DataSource.Interfaces;
using TrackingService.UseCase.Repository.Interfaces;

namespace TrackingService.InterfaceAdapter.Repositories
{
    public class EventRepository : IEventRepository
    {
        private EventDataSource _eventDataSource = new EventDataSource();
        
        public void Set(string eventID, string documentType, string documentNumber, string message)
        {
            _eventDataSource.Get(eventID, documentType, documentNumber, message);
        }
    }
}
