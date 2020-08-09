using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicalog.WebApi.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ArtistId { get; set; }
        public int AlbumTypeId { get; set; }
        public short Stock { get; set; }
        public string Label { get; set; }
    }
}
