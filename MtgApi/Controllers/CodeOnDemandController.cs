using Microsoft.AspNetCore.Mvc;

namespace MtgApi.Controllers;

[ApiController]
[Route("/cod")]
public class CodeOnDemandController : ControllerBase
{
  private readonly string code = "<script> alert('Hola, este es un mensaje de alerta!') </script>";

  [HttpGet(Name = "GetTime")]
  public ContentResult GetTime()
  {
    return Content(code, "text/html");
  }
}