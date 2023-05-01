using ASP.MusicMarket.Core.DTO_s;
using ASP.MusicMarket.Core.Models;
using AutoMapper;

namespace ASP.MusicMarket.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Music, MusicDTO>();
            CreateMap<Artist, ArtistDTO>();

            // Resource to Domain
            CreateMap<MusicDTO, Music>();
            CreateMap<ArtistDTO, Artist>();

            CreateMap<SaveMusicDTO, Music>();
            CreateMap<SaveArtistDTO, Artist>();
        }
    }
}
