﻿using Movies.Contracts.Requests;
using Movies.Contracts.Responses;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Api.Sdk
{
    //add a authentucation header

    [Headers("Authentication: Bearer")]

    public interface IMoviesApi
    {
        [Get(ApiEndpoints.Movies.Get)]
        Task<MovieResponse> GetMovieAsync(string idOrSlug);

        [Get(ApiEndpoints.Movies.GetAll)]
        Task<MoviesResponse> GetMoviesAsync(GetAllMoviesRequest request);

        [Post(ApiEndpoints.Movies.Create)]
        Task<MovieResponse> CreateMovieAsync(CreateMovieRequest request);

        [Put(ApiEndpoints.Movies.Update)]
        Task<MovieResponse> UpdateMovieAsync(Guid id, UpdateMovieRequest request);

        [Delete(ApiEndpoints.Movies.Delete)]
        Task DeleteMovieAsync(Guid id);

        [Put(ApiEndpoints.Movies.Rate)]
        Task RateMovieAsync(Guid id, RateMovieRequest request);

        [Delete(ApiEndpoints.Movies.DeleteRating)]
        Task DeleteRatingAsync(Guid id);

        [Get(ApiEndpoints.Ratings.GetUserRatings)]
        Task<IEnumerable<MovieRatingResponse>> GetUserRatingsAsync();
    }
}