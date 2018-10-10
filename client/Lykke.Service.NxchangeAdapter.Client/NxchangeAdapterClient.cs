using Lykke.HttpClientGenerator;

namespace Lykke.Service.NxchangeAdapter.Client
{
    /// <summary>
    /// NxchangeAdapter API aggregating interface.
    /// </summary>
    public class NxchangeAdapterClient : INxchangeAdapterClient
    {
        // Note: Add similar Api properties for each new service controller

        /// <summary>Inerface to NxchangeAdapter Api.</summary>
        public INxchangeAdapterApi Api { get; private set; }

        /// <summary>C-tor</summary>
        public NxchangeAdapterClient(IHttpClientGenerator httpClientGenerator)
        {
            Api = httpClientGenerator.Generate<INxchangeAdapterApi>();
        }
    }
}
