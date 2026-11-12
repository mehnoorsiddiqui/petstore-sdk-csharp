using System;
using System.Text.Json.Serialization;
using SwaggerPetstoreOpenApi310.Core.Enum;

namespace SwaggerPetstoreOpenApi310.Models.Enums;

/// <summary>
/// Order Status
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderStatus>))]
public sealed record OrderStatus : OpenStringEnum<OrderStatus>
{
    private OrderStatus(string value) : base(value)
    {
    }

    public static readonly OrderStatus Placed = new("placed");

    public static readonly OrderStatus Approved = new("approved");

    public static readonly OrderStatus Delivered = new("delivered");

    public TResult Match<TResult>(Func<TResult> onPlaced,
        Func<TResult> onApproved,
        Func<TResult> onDelivered,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Placed => onPlaced(),
            _ when this == Approved => onApproved(),
            _ when this == Delivered => onDelivered(),
            _ => otherwise(Value)
        };

    public void Match(Action onPlaced, Action onApproved, Action onDelivered, Action<string> otherwise)
    {
        if (this == Placed) onPlaced();
        else if (this == Approved) onApproved();
        else if (this == Delivered) onDelivered();
        else otherwise(Value);
    }
}
