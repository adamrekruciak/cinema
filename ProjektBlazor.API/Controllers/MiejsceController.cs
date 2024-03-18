using Kino.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjektBlazor.API.Data;
using ProjektBlazor.API.Entities;
using ProjektBlazor.API.Extensions;
using ProjektBlazor.API.Repozytoria.Kontrakty;

namespace ProjektBlazor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MiejsceController : ControllerBase
    {
        private readonly IRepozytoriumMiejsca repozytoriumMiejsca;

        public MiejsceController(IRepozytoriumMiejsca repozytoriumMiejsca)
        {
            this.repozytoriumMiejsca = repozytoriumMiejsca;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MiejsceDto>>> GetMiejsca()
        {
            try
            {
                var miejsca = await this.repozytoriumMiejsca.GetMiejsca();
                var filmy = await this.repozytoriumMiejsca.GetFilmy();

                if (miejsca == null || filmy == null)
                {
                    return NotFound();
                }
                else
                {
                    var miejsceDtos = miejsca.ConvertToDto(filmy);

                    return Ok(miejsceDtos);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Błąd przy pobieraniu danych z bazy");
            }
        }

        [HttpPatch("{id:int}")]

        public async Task<ActionResult<MiejsceDto>> UpdateMiejsce(int id, UpdateSeatDto updateSeatDto)
        {
            try
            {
                var miejsce = await this.repozytoriumMiejsca.UpdateMiejsce(id, updateSeatDto);
                if (miejsce == null)
                {
                    return NotFound();
                }
                var film = await this.repozytoriumMiejsca.GetFilm(miejsce.FilmId);

                var miejsceDtos = miejsce.ConvertToDto(film);

                return Ok(miejsceDtos);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }




    }
}
