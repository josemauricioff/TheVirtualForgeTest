using Musicalog.Data.Base;
using Musicalog.Entity;
using Musicalog.Data.Interfaces;

namespace Musicalog.Data.Repositories
{
    public class AlbumTypeRepository : EFRepository<AlbumType>, IAlbumTypeRepository
    {
        public AlbumTypeRepository(MusicalogDbContext context) : base(context)
        {
        }
    }
}
