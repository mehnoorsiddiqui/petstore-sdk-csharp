namespace SwaggerPetstoreOpenApi310.Requests.PetApi;

/// <summary>
/// The inputs of the UpdatePetWithForm operation.
/// </summary>
public sealed record UpdatePetWithFormRequest
{
    /// <summary>
    /// ID of pet that needs to be updated
    /// </summary>
    public required long PetId { get; init; }

    /// <summary>
    /// Name of pet that needs to be updated
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Status of pet that needs to be updated
    /// </summary>
    public string? Status { get; init; }
}
