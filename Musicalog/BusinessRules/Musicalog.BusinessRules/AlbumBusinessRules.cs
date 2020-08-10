using Musicalog.BusinessRules.Interfaces;
using Musicalog.Data.Interfaces;
using Musicalog.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Musicalog.BusinessRules
{
    public class AlbumBusinessRules : IAlbumBusinessRules
    {
        protected IAlbumRepository albumRepository;

        public AlbumBusinessRules(IAlbumRepository albumRepository)
        {
            this.albumRepository = albumRepository;
        }

        public async Task<IEnumerable<Album>> GetAllAlbuns()
        {
            return await albumRepository.GetAll();
        }

        public async Task<Album> GetAlbum(int id)
        {
            return await albumRepository.GetById(id);
        }

        public async Task<Album> Insert(Album newAlbum)
        {
            return await albumRepository.Add(newAlbum);
        }

        public async Task<Album> Update(Album album)
        {
            return await albumRepository.Update(album);
        }

        public async Task Remove(int id)
        {
            var album = await GetAlbum(id);
            await albumRepository.Remove(album);
        }
    }
}
