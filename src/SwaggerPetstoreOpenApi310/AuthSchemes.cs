using SwaggerPetstoreOpenApi310.Core;
using SwaggerPetstoreOpenApi310.Core.Authentication;
using SwaggerPetstoreOpenApi310.Core.Authentication.ApiKey;

namespace SwaggerPetstoreOpenApi310;

internal sealed class AuthSchemes
{
    public IAuthScheme PetstoreAuth { get; }
    public IAuthScheme ApiKey { get; }

    public AuthSchemes(SwaggerPetstoreOpenApi310ClientOptions options)
    {
        PetstoreAuth =
            ApiKeyHeaderScheme.Create(
                "PetstoreAuth",
                "Authorization",
                options.PetstoreAuthProvider,
                options.PetstoreAuth ?? EnvironmentVariables.Get("SWAGGER_PETSTORE_OPEN_API310_PETSTORE_AUTH"));
        ApiKey =
            ApiKeyHeaderScheme.Create(
                "ApiKey",
                "api_key",
                options.ApiKeyProvider,
                options.ApiKey ?? EnvironmentVariables.Get("SWAGGER_PETSTORE_OPEN_API310_API_KEY"));
    }
}
