using Musicalog.WebApi.Models;
using System.Collections.Generic;

namespace Musicalog.WebApi.ResultEntity
{
    public class GetAllAlbumResultEntity: BaseResultEntity
    {
        public IEnumerable<GetAlbumModel> AlbumList { get; set; }
    }
}
