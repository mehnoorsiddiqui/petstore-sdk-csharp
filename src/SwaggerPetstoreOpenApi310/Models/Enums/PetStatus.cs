using System;
using System.Text.Json.Serialization;
using SwaggerPetstoreOpenApi310.Core.Enum;

namespace SwaggerPetstoreOpenApi310.Models.Enums;

/// <summary>
/// pet status in the store
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PetStatus>))]
public sealed record PetStatus : OpenStringEnum<PetStatus>
{
    private PetStatus(string value) : base(value)
    {
    }

    public static readonly PetStatus Available = new("available");

    public static readonly PetStatus Pending = new("pending");

    public static readonly PetStatus Sold = new("sold");

    public TResult Match<TResult>(Func<TResult> onAvailable,
        Func<TResult> onPending,
        Func<TResult> onSold,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Available => onAvailable(),
            _ when this == Pending => onPending(),
            _ when this == Sold => onSold(),
            _ => otherwise(Value)
        };

    public void Match(Action onAvailable, Action onPending, Action onSold, Action<string> otherwise)
    {
        if (this == Available) onAvailable();
        else if (this == Pending) onPending();
        else if (this == Sold) onSold();
        else otherwise(Value);
    }
}
