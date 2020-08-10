using Musicalog.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Musicalog.BusinessRules.Interfaces
{
    public interface IAlbumBusinessRules
    {
        Task<Album> Insert(Album newAlbum);
        Task<Album> Update(Album album);
        Task<IEnumerable<Album>> GetAllAlbuns();
        Task<Album> GetAlbum(int id);
        Task Remove(int id);
    }
}
