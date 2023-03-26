using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC_project.Models;
namespace Vidly_MVC_project.ViewModels
{
    public class MovieGenre
    {
        public IEnumerable<Genre> Genres { get; set; }
        
        public Movie Movie { get; set; }
    }
}