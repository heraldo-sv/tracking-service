using System;
using System.Collections.Generic;
using System.Text;
using TrackingService.Infraestructure.DataSource.Config.Oracle.DbModel;

namespace TrackingService.Infraestructure.DataSource.Interfaces
{
    public interface IEventDataSource
    {
        void Get(string eventID, string DocumentType, string DocumentNumber, string message);
    }
}
