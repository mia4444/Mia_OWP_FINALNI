using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mia_OWP_FINALNI.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
    public string Name { get; set; }

    public bool IsSubscribedToNewsletter { get; set; }

    public MembershipType MembershipType { get; set; } //morao se dodati property da bi CustomersController radio
        
        [Display(Name="Membership Type")]
        public byte MembershipTypeId { get; set; }

}
}