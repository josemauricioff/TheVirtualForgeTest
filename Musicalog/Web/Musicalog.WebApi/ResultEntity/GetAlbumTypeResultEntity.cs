using Musicalog.WebApi.Models;
using System.Collections.Generic;

namespace Musicalog.WebApi.ResultEntity
{
    public class GetAlbumTypeResultEntity : BaseResultEntity
    {
        public IEnumerable<AlbumTypeModel> AlbumTypeList { get; set; }

    }
}
