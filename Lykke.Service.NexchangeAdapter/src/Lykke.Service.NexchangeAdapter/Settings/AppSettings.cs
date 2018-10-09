using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace Lykke.Service.NexchangeAdapter.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public NexchangeAdapterSettings NexchangeAdapterService { get; set; }
    }
}
