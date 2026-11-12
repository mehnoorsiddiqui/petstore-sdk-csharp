using System.Net.Http;

namespace SwaggerPetstoreOpenApi310.Core.Extensions;

internal static class HttpContentExtension
{
    extension(HttpContent)
    {
        public static HttpContent None => null!;
    }
}
