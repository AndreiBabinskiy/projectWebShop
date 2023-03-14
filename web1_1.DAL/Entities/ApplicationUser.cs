using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace web1_1.DAL.Entities
{
  public  class ApplicationUser: IdentityUser
    {
        public byte[] AvatarImage { get; set; }
    }
}
