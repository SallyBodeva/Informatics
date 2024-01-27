using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReviesSIte.Data.Models;

namespace ReviewsSite.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Owner>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Review> Reviews { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Review>()
                .HasOne(x => x.Owner)
                .WithMany(x => x.Reviews)
                .HasForeignKey(x => x.OwnerId);
            base.OnModelCreating(builder);
        }
    }
}
