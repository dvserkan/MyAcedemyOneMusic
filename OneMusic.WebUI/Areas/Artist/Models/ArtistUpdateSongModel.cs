namespace OneMusic.WebUI.Areas.Artist.Models
{
    public class ArtistUpdateSongModel
    {
        public int Id { get; set; } 
        public string SongName { get; set; }
        public IFormFile SongImageUrl { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile SongFile { get; set; }
        public string SongFileUrl { get; set; }
        public int AlbumId { get; set; }
    }
}
