using System;
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
using SwaggerPetstoreOpenApi310.Requests.UserApi;

namespace SwaggerPetstoreOpenApi310.Api;

/// <summary>
/// Operations about user
/// </summary>
public sealed class UserApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal UserApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create user.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This can only be done by the logged in user.
    /// </remarks>
    public Task<User> CreateUser(CreateUserRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/user"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("id", request.Id),
                new Param("username", request.Username),
                new Param("firstName", request.FirstName),
                new Param("lastName", request.LastName),
                new Param("email", request.Email),
                new Param("password", request.Password),
                new Param("phone", request.Phone),
                new Param("userStatus", request.UserStatus)),
            JsonResponse.Create<User>(),
            RawErrorResponse.Instance,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Creates list of users with given input array.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates list of users with given input array.
    /// </remarks>
    public Task<User> CreateUsersWithListInput(CreateUsersWithListInputRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/user/createWithList"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<User>(),
            RawErrorResponse.Instance,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete user resource.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This can only be done by the logged in user.
    /// </remarks>
    public Task DeleteUser(DeleteUserRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/user/{usersname}"),
            [new TemplateParam("usersname", request.CurrentUsername)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteUserError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get user by user name.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetUserByNameError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get user detail based on username.
    /// </remarks>
    public Task<User> GetUserByName(GetUserByNameRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/user/{usersname}"),
            [new TemplateParam("usersname", request.CurrentUsername)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<User>(),
            GetUserByNameError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Logs user into the system.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="LoginUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Log into the system.
    /// </remarks>
    public Task LoginUser(LoginUserRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/user/login"),
            [],
            [new Param("username", request.Username), new Param("password", request.Password)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            LoginUserError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Logs out current logged in user session.
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Log user out of the system.
    /// </remarks>
    public Task LogoutUser(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/user/logout"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            AuthScheme.None,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update user resource.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdateUserError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This can only be done by the logged in user.
    /// </remarks>
    public Task UpdateUser(UpdateUserRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/user/{usersname}"),
            [new TemplateParam("usersname", request.CurrentUsername)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            FormUrlEncodedRequest.Create(
                new Param("id", request.Id),
                new Param("username", request.Username),
                new Param("firstName", request.FirstName),
                new Param("lastName", request.LastName),
                new Param("email", request.Email),
                new Param("password", request.Password),
                new Param("phone", request.Phone),
                new Param("userStatus", request.UserStatus)),
            VoidResponse.Instance,
            UpdateUserError.Response,
            AuthScheme.None,
            requestOptions,
            cancellationToken);
}
