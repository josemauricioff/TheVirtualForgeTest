using Musicalog.Data.Base;
using Musicalog.Entity;
using Musicalog.Data.Interfaces;

namespace Musicalog.Data.Repositories
{
    public class ArtistRepository : EFRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(MusicalogDbContext context) : base(context)
        {
        }
    }
}
