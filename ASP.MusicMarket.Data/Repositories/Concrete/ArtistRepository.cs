using ASP.MusicMarket.Core.Models;
using ASP.MusicMarket.Core.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ASP.MusicMarket.Data.Repositories.Concrete
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(MusicMarketDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Artist>> GetAllWithMusicsAsync()
        {
           return await MusicMarketDbContext.Artists
                .Include(x => x.Musics)
                .ToListAsync();
        }

        public Task<Artist> GetWithMusicsByIdAsync(int id)
        {
            return MusicMarketDbContext.Artists
                .Include(a => a.Musics)
                .SingleOrDefaultAsync(a => a.Id == id);
        }

        private MusicMarketDbContext MusicMarketDbContext
        {
            get { return Context as MusicMarketDbContext; }

        }
    }
}
