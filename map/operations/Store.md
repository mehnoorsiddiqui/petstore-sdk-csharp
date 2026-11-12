<!-- Generated file — do not edit; regenerated with the SDK. -->

# Store — operations

Accessor: `client.Store` · Source: `src/SwaggerPetstoreOpenApi310/Api/Store.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteOrder

- **Signature**: `DeleteOrder(DeleteOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400, 404] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOrderRequest` | `src/SwaggerPetstoreOpenApi310/Requests/Store/DeleteOrderRequest.cs` |
| `DeleteOrderError` | `src/SwaggerPetstoreOpenApi310/Errors/DeleteOrderError.cs` |

### GetInventory

- **Auth**: `options.ApiKey`
- **Signature**: `GetInventory(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyDictionary<string, int>`
- **Error**: `ApiException<RawError>` — **Case B**

### GetOrderById

- **Signature**: `GetOrderById(GetOrderByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Returns**: `Order`
- **Error**: `ApiException<GetOrderByIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400, 404] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrderByIdRequest` | `src/SwaggerPetstoreOpenApi310/Requests/Store/GetOrderByIdRequest.cs` |
| `Order` | `src/SwaggerPetstoreOpenApi310/Models/Order.cs` |
| `GetOrderByIdError` | `src/SwaggerPetstoreOpenApi310/Errors/GetOrderByIdError.cs` |

### PlaceOrder

- **Signature**: `PlaceOrder(PlaceOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Order`
- **Error**: `ApiException<PlaceOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent([NotNullWhen(true)] out RawError? value)` [400, 422] · `TryGetRawError([NotNullWhen(true)] out RawError? error)` [fallback]

| Type | Source |
| --- | --- |
| `PlaceOrderRequest` | `src/SwaggerPetstoreOpenApi310/Requests/Store/PlaceOrderRequest.cs` |
| `OrderStatus` | `src/SwaggerPetstoreOpenApi310/Models/Enums/OrderStatus.cs` |
| `Order` | `src/SwaggerPetstoreOpenApi310/Models/Order.cs` |
| `PlaceOrderError` | `src/SwaggerPetstoreOpenApi310/Errors/PlaceOrderError.cs` |

