using SwaggerPetstoreOpenApi310.Servers;

namespace SwaggerPetstoreOpenApi310;

public class ServerOptions
{
    public DefaultOptions Default { get; set; } = new();
    public AuthServerOptions AuthServer { get; set; } = new();
}
