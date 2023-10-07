using Refit;
using Movies.Api.Sdk;
using System.Text.Json;
using Movies.Contracts.Requests;
using Microsoft.Extensions.DependencyInjection;

//var moviesApi = RestService.For<IMoviesApi>("https://localhost:7218");

var services = new ServiceCollection();

services.AddRefitClient<IMoviesApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7218")); 

var serviceProvider = services.BuildServiceProvider();

var moviesApi = serviceProvider.GetRequiredService<IMoviesApi>();

//var movie = await moviesApi.GetMovieAsync("ferris-day-uneployed-3--happy-worker-2023");

var request = new GetAllMoviesRequest
{
    Title = null,
    Year = null,
    SortBy = null,
    Page = 1,
    PageSize = 4
};

var movies = await moviesApi.GetMoviesAsync(request);

foreach (var movieResponse in movies.Items)
{
    Console.WriteLine(JsonSerializer.Serialize(movieResponse));
}

