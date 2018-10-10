using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.NxchangeAdapter.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
