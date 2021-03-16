using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace API_Server.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController : ControllerBase
    {
        static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Lickitongue"},
            new Pokemon() {Name = "Squirtle"}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(pokemons[0]);
        }
    }
}
