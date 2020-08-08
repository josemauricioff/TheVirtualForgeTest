using System.Collections.Generic;

namespace Musicalog.Entity
{
    public class AlbumType: BaseEntity
    {
        public virtual List<Album> AlbumList { get; set; }
    }
}
