using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_MVC_project.Models;
namespace Vidly_MVC_project.ViewModels
{
    public class CustomerMembershipType
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}