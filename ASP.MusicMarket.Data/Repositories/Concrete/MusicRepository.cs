using ASP.MusicMarket.Core.Models;
using ASP.MusicMarket.Core.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ASP.MusicMarket.Data.Repositories.Concrete
{
    public class MusicRepository : Repository<Music>, IMusicRepository
    {
        public MusicRepository(MusicMarketDbContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Music>> GetAllWithArtistAsync()
        {
            return await MusicMarketDbContext.Musics
                 .Include(m => m.Artist)
                 .ToListAsync();
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId)
        {
            return await MusicMarketDbContext.Musics
               .Include(m => m.Artist)
               .Where(m => m.ArtistId == artistId)
               .ToListAsync();
        }

        public async Task<Music> GetWithArtistByIdAsync(int id)
        {
            return await MusicMarketDbContext.Musics
                 .Include(m => m.Artist)
                 .SingleOrDefaultAsync(m => m.Id == id); 
        }
        private MusicMarketDbContext MusicMarketDbContext
        {
            get { return Context as MusicMarketDbContext; }
        }
    }
}
