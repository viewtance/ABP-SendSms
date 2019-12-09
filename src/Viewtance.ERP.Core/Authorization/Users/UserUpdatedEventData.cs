using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace Viewtance.ERP.Authorization.Users
{
    public class UserUpdatedEventData : EventData
    {
        public int? TenantId { get; set; }

        public long UserId { get; set; }

        public string PhoneNumber { get; set; }

    }
}
