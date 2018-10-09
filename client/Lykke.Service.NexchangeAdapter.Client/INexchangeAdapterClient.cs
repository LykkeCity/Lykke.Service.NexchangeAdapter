using JetBrains.Annotations;

namespace Lykke.Service.NexchangeAdapter.Client
{
    /// <summary>
    /// NexchangeAdapter client interface.
    /// </summary>
    [PublicAPI]
    public interface INexchangeAdapterClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - INexchangeAdapterApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        INexchangeAdapterApi Api { get; }
    }
}
