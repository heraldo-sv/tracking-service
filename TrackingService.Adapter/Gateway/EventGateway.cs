using TrackingService.InterfaceAdapter.Gateway.Interfaces;
using TrackingService.UseCase;

namespace TrackingService.InterfaceAdapter.Gateway
{
    public class EventGateway : IEventGateway
    {
        EventUseCase _eventUseCase = new EventUseCase();

        public void Set(string token
                       , string satelite
                       , string eventType
                       , string eventMessage
                       , string docType
                       , string docNum
                       , string office
                       , string agent)
        {
            _eventUseCase.Set(token,satelite,eventType,eventMessage,docType,docNum,office,agent);
        }
    }
}
