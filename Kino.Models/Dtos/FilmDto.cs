using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Models.Dtos
{
    public class FilmDto
    {
        public int Id { get; set; }

        public string? Nazwa { get; set; }

        public string? Dlugosc { get; set; }

        public int Wiek { get; set; }

        public string? Produkcja { get; set; }

        public string? ImageURL { get; set; }

        public string? ZwiastunURL { get; set;}
    }
}
