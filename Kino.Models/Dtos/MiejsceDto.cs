using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Models.Dtos
{
    public class MiejsceDto
    {

        public int Id { get; set; }

        public int FilmId { get; set; }

        public int Numer { get; set; }

        public int Rzad { get; set; }

        public bool Status { get; set; }

        public bool IsSelected { get; set; }
    }
}
