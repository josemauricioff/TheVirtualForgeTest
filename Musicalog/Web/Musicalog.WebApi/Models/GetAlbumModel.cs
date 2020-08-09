using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicalog.WebApi.Models
{
    public class GetAlbumModel
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Type { get; set; }
        public short Stock { get; set; }
    }
}
