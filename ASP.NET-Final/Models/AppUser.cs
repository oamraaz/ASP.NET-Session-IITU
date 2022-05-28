﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ASP.NET_Final.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        public virtual ICollection<Message> Messages { get; set; }

    }
}
