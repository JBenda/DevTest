using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevTaskJulianBenda.Models;

namespace DevTaskJulianBenda.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeicodeMinima : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        [HttpGet]
        public async Task<IEnumerable<Typeicode>> GetTypeicodesWithMinima() {
            string respondString = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            return JsonSerializer.Deserialize<IEnumerable<Typeicode>>(respondString)
                .Where(code => code.body.Contains("minima"));
        }
    }
}