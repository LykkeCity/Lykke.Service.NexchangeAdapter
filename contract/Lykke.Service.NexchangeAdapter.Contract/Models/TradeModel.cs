using System;
using System.Collections.Generic;
using System.Text;
using Lykke.Service.NexchangeAdapter.Contract.Enums;
using ProtoBuf;

namespace Lykke.Service.NexchangeAdapter.Contract.Models
{
    [ProtoContract]
    public class TradeModel
    {
        [ProtoMember(1)]
        public string TradeId { get; set; }

        [ProtoMember(2)]
        public string BaseAssetId { get; set; }

        [ProtoMember(3)]
        public string BaseVolume { get; set; }

        [ProtoMember(4)]
        public string Price { get; set; }

        [ProtoMember(5, DataFormat = DataFormat.WellKnown)]
        public DateTime Timestamp { get; set; }

        [ProtoMember(6)]
        public string OppositeOrderId { get; set; }

        [ProtoMember(8)]
        public string OppositeWalletId { get; set; }

        [ProtoMember(9)]
        public string QuotingAssetId { get; set; }

        [ProtoMember(10)]
        public string QuotingVolume { get; set; }

        [ProtoMember(11)]
        public int Index { get; set; }

        [ProtoMember(12)]
        public string AbsoluteSpread { get; set; } // ???

        [ProtoMember(13)]
        public string RelativeSpread { get; set; } // ???

        [ProtoMember(14)]
        public TradeRole Role { get; set; }
    }
}
