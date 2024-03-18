using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Models.Dtos
{
    public class UpdateSeatDto
    {
        public int SeatId { get; set; }

        public string? SeatImie { get; set; }
        
        public string? SeatNazwisko { get; set; }

        public string? SeatPhone { get; set; }

        public string? SeatEmail { get; set; }
    }
}
