using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.NxchangeAdapter.Client 
{
    /// <summary>
    /// NxchangeAdapter client settings.
    /// </summary>
    public class NxchangeAdapterServiceClientSettings 
    {
        /// <summary>Service url.</summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl {get; set;}
    }
}
