using JetBrains.Annotations;
using Lykke.Sdk.Settings;

namespace Lykke.Service.NxchangeAdapter.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public NxchangeAdapterSettings NxchangeAdapterService { get; set; }
    }
}
