namespace TrackingService.Models.Interfaces
{
    public interface IEventUseCase
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
