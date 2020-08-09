using Musicalog.Entity;
using System.Collections.Generic;

namespace Musicalog.WebApi.ResultEntity
{
    public class GetArtistResultEntity : BaseResultEntity
    {
        public IEnumerable<Artist> ArtistList { get; set; }

    }
}
