using CinemaReservationApp.Models;
using CinemaReservationApp.ViewModels;
using Microsoft.Maui.Controls;

namespace CinemaReservationApp
{
    public partial class ShowTimePage : ContentPage
    {
        public ShowTimePage()
        {
            InitializeComponent();
            BindingContext = new ShowtimeViewModel();
        }

        // Event handler for showtime selection
        private async void OnShowtimeSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
            {
                // Get the selected showtime
                var selectedShowtime = e.CurrentSelection.FirstOrDefault() as Showtime;

                if (selectedShowtime != null)
                {
                    // Navigate to the next page (e.g., SeatSelectionPage) with showtime details
                    // Assuming SeatSelectionPage accepts a showtime ID as a parameter
                    await Shell.Current.GoToAsync($"SeatSelectionPage?showtimeId={selectedShowtime.Id}");
                }

                // Clear the selection
                ((CollectionView)sender).SelectedItem = null;
            }
        }
    }
}
