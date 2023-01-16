using Microsoft.AspNetCore.Mvc;

namespace SommeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SommeController : ControllerBase
{
    [HttpGet]
    public ActionResult<int> Add(int a, int b)
    {
        return Ok(a + b);
    }
}