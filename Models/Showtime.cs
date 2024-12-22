using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservationApp.Models
{
    public class Showtime
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public DateTime StartTime { get; set; }
        public string Location { get; set; }

        // Navigation Property
        public Movie Movie { get; set; }
    }
}

