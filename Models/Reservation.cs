using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaReservationApp.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int SeatId { get; set; }
        public string UserId { get; set; } // Can be linked to a User class if needed
        public DateTime ReservationDate { get; set; }

        // Navigation Properties
        public Movie Movie { get; set; }
        public Seat Seat { get; set; }
    }
}
