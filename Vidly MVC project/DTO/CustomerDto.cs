using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC_project.Models;
using System.ComponentModel.DataAnnotations;
namespace Vidly_MVC_project.DTO
{
    public class CustomerDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public DateTime? BirthDate { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
    }
}