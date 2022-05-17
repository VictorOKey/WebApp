using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using System;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("/api/movies")]
    public class MoviesController : ControllerBase
    {
        private List<Movie> Movies { get; set; }

        public MoviesController()
        {
            Movies = new List<Movie>()
            {
                new Movie() {Id = 1, Title = "Spider-man: No Way Home", ReleaseDate = DateTime.Parse("2021-12-16")},
                new Movie() {Id = 2, Title = "The Matrix Resurrection", ReleaseDate = DateTime.Parse("2021-12-16")},
                new Movie() {Id = 3, Title = "Venom 2", ReleaseDate = DateTime.Parse("2021-09-14")},
                new Movie() {Id = 4, Title = "Space Jam: A New Legacy", ReleaseDate = DateTime.Parse("2021-09-14")},
                new Movie() {Id = 5, Title = "The Boss Baby: Family Business", ReleaseDate = DateTime.Parse("2021-07-01")}
            };
        }
        [HttpGet]
        public ActionResult GetAllMovies()
        {
            return Ok(Movies);
        }
    }
}