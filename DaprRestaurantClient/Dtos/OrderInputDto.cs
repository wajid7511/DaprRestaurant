using System;

namespace DaprRestaurantClient.Dtos;

public class OrderInputDto
{
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerAddress { get; set; } = string.Empty;
    public string OrderItems { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
}
