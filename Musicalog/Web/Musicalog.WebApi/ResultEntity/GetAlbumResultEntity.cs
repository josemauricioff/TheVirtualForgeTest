﻿using Musicalog.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicalog.WebApi.ResultEntity
{
    public class GetAlbumResultEntity : BaseResultEntity
    {
        public AlbumModel Album { get; set; }
    }
}
