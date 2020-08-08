using Musicalog.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Musicalog.BusinessRules.Interfaces
{
    public interface IAlbumBusinessRules
    {
        Task<Album> Insert(Album newAlbum);
        Task<Album> Update(Album album);
        Task<IEnumerable<Album>> GetAllAlbuns();
    }
}
