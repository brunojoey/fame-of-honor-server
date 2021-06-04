using System;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class RingHonor : IdentityUser
    {
        public string History { get; set; } // Ring of Honor history
        public virtual Teams Team { get; set; }
        public virtual Players Player { get; set; }
    }
}
