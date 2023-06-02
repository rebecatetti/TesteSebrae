using Microsoft.AspNetCore.Mvc;
using TesteSebrae.Application.Interfaces;
using TesteSebrae.Domain.Repositories;

namespace TesteSebraeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaControllerAPI : ControllerBase
    {
        private readonly IContaService _contaServices;

        public ContaControllerAPI(IContaService contaServices)
        {
            _contaServices = contaServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _contaServices.Get();

            return result == null ? NotFound() : Ok(result);
        }
    }
}
