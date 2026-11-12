using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using SwaggerPetstoreOpenApi310.Core.Hooks;
using SwaggerPetstoreOpenApi310.Core.Models;

namespace SwaggerPetstoreOpenApi310.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<HeaderParam>? Headers { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
