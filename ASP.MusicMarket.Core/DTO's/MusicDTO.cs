using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.MusicMarket.Core.DTO_s
{
    public class MusicDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ArtistDTO Artist { get; set; }
    }
}
