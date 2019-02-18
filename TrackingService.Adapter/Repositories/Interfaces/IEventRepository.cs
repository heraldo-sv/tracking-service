namespace TrackingService.InterfaceAdapter.Repositories.Interfaces
{
    interface IEventRepository
    {
        void Set(string eventID, string documentType, string documentNumber, string message);
    }
}
