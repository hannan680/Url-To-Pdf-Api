using Microsoft.AspNetCore.Mvc;
using MyChromeExtensionBackend.Converters; // Import the namespace for the model
using MyChromeExtensionBackend.Models; // Import the namespace for the model

namespace MyChromeExtensionBackend.Controllers
{
    [Route("api/pdf")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        [HttpPost("generate")]
        public IActionResult GeneratePdf([FromBody] PdfRequestModel request)
        {
                   if (request == null || string.IsNullOrWhiteSpace(request.Url))
            {
                return BadRequest("Invalid request.");
            }

            string url = request.Url;
             PdfConverter.UrlToPdf(url);
            
            // Perform PDF generation logic here
            // Return PDF content or file path
            return Ok();
            
        }
    }
}
