using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.NexchangeAdapter.Settings
{
    public class DbSettings
    {
        [AzureTableCheck]
        public string LogsConnString { get; set; }
    }
}
