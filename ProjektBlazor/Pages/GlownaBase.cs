using Kino.Models.Dtos;
using Microsoft.AspNetCore.Components;
using ProjektBlazor.Services;
using ProjektBlazor.Services.Contracts;

namespace ProjektBlazor.Pages
{
	public class GlownaBase : ComponentBase
	{
		[Inject]
		public IMiejsceService? MiejsceService { get; set; }

		[Inject]
		public IFilmService? FilmService { get; set; }

		[Inject]
		public NavigationManager NavigationManager { get; set; }

		public IEnumerable<MiejsceDto>? Miejsca { get; set; }

		public IEnumerable<FilmDto>? Films { get; set; }

		protected override async Task OnInitializedAsync()
		{
			Miejsca = await MiejsceService.GetMiejsce();
			Films = await FilmService.GetFilm();
		}

		protected async Task UpdateSeat_Click(int id, string imie, string nazwisko, string email, string phone)
		{
			try
			{
				var updateSeat = new UpdateSeatDto
				{
					SeatId = id,
					SeatImie = imie,
					SeatNazwisko = nazwisko,
					SeatEmail = email,
					SeatPhone = phone
				};
				await this.MiejsceService.UpdateMiejsce(updateSeat);


			}
			catch (Exception)
			{

				throw;
			}
		}

    }
}
