using System.Collections.Generic;

namespace SwaggerPetstoreOpenApi310.Requests.PetApi;

/// <summary>
/// The inputs of the FindPetsByTags operation.
/// </summary>
public sealed record FindPetsByTagsRequest
{
    /// <summary>
    /// Tags to filter by
    /// </summary>
    public IReadOnlyList<string>? Tags { get; init; }
}
