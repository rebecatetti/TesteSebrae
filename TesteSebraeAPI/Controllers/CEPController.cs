using Microsoft.AspNetCore.Mvc;
using RestSharp;
using TesteSebrae.Application.Interfaces;
using TesteSebrae.Application.Models;

namespace TesteSebraeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CEPController : ControllerBase
    {
        private readonly ICEPService _CEPServices;

        public CEPController(ICEPService CEPServices)
        {
            _CEPServices = CEPServices;
        }

        [HttpGet(Name = "CEP")]
        public async Task<IActionResult> Get()
        {
            var result = await _CEPServices.GetCEP();

            return result == null ? NotFound() : Ok(result);
        }
    }
}
