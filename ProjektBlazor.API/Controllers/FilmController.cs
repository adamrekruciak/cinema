using Kino.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using ProjektBlazor.API.Extensions;
using ProjektBlazor.API.Repozytoria.Kontrakty;

namespace ProjektBlazor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmsRepository filmsRepository;

        public FilmController(IFilmsRepository filmsRepository) 
        { 
            this.filmsRepository = filmsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmDto>>> GetFilms()
        {
            try
            {
                var films = await this.filmsRepository.GetFilms();

                if(films == null)
                {
                    return NotFound();
                }
                else
                {
                    var filmsDtos = films.ConvertToDto3();
                    return Ok(filmsDtos);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Błąd przy pobieraniu danych z bazy");
            }
        }
    }

}
