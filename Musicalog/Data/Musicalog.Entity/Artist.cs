using System.Collections.Generic;

namespace Musicalog.Entity
{
    public class Artist:BaseEntity
    {
        public virtual List<Album> AlbumList { get; set; }
    }
}
