using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SwaggerPetstoreOpenApi310.Core;
using SwaggerPetstoreOpenApi310.Core.Authentication;
using SwaggerPetstoreOpenApi310.Core.ErrorResponse;
using SwaggerPetstoreOpenApi310.Core.Exceptions;
using SwaggerPetstoreOpenApi310.Core.Models;
using SwaggerPetstoreOpenApi310.Core.Request;
using SwaggerPetstoreOpenApi310.Core.Response;
using SwaggerPetstoreOpenApi310.Errors;
using SwaggerPetstoreOpenApi310.Models;
using SwaggerPetstoreOpenApi310.Requests.Store;

namespace SwaggerPetstoreOpenApi310.Api;

/// <summary>
/// Access to Petstore orders
/// </summary>
public sealed class Store
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Store(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete purchase order by identifier.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// For valid response try integer IDs with value &lt; 1000. Anything above 1000 or non-integers will generate API errors.
    /// </remarks>
    public Task DeleteOrder(DeleteOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/order/{orderId}"),
            [new TemplateParam("orderId", request.OrderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteOrderError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Returns pet inventories by status.
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyDictionary{TKey, TValue}"/> of <see cref="int"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a map of status codes to quantities.
    /// </remarks>
    public Task<IReadOnlyDictionary<string, int>> GetInventory(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/inventory"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyDictionary<string, int>>(),
            RawErrorResponse.Instance,
            _auth.ApiKey,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Find purchase order by ID.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrderByIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// For valid response try integer IDs with value &lt;= 5 or &gt; 10. Other values will generate exceptions.
    /// </remarks>
    public Task<Order> GetOrderById(GetOrderByIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/order/{orderId}"),
            [new TemplateParam("orderId", request.OrderId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Order>(),
            GetOrderByIdError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Place an order for a pet.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PlaceOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Place a new order in the store.
    /// </remarks>
    public Task<Order> PlaceOrder(PlaceOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/store/order"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("id", request.Id),
                new Param("petId", request.PetId),
                new Param("quantity", request.Quantity),
                new Param("shipDate", request.ShipDate),
                new Param("status", request.Status),
                new Param("complete", request.Complete)),
            JsonResponse.Create<Order>(),
            PlaceOrderError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);
}
