namespace TrackingService.InterfaceAdapter.Gateway.Interfaces
{
    public interface IEventGateway
    {
        void Set( string token
                , string satelite
                , string eventType
                , string eventMessage
                , string docType
                , string docNum
                , string office
                , string agent);
    }
}
