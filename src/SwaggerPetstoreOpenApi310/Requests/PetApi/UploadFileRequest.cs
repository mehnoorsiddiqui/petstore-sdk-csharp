using SwaggerPetstoreOpenApi310.Core.Models;

namespace SwaggerPetstoreOpenApi310.Requests.PetApi;

/// <summary>
/// The inputs of the UploadFile operation.
/// </summary>
public sealed record UploadFileRequest
{
    /// <summary>
    /// ID of pet to update
    /// </summary>
    public required long PetId { get; init; }

    /// <summary>
    /// Additional Metadata
    /// </summary>
    public string? AdditionalMetadata { get; init; }

    public BinaryContent? Body { get; init; }
}
