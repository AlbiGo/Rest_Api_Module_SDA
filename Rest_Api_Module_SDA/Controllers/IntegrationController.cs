using DataLayer.Models;
using DataLayer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Rest_Api_Module_SDA.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class IntegrationController : ControllerBase
    {
        [HttpGet("merrshtet")]
        public async Task<IActionResult> MerrShtetet()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://restcountries.com/v3.1/all");
            var resposne = await httpClient.GetAsync("https://restcountries.com/v3.1/all");
            var content = await resposne.Content.ReadAsStringAsync();
            var shtetet = JsonSerializer.Deserialize<List<ShtetDTO>>(content);
            return Ok(shtetet);
        }
    }
}
