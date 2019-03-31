using DataTransferObjects;
using DataTransferObjects.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAdapters.Gateways
{
    public interface IClientGateway
    {
        ResponseMessage AddClient(ClientDto dto);
    }
}
