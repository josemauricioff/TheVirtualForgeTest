using Musicalog.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Musicalog.Entity
{
    public class Album:BaseEntity
    {
        public int ArtistId { get; set; }
        public int AlbumTypeId { get; set; }
        public short Stock { get; set; }
        public string Label { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual AlbumType Albumtype { get; set; }
    }
}
