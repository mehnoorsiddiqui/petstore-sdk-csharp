namespace SwaggerPetstoreOpenApi310.Requests.PetApi;

/// <summary>
/// The inputs of the DeletePet operation.
/// </summary>
public sealed record DeletePetRequest
{
    /// <summary>
    /// Pet id to delete
    /// </summary>
    public required long PetId { get; init; }

    public string? ApiKey { get; init; }
}
