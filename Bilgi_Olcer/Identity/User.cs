﻿using Microsoft.AspNetCore.Identity;

namespace Bilgi_Olcer.Identity
{
    public class User:IdentityUser
    {
        public string FullName { get; set; }
    }
}
