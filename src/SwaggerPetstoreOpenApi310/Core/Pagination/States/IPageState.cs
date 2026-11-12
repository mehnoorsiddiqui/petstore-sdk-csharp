using System.Net.Http.Headers;

namespace SwaggerPetstoreOpenApi310.Core.Pagination.States;

internal interface IPageState<in TResponse, out TState>
{
    TState? Next(TResponse page, HttpResponseHeaders headers, int itemCount);
}
