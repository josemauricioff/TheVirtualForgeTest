using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicalog.MVC.Models.Artist
{
    public class GetAllArtistsModel:BaseModel
    {
        public List<ArtistModel> ArtistList { get; set; }
    }
}
