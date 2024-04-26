using Microsoft.AspNetCore.Mvc;

namespace AdmCondominioBack.Controllers
{
    [ApiController]
    [Route("casa")]
    public class CasaController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public Task<IActionResult> listarCasas(string search, string currentOrder, int? pagNum, string currentFilter)
        {

            return;
        }
        [HttpGet]
        [Route("listar/{id}")]
        public Task<IActionResult> listarCasaById()
        {
            return;
        }


    }
}
