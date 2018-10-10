using System;
using System.Collections.Generic;
using System.Text;
using Lykke.Service.NexchangeAdapter.Contract.Enums;
using Lykke.Service.NexchangeAdapter.Contract.Models;
using ProtoBuf;

namespace Lykke.Service.NexchangeAdapter.Contract.Events
{
    [ProtoContract]
    public class ExecutionEvent
    {
        [ProtoMember(1)]
        public List<OrderModel> Orders { get; set; }
    }
}
