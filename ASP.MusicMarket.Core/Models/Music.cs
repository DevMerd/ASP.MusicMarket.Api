namespace ASP.MusicMarket.Core.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}
