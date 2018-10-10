using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Service.NexchangeAdapter.Contract.Enums
{
    public enum OrderStatus
    {
        Unknown,
        Placed,
        PartiallyMatched,
        Matched,
        Pending,
        Cancelled,
        Rejected
    }
}
