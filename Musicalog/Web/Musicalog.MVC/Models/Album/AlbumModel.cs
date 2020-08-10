using System.ComponentModel.DataAnnotations;

namespace Musicalog.MVC.Models.Album
{
    public class AlbumModel: BaseEntityModel
    {
        [Required]
        public int ArtistId { get; set; }
        [Required]
        public int AlbumTypeId { get; set; }
        [Required]
        public short Stock { get; set; }
        public string Label { get; set; }
    }
}
