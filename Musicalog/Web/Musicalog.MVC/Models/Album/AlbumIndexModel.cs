using System.Collections.Generic;

namespace Musicalog.MVC.Models.Album
{
    public class AlbumIndexModel:BaseModel
    {
        public List<AlbumIndexItemModel> AlbumList { get; set; }

    }
}
