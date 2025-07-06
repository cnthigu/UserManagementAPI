using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ErrorController : ControllerBase
{
    [Route("/error")]
    [HttpGet]
    public IActionResult Error()
    {
        var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
        var exception = context?.Error;

        if (HttpContext.Response.StatusCode == 500 && exception != null)
        {
            return Problem(
                detail: exception.StackTrace,
                title: exception.Message);
        }
        return Problem();
    }
}
