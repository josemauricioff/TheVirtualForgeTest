using Musicalog.WebApi.Models;
using System.Collections.Generic;

namespace Musicalog.WebApi.ResultEntity
{
    public class GetArtistResultEntity : BaseResultEntity
    {
        public IEnumerable<ArtistModel> ArtistList { get; set; }

    }
}
