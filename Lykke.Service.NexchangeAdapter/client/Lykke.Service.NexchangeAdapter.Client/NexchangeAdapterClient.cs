using Lykke.HttpClientGenerator;

namespace Lykke.Service.NexchangeAdapter.Client
{
    /// <summary>
    /// NexchangeAdapter API aggregating interface.
    /// </summary>
    public class NexchangeAdapterClient : INexchangeAdapterClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to NexchangeAdapter Api.</summary>
        public INexchangeAdapterApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public NexchangeAdapterClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<INexchangeAdapterApi>();
        }
    }
}
