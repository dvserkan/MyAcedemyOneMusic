namespace OneMusic.WebUI.Areas.Artist.Models
{
    public class ArtistEditSongModel
    {
        public string SongName { get; set; }
        public IFormFile SongImageUrl { get; set; }
        public IFormFile SongFile { get; set; }
        public int AlbumId { get; set; }
    }
}
