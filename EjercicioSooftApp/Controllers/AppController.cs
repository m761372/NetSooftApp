

using EjercicioSooftApp.Models;
using EjercicioSooftApp.Services;
using EjercicioSooftApp.Services.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace EjercicioSooftApp.Controllers
{
    public class AppController : ApiController
    {
        private readonly IAppService _service;

        AppController()
        {
            _service = new AppService();
        }


        [HttpPost]
        [Route("api/cliente")]
        public async Task<OkNegotiatedContentResult<string>> AddCliente(Cliente request)
        {
            await _service.AddClienteAsync(request);

            return Ok("Registro ingresado exitosamente!");
        }

        [HttpGet]
        [Route("api/clientes/by-pais/{codigoPais}")]
        public IEnumerable<Cliente> GetClientesByCodigoPais([FromUri] int codigoPais)
        {
            return _service.GetClientesByCodigoPais(codigoPais);
        }

        [HttpGet]
        [Route("api/pais-cliente/total")]
        public IEnumerable<PaisTotalCliente> GetTotalClientesCodigoPais()
        {
            return _service.GetTotalClientesCodigoPais();
        }

        [HttpGet]
        [Route("api/pais-cliente/{codigoPais}/total")]
        public PaisTotalCliente GetTotalClientesCodigoPais([FromUri] int codigoPais)
        {
            return _service.GetTotalClientesByCodigoPais(codigoPais);
        }

        [HttpGet]
        [Route("api/cliente/dominio-email/{dominioEmail}/total")]
        public long GetTotalClientesCodigoPais([FromUri] string dominioEmail)
        {
            return _service.GetTotalClientesByDominioEmail(dominioEmail);
        }
    }
}
