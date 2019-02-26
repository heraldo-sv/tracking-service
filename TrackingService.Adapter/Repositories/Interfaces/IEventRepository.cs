namespace TrackingService.InterfaceAdapter.Repositories.Interfaces
{
    interface IEventRepository
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
