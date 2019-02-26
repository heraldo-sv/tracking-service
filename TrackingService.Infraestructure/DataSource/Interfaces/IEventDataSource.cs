using System;
using System.Collections.Generic;
using System.Text;
using TrackingService.Infraestructure.DataSource.Config.Oracle.DbModel;

namespace TrackingService.Infraestructure.DataSource.Interfaces
{
    public interface IEventDataSource
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
