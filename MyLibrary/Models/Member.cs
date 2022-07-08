using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace MyLibrary.Models
{
    public partial class Member
    {
        public Member()
        {
            Orders = new HashSet<Order>();
        }

        [Required]
        public int MemberId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]      
        public string CompanyName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
