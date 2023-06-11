using Microsoft.EntityFrameworkCore;
using PrimeiroSite.Models;

namespace PrimeiroSite.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext>options) : base(options) 
        { 
        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
