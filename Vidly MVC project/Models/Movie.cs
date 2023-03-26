using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Vidly_MVC_project.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public Movie()
        {

        }
        public Movie(int id , string title)
        {
            this.Id = id;
            this.Title = title;
        }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        public int NumberInStocks { get; set; }

    }
}