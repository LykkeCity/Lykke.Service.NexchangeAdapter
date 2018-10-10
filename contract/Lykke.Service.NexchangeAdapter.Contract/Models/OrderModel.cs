using System;
using System.Collections.Generic;
using System.Text;
using Lykke.Service.NexchangeAdapter.Contract.Enums;
using ProtoBuf;

namespace Lykke.Service.NexchangeAdapter.Contract.Models
{
    [ProtoContract]
    public class OrderModel
    {
        [ProtoMember(1)]
        public OrderType OrderType { get; set; }

        [ProtoMember(2)]
        public string Id { get; set; }

        [ProtoMember(3)]
        public string AssetPairId { get; set; }

        [ProtoMember(4)]
        public string WalletId { get; set; }

        [ProtoMember(5)]
        public OrderSide Side { get; set; }

        [ProtoMember(6)]
        public string Volume { get; set; }

        [ProtoMember(7)]
        public string RemainingVolume { get; set; }

        [ProtoMember(8)]
        public string Price { get; set; }

        [ProtoMember(9)]
        public OrderStatus Status { get; set; }

        [ProtoMember(10)]
        public string RejectReason { get; set; }

        /// <summary>
        /// Last status date
        /// </summary>
        [ProtoMember(11, DataFormat = DataFormat.WellKnown)]
        public DateTime StatusDate { get; set; }

        /// <summary>
        /// Date from incoming request
        /// </summary>
        [ProtoMember(12, DataFormat = DataFormat.WellKnown)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date of first processing in ME
        /// </summary>
        [ProtoMember(13, DataFormat = DataFormat.WellKnown)]
        public DateTime Registered { get; set; }

        [ProtoMember(14)]
        public List<TradeModel> Trades { get; set; }
    }
}
