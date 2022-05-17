using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using System;
namespace WebApp.Controllers
{
    [ApiController]
    [Route("/api/actors")]
    public class ActorsController : ControllerBase
    {
        private List<Actor> Actors { get; set; }

        public ActorsController()
        {
            Actors = new List<Actor>()
            {
                new Actor() {Id = 1, FirstName = "Jason", LastName = "Statham", Birthday = DateTime.Parse("1967-06-26")},
                new Actor() {Id = 2, FirstName = "Tom", LastName = "Holland", Birthday = DateTime.Parse("1996-06-01")},
            };
        }
        
        [HttpGet]
        public ActionResult GetAllActors()
        {
            return Ok(Actors);
        }
    }
}