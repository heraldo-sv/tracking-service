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

        public void Set(string eventID, string documentType, string documentNumber, string message)
        {
            _eventDataSource.Get(eventID, documentType, documentNumber, message);
        }
    }
}
