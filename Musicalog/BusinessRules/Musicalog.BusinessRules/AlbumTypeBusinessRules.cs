using Musicalog.BusinessRules.Interfaces;
using Musicalog.Data.Interfaces;
using Musicalog.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Musicalog.BusinessRules
{
    public class AlbumTypeBusinessRules: IAlbumTypeBusinessRules
    {
        protected IAlbumTypeRepository albumTypeRepository;

        public AlbumTypeBusinessRules(IAlbumTypeRepository albumTypeRepository)
        {
            this.albumTypeRepository = albumTypeRepository;
        }

        public async Task<IEnumerable<AlbumType>> GetAllAlbumTypes()
        {
            return await albumTypeRepository.GetAll();
        }
    }
}
