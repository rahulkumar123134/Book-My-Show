using AutoMapper;
using Dapper;
using BookMyShow.Profiles;
using WebData.Business;
using WebData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using WebService.Services;

namespace BookMyShow.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService Movies;

        public MovieController (IMovieService movies)
        {
            Movies = movies;
        }

        [HttpGet] 
        public List<Movie> GetMovies()
        {
            var movies = Movies.GetAllMovies();
            return movies;
        }

        [HttpGet("{id}")]
        public Movie GetMovieById(int id)
        {
            Movie movie = Movies.GetMovieById(id);
            return movie;
        }
    }
}
