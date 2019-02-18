using TrackingService.InterfaceAdapter.Repositories;
using TrackingService.Models.Interfaces;

namespace TrackingService.UseCase
{
    public class EventUseCase : IEventUseCase
    {
        private EventRepository _eventRepository = new EventRepository();
        
        public void Set(string eventID, string tipoDocumento, string numeroDocumento, string mensaje)
        {
            _eventRepository.Set(eventID, tipoDocumento, numeroDocumento, mensaje);
        }
    }
}
