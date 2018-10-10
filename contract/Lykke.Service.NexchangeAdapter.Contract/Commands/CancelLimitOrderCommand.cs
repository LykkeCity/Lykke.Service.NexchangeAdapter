using ProtoBuf;

namespace Lykke.Service.NexchangeAdapter.Contract.Commands
{
    [ProtoContract]
    public class CancelLimitOrderCommand
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        [ProtoMember(2)]
        public string WalletId { get; set; }
    }
}
