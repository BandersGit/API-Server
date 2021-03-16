using System;
using Microsoft.AspNetCore.Mvc;

namespace API_Server.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Hej");
        }
    }
}
