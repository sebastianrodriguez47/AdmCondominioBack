using Microsoft.AspNetCore.Mvc;

namespace AdmCondominioBack.Controllers
{
    [ApiController]
    [Route("jefeHogar")]
    public class JefeHogarController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarJefesHogar()
        {

        }
        [HttpGet]
        [Route("listar/{id}")]
        public dynamic listarJefesHogarById()
        {

        }


    }
}
