namespace SwaggerPetstoreOpenApi310.Requests.UserApi;

/// <summary>
/// The inputs of the DeleteUser operation.
/// </summary>
public sealed record DeleteUserRequest
{
    /// <summary>
    /// The username that needs to be processed
    /// </summary>
    public required string CurrentUsername { get; init; }
}
