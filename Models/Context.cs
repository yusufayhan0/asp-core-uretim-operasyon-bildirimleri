using Microsoft.EntityFrameworkCore;
namespace UretimOperasyonBildirimleri.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {

        }
        public DbSet<bildirim> bildirims { get; set; }
        public DbSet<duruslar> duruslars { get; set; }
        

    }
}