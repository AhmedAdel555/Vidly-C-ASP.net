using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly_MVC_project.Models;
namespace Vidly_MVC_project.DTO
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        public int NumberInStocks { get; set; }
    }
}