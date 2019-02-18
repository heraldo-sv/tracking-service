using TrackingService.InterfaceAdapter.Gateway.Interfaces;
using TrackingService.UseCase;

namespace TrackingService.InterfaceAdapter.Gateway
{
    public class EventGateway : IEventGateway
    {
        EventUseCase _eventUseCase = new EventUseCase();

        public void Set(string eventID, string documentType, string documentNumber, string message)
        {
            _eventUseCase.Set(eventID, documentType, documentNumber, message);
        }
    }
}
