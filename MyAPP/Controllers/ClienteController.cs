using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MyAPP.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAPP.Controllers
{
    public interface IClienteController
    {
        Task<List<Cliente>> Get();
        Task<int> Insert(Cliente Entidad);
    }
    public class ClienteController:IClienteController
    {
        readonly IDbContextFactory<dbContext> db;
        public ClienteController(IDbContextFactory<dbContext> dbContextFactory)
        {
            db = dbContextFactory;
        }
        public async Task<List<Cliente>> Get()
        {
            using var Conexion = db.CreateDbContext();
            return await Conexion.Cliente.ToListAsync();
        }
        public async Task<int> Insert(Cliente Entidad)
        {
            using var Conexion = db.CreateDbContext();
            Conexion.Cliente.Add(Entidad);
            await Conexion.SaveChangesAsync();
            return Entidad.IdCliente;
        }
    }
}
