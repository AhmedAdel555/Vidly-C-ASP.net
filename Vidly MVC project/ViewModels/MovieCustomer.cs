using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC_project.Models;
namespace Vidly_MVC_project.ViewModels
{
    public class MovieCustomer
    {
        public Movie movie { get; set; }
        public List<Customer> customers { get; set; }

        public MovieCustomer(Movie movie, List<Customer> customers)
        {
            this.movie = movie;
            this.customers = customers;
        }
    }
}