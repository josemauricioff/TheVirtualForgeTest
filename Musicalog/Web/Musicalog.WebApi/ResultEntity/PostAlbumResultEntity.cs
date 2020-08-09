using Musicalog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicalog.WebApi.ResultEntity
{
    public class PostAlbumResultEntity:BaseResultEntity
    {
        public Album Album { get; set; }

    }
}
