
using System.Data.Entity;

namespace SportsX.Models
{
    public class ClienteDbContext : DbContext 
    { 
        public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Telefone> Telefones { get; set; }
    }
}