using System;
using System.ComponentModel.DataAnnotations;
namespace WebApp.Models
{
    public class Movie
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}