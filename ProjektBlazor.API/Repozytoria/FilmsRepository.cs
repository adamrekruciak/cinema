using Microsoft.EntityFrameworkCore;
using ProjektBlazor.API.Data;
using ProjektBlazor.API.Entities;
using ProjektBlazor.API.Repozytoria.Kontrakty;

namespace ProjektBlazor.API.Repozytoria
{
    public class FilmsRepository : IFilmsRepository
    {
        private readonly KinoDbContext kinoDbContext;

        public FilmsRepository(KinoDbContext kinoDbContext )
        {
            this.kinoDbContext = kinoDbContext;
        }

        public async Task<IEnumerable<Film>> GetFilms()
        {
            var films = await this.kinoDbContext.Films.ToListAsync();
            return films;
        }
    }
}
