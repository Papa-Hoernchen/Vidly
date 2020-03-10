using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        [StringLength(255)]
        public string Name { get; set; }

        public RouteCollection route;

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MemberShipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MemberShipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
        public object MembershipType { get; internal set; }
    }
}