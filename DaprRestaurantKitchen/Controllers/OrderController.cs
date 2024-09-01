using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class OrderController : ControllerBase
{
    [HttpPost]
    public void OrderRecieved()
    {

    }
}