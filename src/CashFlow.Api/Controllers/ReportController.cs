using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace CashFlow.Api.Controllers
{
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        [HttpGet("excel")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> GetExcel()
        {
            byte[] file = new byte[1];

            if (file.Length > 0)
                return File(file, MediaTypeNames.Application.Octet, "report.xlsx");
            return NoContent();
        }
    }
}
