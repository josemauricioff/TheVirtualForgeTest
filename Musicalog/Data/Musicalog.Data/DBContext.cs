using Microsoft.EntityFrameworkCore;
using Musicalog.Entity;

namespace Musicalog.Data
{
    public class MusicalogDbContext : DbContext
    {
        public MusicalogDbContext(DbContextOptions<MusicalogDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Album>()
                    .HasOne(a => a.Albumtype)
                    .WithMany(at => at.AlbumList)
                    .HasForeignKey(a => a.AlbumTypeId);

            builder.Entity<Album>()
                    .HasOne(a => a.Artist)
                    .WithMany(at => at.AlbumList)
                    .HasForeignKey(a => a.ArtistId);
        }
        public DbSet<Album> Album { get; set; }
        public DbSet<AlbumType> AlbumType { get; set; }
        public DbSet<Artist> Artist { get; set; }
    }
}
