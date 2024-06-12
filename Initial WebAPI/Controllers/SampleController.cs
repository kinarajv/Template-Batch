using Microsoft.AspNetCore.Mvc;

namespace Initial_WebAPI;

[ApiController]
[Route("api/[controller]")]
public class SampleController : ControllerBase
{
	[HttpGet]
	public IActionResult GetSample() 
	{
		return Ok("Hello World");
	}
}
