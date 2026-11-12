namespace SwaggerPetstoreOpenApi310.Requests.Store;

/// <summary>
/// The inputs of the GetOrderById operation.
/// </summary>
public sealed record GetOrderByIdRequest
{
    /// <summary>
    /// ID of order that needs to be fetched
    /// </summary>
    public required long OrderId { get; init; }
}
