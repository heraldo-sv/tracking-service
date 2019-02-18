namespace TrackingService.InterfaceAdapter.Gateway.Interfaces
{
    public interface IEventGateway
    {
        void Set(string eventID, string documentType, string documentNumber, string message);
    }
}
