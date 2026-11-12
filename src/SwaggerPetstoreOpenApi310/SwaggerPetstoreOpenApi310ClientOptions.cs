using System;
using System.Collections.Generic;
using SwaggerPetstoreOpenApi310.Core.Authentication;
using SwaggerPetstoreOpenApi310.Core.Configuration;
using SwaggerPetstoreOpenApi310.Core.Hooks;
using SwaggerPetstoreOpenApi310.Servers;

namespace SwaggerPetstoreOpenApi310;

public class SwaggerPetstoreOpenApi310ClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public TimeProvider TimeProvider { get; set; } = TimeProvider.System;
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Maximum time to wait for the next frame of a streaming (SSE) response before the stream is
    /// torn down with a timeout. Bounds only the wait for the server between frames, never the
    /// caller's own processing time. Set to null to wait indefinitely.
    /// </summary>
    public TimeSpan? StreamReadTimeout { get; set; } = TimeSpan.FromSeconds(60);
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public string? PetstoreAuth { get; set; }
    public CredentialProvider<string>? PetstoreAuthProvider { get; set; }
    public string? ApiKey { get; set; }
    public CredentialProvider<string>? ApiKeyProvider { get; set; }
}
