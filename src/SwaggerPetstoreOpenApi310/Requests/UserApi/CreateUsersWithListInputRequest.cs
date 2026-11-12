using System.Collections.Generic;
using SwaggerPetstoreOpenApi310.Models;

namespace SwaggerPetstoreOpenApi310.Requests.UserApi;

/// <summary>
/// The inputs of the CreateUsersWithListInput operation.
/// </summary>
public sealed record CreateUsersWithListInputRequest
{
    public IReadOnlyList<User>? Body { get; init; }
}
