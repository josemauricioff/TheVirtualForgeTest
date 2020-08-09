namespace Musicalog.MVC.Models.Album
{
    public class AlbumModel: BaseEntityModel
    {
        public int ArtistId { get; set; }
        public int AlbumTypeId { get; set; }
        public short Stock { get; set; }
        public string Label { get; set; }
    }
}
