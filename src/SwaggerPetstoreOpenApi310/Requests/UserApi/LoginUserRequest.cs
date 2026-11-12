namespace SwaggerPetstoreOpenApi310.Requests.UserApi;

/// <summary>
/// The inputs of the LoginUser operation.
/// </summary>
public sealed record LoginUserRequest
{
    /// <summary>
    /// The user name for login
    /// </summary>
    public string? Username { get; init; }

    /// <summary>
    /// The password for login in clear text
    /// </summary>
    public string? Password { get; init; }
}
