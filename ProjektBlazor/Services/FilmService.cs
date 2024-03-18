using Kino.Models.Dtos;
using ProjektBlazor.Services.Contracts;
using System.Net.Http.Json;

namespace ProjektBlazor.Services
{
	public class FilmService : IFilmService
	{
		private readonly HttpClient httpClient;

		public FilmService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		public async Task<IEnumerable<FilmDto>> GetFilm()
		{
			try
			{
				var films = await this.httpClient.GetFromJsonAsync<IEnumerable<FilmDto>>("api/Film");
				return films;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
