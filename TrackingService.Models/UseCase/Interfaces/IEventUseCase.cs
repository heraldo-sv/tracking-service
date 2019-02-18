using System;
using System.Collections.Generic;
using System.Text;

namespace TrackingService.Models.Interfaces
{
    public interface IEventUseCase
    {
        void Set(string eventID, string documentType, string documentNumber, string message);
    }
}
