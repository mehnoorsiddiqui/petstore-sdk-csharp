namespace SwaggerPetstoreOpenApi310.Requests.PetApi;

/// <summary>
/// The inputs of the GetPetById operation.
/// </summary>
public sealed record GetPetByIdRequest
{
    /// <summary>
    /// ID of pet to return
    /// </summary>
    public required long PetId { get; init; }
}
