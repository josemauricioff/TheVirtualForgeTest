using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musicalog.MVC.Models.AlbumType
{
    public class GetAllAlbumTypeModel:BaseModel
    {
        public List<AlbumTypeModel> AlbumTypeList { get; set; }
    }
}
