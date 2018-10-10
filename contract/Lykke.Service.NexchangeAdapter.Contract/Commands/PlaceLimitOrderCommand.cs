using Lykke.Service.NexchangeAdapter.Contract.Enums;
using ProtoBuf;

namespace Lykke.Service.NexchangeAdapter.Contract.Commands
{
    [ProtoContract]
    public class PlaceLimitOrderCommand
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        [ProtoMember(2)]
        public string WalletId { get; set; }

        [ProtoMember(3)]
        public string AssetPairId { get; set; }

        [ProtoMember(4)]
        public OrderSide Side { get; set; }

        [ProtoMember(5)]
        public string Volume { get; set; }

        [ProtoMember(6)]
        public string Price { get; set; }
    }
}
