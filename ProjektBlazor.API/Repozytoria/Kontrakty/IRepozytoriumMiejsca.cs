using Kino.Models.Dtos;
using ProjektBlazor.API.Entities;

namespace ProjektBlazor.API.Repozytoria.Kontrakty
{
    public interface IRepozytoriumMiejsca
    {
        Task<IEnumerable<Miejsce>> GetMiejsca();

        Task<Miejsce> GetMiejsce(int id);

        Task<IEnumerable<Film>> GetFilmy();

        Task<Film> GetFilm(int id);

        Task<Miejsce> UpdateMiejsce(int id, UpdateSeatDto updateSeatDto);


    }
}
