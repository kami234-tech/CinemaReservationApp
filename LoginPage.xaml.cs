using System.Net.Http.Json;

namespace CinemaReservationApp;

public partial class LoginPage : ContentPage
{
    private readonly HttpClient _httpClient = new();

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        var username = UsernameEntry.Text;
        var password = PasswordEntry.Text;

        var response = await _httpClient.PostAsJsonAsync("https://your-backend-url/api/auth/login", new
        {
            Username = username,
            Password = password
        });

        if (response.IsSuccessStatusCode)
        {
            // Navigate to the home page
            await Shell.Current.GoToAsync("//HomePage");
        }
        else
        {
            await DisplayAlert("Error", "Invalid username or password", "OK");
        }
    }
}
