using System.Collections.Generic;
using SwaggerPetstoreOpenApi310.Models;
using SwaggerPetstoreOpenApi310.Models.Enums;

namespace SwaggerPetstoreOpenApi310.Requests.PetApi;

/// <summary>
/// The inputs of the AddPet operation.
/// </summary>
public sealed record AddPetRequest
{
    public required string Name { get; init; }

    public required IReadOnlyList<string> PhotoUrls { get; init; }

    public long? Id { get; init; }

    public Category? Category { get; init; }

    public IReadOnlyList<Tag>? Tags { get; init; }

    /// <summary>
    /// pet status in the store
    /// </summary>
    public PetStatus? Status { get; init; }
}
