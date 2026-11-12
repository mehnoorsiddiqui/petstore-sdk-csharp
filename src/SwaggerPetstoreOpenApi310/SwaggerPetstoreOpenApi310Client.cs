using System.Net.Http;
using SwaggerPetstoreOpenApi310.Api;
using SwaggerPetstoreOpenApi310.Core;
using SwaggerPetstoreOpenApi310.Core.Configuration;
using SwaggerPetstoreOpenApi310.Core.Logging;
using SwaggerPetstoreOpenApi310.Core.Models;

namespace SwaggerPetstoreOpenApi310;

/// <summary>
/// This is a sample Pet Store Server based on the OpenAPI 3.1.0 specification.  You can find out more about
/// Swagger at <see href="https://swagger.io">https://swagger.io</see>. In the third iteration of the pet store, we've switched to the design first approach!
/// You can now help us improve the API whether it's by making changes to the definition itself or to the code.
/// That way, with time, we can improve the API in general, and expose some of the new features in OAS3.
/// <para>
/// Some useful links:
/// - <see href="https://github.com/swagger-api/swagger-petstore">The Pet Store repository</see>
/// - <see href="https://github.com/swagger-api/swagger-petstore/blob/master/src/main/resources/openapi.yaml">The source API definition for the Pet Store</see>
/// </para>
/// </summary>
public sealed class SwaggerPetstoreOpenApi310Client
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public SwaggerPetstoreOpenApi310Client(HttpClient httpClient, SwaggerPetstoreOpenApi310ClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory = new HeadersFactory([
            new HeaderParam("User-Agent", "SwaggerPetstoreOpenApi310Client/1.0.26 CSharp"),
            new HeaderParam("X-APIMatic-Lang", "CSharp"),
            new HeaderParam("X-APIMatic-Package-Version", "1.0.26"),
            new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
            new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
            new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime),
        ]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry, options.TimeProvider);
        var httpLogger = new HttpLogger(
            options.Logging.WithEnvironmentDefaults("SWAGGER_PETSTORE_OPEN_API310_LOG"),
            "SwaggerPetstoreOpenApi310Client",
            options.TimeProvider);
        var responseContexts = new ResponseContextFactory(options.TimeProvider, options.StreamReadTimeout);
        _rawClient =
            new RawClient(
                httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks,
                responseContexts);
        _auth = new AuthSchemes(options);
    }

    /// <summary>
    /// Everything about your Pets
    /// </summary>
    public PetApi PetApi => field ??= new PetApi(_rawClient, _server, _auth);

    /// <summary>
    /// Access to Petstore orders
    /// </summary>
    public Store Store => field ??= new Store(_rawClient, _server, _auth);

    /// <summary>
    /// Operations about user
    /// </summary>
    public UserApi UserApi => field ??= new UserApi(_rawClient, _server);
}
