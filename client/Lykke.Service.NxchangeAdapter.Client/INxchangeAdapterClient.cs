﻿using JetBrains.Annotations;

namespace Lykke.Service.NxchangeAdapter.Client
{
    /// <summary>
    /// NxchangeAdapter client interface.
    /// </summary>
    [PublicAPI]
    public interface INxchangeAdapterClient
    {
        // Make your app's controller interfaces visible by adding corresponding properties here.
        // NO actual methods should be placed here (these go to controller interfaces, for example - INxchangeAdapterApi).
        // ONLY properties for accessing controller interfaces are allowed.

        /// <summary>Application Api interface</summary>
        INxchangeAdapterApi Api { get; }
    }
}
