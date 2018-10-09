using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.NexchangeAdapter.Client 
{
    /// <summary>
    /// NexchangeAdapter client settings.
    /// </summary>
    public class NexchangeAdapterServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
