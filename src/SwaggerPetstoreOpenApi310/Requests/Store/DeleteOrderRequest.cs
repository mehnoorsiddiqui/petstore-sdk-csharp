namespace SwaggerPetstoreOpenApi310.Requests.Store;

/// <summary>
/// The inputs of the DeleteOrder operation.
/// </summary>
public sealed record DeleteOrderRequest
{
    /// <summary>
    /// ID of the order that needs to be deleted
    /// </summary>
    public required long OrderId { get; init; }
}
