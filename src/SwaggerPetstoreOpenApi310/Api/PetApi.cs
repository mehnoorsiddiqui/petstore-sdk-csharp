using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SwaggerPetstoreOpenApi310.Core;
using SwaggerPetstoreOpenApi310.Core.Authentication;
using SwaggerPetstoreOpenApi310.Core.Exceptions;
using SwaggerPetstoreOpenApi310.Core.Models;
using SwaggerPetstoreOpenApi310.Core.Request;
using SwaggerPetstoreOpenApi310.Core.Response;
using SwaggerPetstoreOpenApi310.Errors;
using SwaggerPetstoreOpenApi310.Models;
using SwaggerPetstoreOpenApi310.Requests.PetApi;

namespace SwaggerPetstoreOpenApi310.Api;

/// <summary>
/// Everything about your Pets
/// </summary>
public sealed class PetApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PetApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add a new pet to the store.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pet"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="AddPetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Add a new pet to the store.
    /// </remarks>
    public Task<Pet> AddPet(AddPetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pet"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            FormUrlEncodedRequest.Create(
                new Param("name", request.Name),
                new Param("photoUrls", request.PhotoUrls),
                new Param("id", request.Id),
                new Param("category", request.Category),
                new Param("tags", request.Tags),
                new Param("status", request.Status)),
            JsonResponse.Create<Pet>(),
            AddPetError.Response,
            _auth.PetstoreAuth,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Deletes a pet.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeletePetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a pet.
    /// </remarks>
    public Task DeletePet(DeletePetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pet/{petId}"),
            [new TemplateParam("petId", request.PetId)],
            [],
            [new HeaderParam("api_key", request.ApiKey), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeletePetError.Response,
            _auth.PetstoreAuth,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Finds Pets by status.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Pet"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FindPetsByStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Multiple status values can be provided with comma separated strings.
    /// </remarks>
    public Task<IReadOnlyList<Pet>> FindPetsByStatus(FindPetsByStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pet/findByStatus"),
            [],
            [new Param("status", request.Status)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Pet>>(),
            FindPetsByStatusError.Response,
            _auth.PetstoreAuth,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Finds Pets by tags.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Pet"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="FindPetsByTagsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Multiple tags can be provided with comma separated strings. Use tag1, tag2, tag3 for testing.
    /// </remarks>
    public Task<IReadOnlyList<Pet>> FindPetsByTags(FindPetsByTagsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pet/findByTags"),
            [],
            [new Param("tags", request.Tags)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Pet>>(),
            FindPetsByTagsError.Response,
            _auth.PetstoreAuth,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Find pet by ID.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pet"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPetByIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a single pet.
    /// </remarks>
    public Task<Pet> GetPetById(GetPetByIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pet/{petId}"),
            [new TemplateParam("petId", request.PetId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Pet>(),
            GetPetByIdError.Response,
            AuthScheme.Any(_auth.ApiKey, _auth.PetstoreAuth),
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an existing pet.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pet"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdatePetError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update an existing pet by Id.
    /// </remarks>
    public Task<Pet> UpdatePet(UpdatePetRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pet"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            FormUrlEncodedRequest.Create(
                new Param("name", request.Name),
                new Param("photoUrls", request.PhotoUrls),
                new Param("id", request.Id),
                new Param("category", request.Category),
                new Param("tags", request.Tags),
                new Param("status", request.Status)),
            JsonResponse.Create<Pet>(),
            UpdatePetError.Response,
            _auth.PetstoreAuth,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Updates a pet in the store with form data.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Pet"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UpdatePetWithFormError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a pet resource based on the form data.
    /// </remarks>
    public Task<Pet> UpdatePetWithForm(UpdatePetWithFormRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pet/{petId}"),
            [new TemplateParam("petId", request.PetId)],
            [new Param("name", request.Name), new Param("status", request.Status)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<Pet>(),
            UpdatePetWithFormError.Response,
            _auth.PetstoreAuth,
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Uploads an image.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiResponseModel"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="UploadFileError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Upload image of the pet.
    /// </remarks>
    public Task<ApiResponseModel> UploadFile(UploadFileRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/pet/{petId}/uploadImage"),
            [new TemplateParam("petId", request.PetId)],
            [new Param("additionalMetadata", request.AdditionalMetadata)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            BinaryRequest.Create(request.Body),
            JsonResponse.Create<ApiResponseModel>(),
            UploadFileError.Response,
            _auth.PetstoreAuth,
            requestOptions,
            cancellationToken);
}
