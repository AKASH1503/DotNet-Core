using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SampleProject.Models
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim("Create Role","Creaee Role"),
            new Claim("Edit Role","Edit Role"),
            new Claim("Delete Role","Delete Role"),
        };
    }
}
