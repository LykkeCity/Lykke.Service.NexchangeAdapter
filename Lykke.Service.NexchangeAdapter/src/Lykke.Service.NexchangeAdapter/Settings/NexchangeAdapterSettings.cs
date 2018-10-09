using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.NexchangeAdapter.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class NexchangeAdapterSettings
    {
        public DbSettings Db { get; set; }
    }
}
