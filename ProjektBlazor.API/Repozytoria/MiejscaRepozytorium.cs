using Kino.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using ProjektBlazor.API.Data;
using ProjektBlazor.API.Entities;
using ProjektBlazor.API.Repozytoria.Kontrakty;

namespace ProjektBlazor.API.Repozytoria
{
    public class MiejscaRepozytorium : IRepozytoriumMiejsca
    {
        private readonly KinoDbContext kinoDbContext;

        public MiejscaRepozytorium(KinoDbContext kinoDbContext)
        {
            this.kinoDbContext = kinoDbContext;
        }

        public async Task<Film> GetFilm(int id)
        {
            var film = await kinoDbContext.Films.SingleOrDefaultAsync(x => x.Id == id);
            return film;
        }

        public async Task<IEnumerable<Film>> GetFilmy()
        {
            var filmy = await this.kinoDbContext.Films.ToListAsync();
            return filmy;
        }

        public async Task<IEnumerable<Miejsce>> GetMiejsca()
        {
            var miejsca = await this.kinoDbContext.Miejsca.ToListAsync();
            return miejsca;
        }

        public Task<Miejsce> GetMiejsce(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Miejsce> UpdateMiejsce(int id, UpdateSeatDto updateSeatDto)
        {
            var miejsce = await this.kinoDbContext.Miejsca.FindAsync(id);

            if (miejsce != null) 
            {
                miejsce.Imie = updateSeatDto.SeatImie;
                miejsce.Nazwisko = updateSeatDto.SeatNazwisko;
                miejsce.Email = updateSeatDto.SeatEmail;
                miejsce.Phone = updateSeatDto.SeatPhone;
                await this.kinoDbContext.SaveChangesAsync();
                return miejsce;
            }

            return null;
        }
    }
}
