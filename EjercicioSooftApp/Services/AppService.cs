using EjercicioSooftApp.Models;
using EjercicioSooftApp.Services.Responses;
using NetSooftApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;

namespace EjercicioSooftApp.Services
{
    public class AppService : IAppService
    {
        /// <summary>
        /// Realiza el insert de un registro Cliente en la 
        /// base de datos
        /// </summary>
        /// <param name="cliente">Objeto Entidad a insertar en la bd</param>
        public async Task AddClienteAsync(Cliente cliente)
        {
            try
            {
                using (var _db = new SooftAppContext())
                {
                    _db.Clientes.Add(cliente);

                    await _db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en alta de Cliente");
            }
        }

        /// <summary>
        /// Obtiene los clientes pertenecientes a un código de pais
        /// </summary>
        /// <param name="codigoPais"></param>
        /// <returns>Lista de clientes</returns>
        public IEnumerable<Cliente> GetClientesByCodigoPais(int codigoPais)
        {
            try
            {
                IEnumerable<Cliente> clientes;
                using (var _db = new SooftAppContext())
                {
                    clientes = _db.Clientes
                        .Include(c => c.TipoCliente)
                        .Include(c => c.Direccion)
                        .Include(c => c.Direccion.DireccionPais)
                        .Where(c => c.Direccion.DireccionPaisId == codigoPais).ToList();
                }

                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la búsqueda");
            }
        }

        /// <summary>
        /// Obtiene la cantidad de clientes agrupado por país
        /// </summary>
        /// <returns>Listado cantidad clientes por país</returns>
        public IEnumerable<PaisTotalCliente> GetTotalClientesCodigoPais()
        {
            try
            {
                IEnumerable<PaisTotalCliente> paisCliente;
                using (var _db = new SooftAppContext())
                {
                    paisCliente = _db.Clientes.GroupBy(clientes => new { clientes.Direccion.DireccionPaisId, clientes.Direccion.DireccionPais.Nombre })
                     .Select(group => new PaisTotalCliente
                      {
                          CodigoPais = group.Key.DireccionPaisId,
                          Pais = group.Key.Nombre,
                          CantidadClientes = group.Count()
                      })
                     .OrderBy(x => x.Pais)
                     .ToList();
                }
                return paisCliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la búsqueda");
            }
        }

        /// <summary>
        /// Obtiene la cantidad de clientes por código país
        /// </summary>
        /// <returns>Listado cantidad clientes por código país</returns>
        public PaisTotalCliente GetTotalClientesByCodigoPais(int codigoPais)
        {
            try
            {
                PaisTotalCliente paisCliente;
                using (var _db = new SooftAppContext())
                {
                    paisCliente = _db.Clientes.GroupBy(info => new { info.Direccion.DireccionPaisId, info.Direccion.DireccionPais.Nombre })
                     .Where(x => x.Key.DireccionPaisId == codigoPais)
                     .Select(group => new PaisTotalCliente
                     {
                         CodigoPais = group.Key.DireccionPaisId,
                         Pais = group.Key.Nombre,
                         CantidadClientes = group.Count()
                     })
                     .FirstOrDefault();
                }
                return paisCliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la búsqueda");
            }
        }
        /// <summary>
        /// Obtiene la cantidad de clientes que tengan el dominio de email
        /// parametrizado
        /// </summary>
        /// <param name="dominioEmail"></param>
        /// <returns>Cantaidad de clientes por dominio de email</returns>
        public long GetTotalClientesByDominioEmail(string dominioEmail)
        {
            try
            {
                long total;
                using (var _db = new SooftAppContext())
                {
                    total = _db.Clientes.AsEnumerable()
                     .Count(x => x.Email.Split('@')[1].Contains(dominioEmail));
                    
                }
                return total;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la búsqueda");
            }
        }
    }
}