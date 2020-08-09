using Musicalog.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Musicalog.BusinessRules.Interfaces
{
    public interface IAlbumTypeBusinessRules
    {
        Task<IEnumerable<AlbumType>> GetAllAlbumTypes();

    }
}
