using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace InstaMedData.Models
{
    public class ApplicationUser : IdentityUser
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Telephone { get; set; }
        public String Pesel { get; set; }
        public new String Email { get; set; }
        public String Password { get; set; }
        public DateTime JoinDate { get; set; }
        
        public int Acces { get; set; }
        public Role UserRole { get; set; }
        public ICollection<Visit> visit { get; set; }
    }
}
