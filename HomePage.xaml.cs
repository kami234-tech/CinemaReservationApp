using System.Net.Http.Json;
using CinemaReservationApp.Models;
namespace CinemaReservationApp;

public partial class HomePage : ContentPage
{
    private readonly HttpClient _httpClient = new();
    public List<Movie> Movies { get; set; }

    public HomePage()
    {
        InitializeComponent();
        LoadMovies();
    }

    private async void LoadMovies()
    {
        Movies = await _httpClient.GetFromJsonAsync<List<Movie>>("https://your-backend-url/api/movies");
        BindingContext = this;
    }

    private async void OnMovieSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedMovie = e.CurrentSelection.FirstOrDefault() as Movie;
        if (selectedMovie != null)
        {
            await Shell.Current.GoToAsync($"ShowtimePage?movieId={selectedMovie.Id}");
        }
    }
}
