using System;
using System.Collections.Generic;
using System.Text;

namespace TrackingService.UseCase.Repository.Interfaces
{
    public interface IEventRepository
    {
        void Set(string eventID, string documentType, string documentNumber, string message);
    }
}
