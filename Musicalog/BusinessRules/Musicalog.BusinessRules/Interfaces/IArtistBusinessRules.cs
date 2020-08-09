using Musicalog.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Musicalog.BusinessRules.Interfaces
{
    public interface IArtistBusinessRules
    {
        Task<IEnumerable<Artist>> GetAllArtists();
    }
}
