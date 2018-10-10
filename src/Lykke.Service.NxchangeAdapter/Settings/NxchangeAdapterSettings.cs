using JetBrains.Annotations;

namespace Lykke.Service.NxchangeAdapter.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class NxchangeAdapterSettings
    {
        public DbSettings Db { get; set; }
    }
}
