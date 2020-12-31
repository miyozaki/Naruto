using Microsoft.EntityFrameworkCore;
using Naruto.Entities;
using Ninja = Naruto.Pages.Ninja;

namespace Naruto.DbContexts
{
    public class NarutoContext : DbContext
    {
        public NarutoContext(DbContextOptions<NarutoContext> options) : base(options)
        { }

        public DbSet<Shinobi> Shinobis { get; set; }
        public DbSet<Tier> Tiers { get; set; }
    }
    
}