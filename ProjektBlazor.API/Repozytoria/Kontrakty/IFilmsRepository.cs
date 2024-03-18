using ProjektBlazor.API.Entities;

namespace ProjektBlazor.API.Repozytoria.Kontrakty
{
    public interface IFilmsRepository
    {
        Task<IEnumerable<Film>> GetFilms();

    }
}
