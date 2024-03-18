using Kino.Models.Dtos;
using ProjektBlazor.API.Entities;
using ProjektBlazor.API.Repozytoria;

namespace ProjektBlazor.API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<MiejsceDto> ConvertToDto(this IEnumerable<Miejsce> miejsca,
                                                                IEnumerable<Film> films)
        {
            return (from m in miejsca
                    join f in films
                    on m.FilmId equals f.Id
                    select new MiejsceDto
                    {
                        Id = m.Id,
                        FilmId = f.Id,
                        Rzad = m.Rzad,
                        Numer = m.Numer,
                        Status = !string.IsNullOrEmpty(m.Imie)
                    }).ToList();
        }

        public static MiejsceDto ConvertToDto(this Miejsce miejsce, Film film)
        {
            return new MiejsceDto
            {
                Id = miejsce.Id,
                FilmId = film.Id,
            };
        }

        public static IEnumerable<FilmDto> ConvertToDto3(this IEnumerable<Film> films)
        {
            return (from f in films
                    select new FilmDto
                    {
                        Id = f.Id,
                        Nazwa = f.Nazwa,
                        Dlugosc = f.Dlugosc,
                        Wiek = f.Wiek,
                        Produkcja = f.Produkcja,
                        ImageURL = f.ImageURL,
                        ZwiastunURL = f.ZwiastunURL,
                    }).ToList ();
        }

    }
}
