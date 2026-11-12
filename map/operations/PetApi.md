<!-- Generated file — do not edit; regenerated with the SDK. -->

# PetApi — operations

Accessor: `client.PetApi` · Source: `src/SwaggerPetstoreOpenApi310/Api/PetApi.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddPet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `AddPet(AddPetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`, `PhotoUrls`
- **Returns**: `Pet`
- **Error**: `ApiException<AddPetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400, 422] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `AddPetRequest` | `src/SwaggerPetstoreOpenApi310/Requests/PetApi/AddPetRequest.cs` |
| `Category` | `src/SwaggerPetstoreOpenApi310/Models/Category.cs` |
| `Tag` | `src/SwaggerPetstoreOpenApi310/Models/Tag.cs` |
| `PetStatus` | `src/SwaggerPetstoreOpenApi310/Models/Enums/PetStatus.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi310/Models/Pet.cs` |
| `AddPetError` | `src/SwaggerPetstoreOpenApi310/Errors/AddPetError.cs` |

### DeletePet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `DeletePet(DeletePetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeletePetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePetRequest` | `src/SwaggerPetstoreOpenApi310/Requests/PetApi/DeletePetRequest.cs` |
| `DeletePetError` | `src/SwaggerPetstoreOpenApi310/Errors/DeletePetError.cs` |

### FindPetsByStatus

- **Auth**: `options.PetstoreAuth`
- **Signature**: `FindPetsByStatus(FindPetsByStatusRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`
- **Returns**: `IReadOnlyList<Pet>`
- **Error**: `ApiException<FindPetsByStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `FindPetsByStatusRequest` | `src/SwaggerPetstoreOpenApi310/Requests/PetApi/FindPetsByStatusRequest.cs` |
| `PetStatus` | `src/SwaggerPetstoreOpenApi310/Models/Enums/PetStatus.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi310/Models/Pet.cs` |
| `FindPetsByStatusError` | `src/SwaggerPetstoreOpenApi310/Errors/FindPetsByStatusError.cs` |

### FindPetsByTags

- **Auth**: `options.PetstoreAuth`
- **Signature**: `FindPetsByTags(FindPetsByTagsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `tags` ← `Tags`
- **Returns**: `IReadOnlyList<Pet>`
- **Error**: `ApiException<FindPetsByTagsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `FindPetsByTagsRequest` | `src/SwaggerPetstoreOpenApi310/Requests/PetApi/FindPetsByTagsRequest.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi310/Models/Pet.cs` |
| `FindPetsByTagsError` | `src/SwaggerPetstoreOpenApi310/Errors/FindPetsByTagsError.cs` |

### GetPetById

- **Auth**: `options.ApiKey` OR `options.PetstoreAuth`
- **Signature**: `GetPetById(GetPetByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Returns**: `Pet`
- **Error**: `ApiException<GetPetByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400, 404] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `GetPetByIdRequest` | `src/SwaggerPetstoreOpenApi310/Requests/PetApi/GetPetByIdRequest.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi310/Models/Pet.cs` |
| `GetPetByIdError` | `src/SwaggerPetstoreOpenApi310/Errors/GetPetByIdError.cs` |

### UpdatePet

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UpdatePet(UpdatePetRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`, `PhotoUrls`
- **Returns**: `Pet`
- **Error**: `ApiException<UpdatePetError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400, 404, 422] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePetRequest` | `src/SwaggerPetstoreOpenApi310/Requests/PetApi/UpdatePetRequest.cs` |
| `Category` | `src/SwaggerPetstoreOpenApi310/Models/Category.cs` |
| `Tag` | `src/SwaggerPetstoreOpenApi310/Models/Tag.cs` |
| `PetStatus` | `src/SwaggerPetstoreOpenApi310/Models/Enums/PetStatus.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi310/Models/Pet.cs` |
| `UpdatePetError` | `src/SwaggerPetstoreOpenApi310/Errors/UpdatePetError.cs` |

### UpdatePetWithForm

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UpdatePetWithForm(UpdatePetWithFormRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Query params (wire ← C#)**: `name` ← `Name`, `status` ← `Status`
- **Returns**: `Pet`
- **Error**: `ApiException<UpdatePetWithFormError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `UpdatePetWithFormRequest` | `src/SwaggerPetstoreOpenApi310/Requests/PetApi/UpdatePetWithFormRequest.cs` |
| `Pet` | `src/SwaggerPetstoreOpenApi310/Models/Pet.cs` |
| `UpdatePetWithFormError` | `src/SwaggerPetstoreOpenApi310/Errors/UpdatePetWithFormError.cs` |

### UploadFile

- **Auth**: `options.PetstoreAuth`
- **Signature**: `UploadFile(UploadFileRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PetId`
- **Query params (wire ← C#)**: `additionalMetadata` ← `AdditionalMetadata`
- **Returns**: `ApiResponseModel`
- **Error**: `ApiException<UploadFileError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400, 404] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `UploadFileRequest` | `src/SwaggerPetstoreOpenApi310/Requests/PetApi/UploadFileRequest.cs` |
| `ApiResponseModel` | `src/SwaggerPetstoreOpenApi310/Models/ApiResponseModel.cs` |
| `UploadFileError` | `src/SwaggerPetstoreOpenApi310/Errors/UploadFileError.cs` |

