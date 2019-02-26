using TrackingService.InterfaceAdapter.Repositories;
using TrackingService.Models.Interfaces;

namespace TrackingService.UseCase
{
    public class EventUseCase : IEventUseCase
    {
        private EventRepository _eventRepository = new EventRepository();
        
        public void Set( string token
                       , string satelite
                       , string eventType
                       , string eventMessage
                       , string docType
                       , string docNum
                       , string office
                       , string agent)
        {
            _eventRepository.Set(token,satelite,eventType,eventMessage,docType,docNum,office,agent);
        }
    }
}
