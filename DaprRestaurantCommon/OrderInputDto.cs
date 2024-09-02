using System.Text.Json.Serialization;

namespace DaprRestaurantCommon;

public class OrderInputDto
{
    [JsonPropertyName("orderNumber")]
    public Guid OrderNumber = Guid.NewGuid();

    [JsonPropertyName("customerName")]
    public string CustomerName { get; set; } = string.Empty;
    [JsonPropertyName("customerAddress")]
    public string CustomerAddress { get; set; } = string.Empty;
    [JsonPropertyName("orderItems")]
    public string OrderItems { get; set; } = string.Empty;
    [JsonPropertyName("notes")]
    public string Notes { get; set; } = string.Empty;
}
