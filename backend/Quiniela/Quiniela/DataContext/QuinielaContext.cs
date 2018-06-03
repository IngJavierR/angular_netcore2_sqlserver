using Quiniela.Models;
using Microsoft.EntityFrameworkCore;

namespace Quiniela.Data
{
    public class QuinielaContext: DbContext
    {
        public QuinielaContext(DbContextOptions<QuinielaContext> options) : base(options){
        }
		
        public virtual DbSet<UserDO> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDO>().ToTable("K_USER");
        }

    }
}
