using Dapr;
using Dapr.Client;
using DaprRestaurantCommon;
using Microsoft.AspNetCore.Mvc;

namespace DaprRestaurantKitchen.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class OrderController(DaprClient daprClient, ILogger<OrderController>? logger) : ControllerBase
    {
        private readonly DaprClient _daprClient = daprClient ?? throw new ArgumentNullException(nameof(daprClient));
        private readonly ILogger<OrderController>? _logger = logger;
        private const string storeName = "statestore";
        [Topic("pubsub", "orderplaced")]
        [Route("products")]
        [HttpPost]
        public async Task<ActionResult> OrderRecieved([FromBody] OrderInputDto orderInputDto)
        {
            try
            {

                _logger?.LogInformation("I have recived order number {0}", orderInputDto.OrderNumber.ToString());

                var orderFromDb = await _daprClient.GetStateAsync<OrderInputDto>(storeName, orderInputDto.OrderNumber.ToString());
                if (orderFromDb != null)
                {
                    _logger?.LogInformation("Order Items {0}", orderFromDb.OrderItems.ToString());
                }
                else
                {
                    _logger?.LogError("No Order found");
                }
                return Ok();
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, ex.Message);
                return BadRequest();
            }
        }
    }
}