using Musicalog.Entity;
using System.Collections.Generic;

namespace Musicalog.WebApi.ResultEntity
{
    public class GetAlbumTypeResultEntity : BaseResultEntity
    {
        public IEnumerable<AlbumType> AlbumTypeList { get; set; }

    }
}
