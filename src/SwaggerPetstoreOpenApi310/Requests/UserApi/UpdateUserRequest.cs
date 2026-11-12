namespace SwaggerPetstoreOpenApi310.Requests.UserApi;

/// <summary>
/// The inputs of the UpdateUser operation.
/// </summary>
public sealed record UpdateUserRequest
{
    /// <summary>
    /// The username that needs to be processed
    /// </summary>
    public required string CurrentUsername { get; init; }

    public long? Id { get; init; }

    public string? Username { get; init; }

    public string? FirstName { get; init; }

    public string? LastName { get; init; }

    public string? Email { get; init; }

    public string? Password { get; init; }

    public string? Phone { get; init; }

    /// <summary>
    /// User Status
    /// </summary>
    public int? UserStatus { get; init; }
}
