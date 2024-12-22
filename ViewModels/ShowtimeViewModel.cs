using System.Collections.ObjectModel;
using CinemaReservationApp.Models;

namespace CinemaReservationApp.ViewModels
{
    public class ShowtimeViewModel
    {
        public ObservableCollection<Showtime> Showtimes { get; set; }

        public ShowtimeViewModel()
        {
            // Example data
            Showtimes = new ObservableCollection<Showtime>
            {
                new Showtime { Id = 1, MovieId = 1, StartTime = DateTime.Now.AddHours(1), Location = "Cinema 1" },
                new Showtime { Id = 2, MovieId = 1, StartTime = DateTime.Now.AddHours(3), Location = "Cinema 2" },
                new Showtime { Id = 3, MovieId = 2, StartTime = DateTime.Now.AddHours(2), Location = "Cinema 1" }
            };
        }
    }
}
