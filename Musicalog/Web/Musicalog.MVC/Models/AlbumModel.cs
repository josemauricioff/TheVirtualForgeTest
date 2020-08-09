namespace Models
{
    public class Album:BaseEntity
    {
        public int ArtistId { get; set; }
        public int AlbumTypeId { get; set; }
        public short Stock { get; set; }
        public string Label { get; set; }
    }
}
