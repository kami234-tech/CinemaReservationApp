namespace CinemaReservationApp;

public partial class SeatSelectionPage : ContentPage
{
    public SeatSelectionPage()
    {
        InitializeComponent();
    }

    private async void OnSeatClicked(object sender, EventArgs e)
    {
        var button = sender as Button;

        if (button != null)
        {
            // Toggle seat selection
            if (button.BackgroundColor == Colors.Red) // Unselected
            {
                button.BackgroundColor = Colors.Green; // Selected
                await DisplayAlert("Seat Selected", $"You selected seat {button.Text}", "OK");
            }
            else if (button.BackgroundColor == Colors.Green) // Selected
            {
                button.BackgroundColor = Colors.Red; // Unselected
                await DisplayAlert("Seat Deselected", $"You deselected seat {button.Text}", "OK");
            }
        }
    }
}
