using Musicalog.Entity;
using System.Collections.Generic;

namespace Musicalog.WebApi.ResultEntity
{
    public class GetAlbumResultEntity: BaseResultEntity
    {
        public IEnumerable<Album> AlbumList { get; set; }
    }
}
