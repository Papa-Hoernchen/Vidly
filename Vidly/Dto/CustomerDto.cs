using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Routing;
using Vidly.Models;

namespace Vidly.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        [StringLength(255)]
        public string Name { get; set; }

        public RouteCollection route;

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MemberShipTypeId { get; set; }

        public MembershipTypeDto MemberShipType { get; set; }

        //       [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}