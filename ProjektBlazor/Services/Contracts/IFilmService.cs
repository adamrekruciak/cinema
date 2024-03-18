using Kino.Models.Dtos;

namespace ProjektBlazor.Services.Contracts
{
	public interface IFilmService
	{
		Task<IEnumerable<FilmDto>> GetFilm();
	}
}
