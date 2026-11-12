using System.Net.Http;

namespace SwaggerPetstoreOpenApi310.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}
