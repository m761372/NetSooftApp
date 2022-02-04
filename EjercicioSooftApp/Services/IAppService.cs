using EjercicioSooftApp.Models;
using EjercicioSooftApp.Services.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSooftApp.Services
{
    public interface IAppService
    {
        Task AddClienteAsync(Cliente cliente);
        IEnumerable<Cliente> GetClientesByCodigoPais(int codigoPais);
        IEnumerable<PaisTotalCliente> GetTotalClientesCodigoPais();
        PaisTotalCliente GetTotalClientesByCodigoPais(int codigoPais);
        long GetTotalClientesByDominioEmail(string dominioEmail);
    }
}
