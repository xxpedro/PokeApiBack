using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PruebaIngreso.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        [HttpGet("{name}")]
        public async Task<IActionResult> getPokemon(string name) {

            string url = "https://pokeapi.co/api/v2/pokemon/" + name;

            using (WebClient json = new WebClient())
            {
                var datos = await json.DownloadStringTaskAsync(url);
                return Ok(datos);
            }
        }
    }
}
