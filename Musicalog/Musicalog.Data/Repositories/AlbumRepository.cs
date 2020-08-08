using Musicalog.Data.Base;
using Musicalog.Entity;
using Musicalog.Data.Interfaces;

namespace Musicalog.Data.Repositories
{
    public class AlbumRepository : EFRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(MusicalogDbContext context) : base(context)
        {
        }
    }
}
