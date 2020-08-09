using Musicalog.BusinessRules.Interfaces;
using Musicalog.Data.Interfaces;
using Musicalog.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Musicalog.BusinessRules
{
    public class ArtistBusinessRules: IArtistBusinessRules
    {
        protected IArtistRepository artistRepository;

        public ArtistBusinessRules(IArtistRepository artistRepository)
        {
            this.artistRepository = artistRepository;
        }

        public async Task<IEnumerable<Artist>> GetAllArtists()
        {
            return await artistRepository.GetAll();
        }
    }
}
