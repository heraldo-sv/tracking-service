using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapters.repositories
{
    interface IPartnerRepository
    {
        bool Add(PartnerDto partnerDto);
    }
}
