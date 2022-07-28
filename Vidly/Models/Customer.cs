using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name!")]
        [StringLength(255)]
        public string Name { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name ="Subscribed to news later?")]

        public bool IsSubscribedToNewsLater { get; set; }
        [Display(Name ="Membership Type")]

        public int MembershipTypeId { get; set; }
        [Required]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}