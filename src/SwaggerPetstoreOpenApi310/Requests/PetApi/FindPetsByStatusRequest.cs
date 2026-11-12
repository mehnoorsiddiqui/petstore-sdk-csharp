using SwaggerPetstoreOpenApi310.Models.Enums;

namespace SwaggerPetstoreOpenApi310.Requests.PetApi;

/// <summary>
/// The inputs of the FindPetsByStatus operation.
/// </summary>
public sealed record FindPetsByStatusRequest
{
    /// <summary>
    /// Status values that need to be considered for filter
    /// </summary>
    public PetStatus? Status { get; init; }
}
