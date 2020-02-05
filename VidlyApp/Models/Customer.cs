using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        //navigation property. allows to navigate from type customer to membership type. useful one want to load customer and membership type together
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}