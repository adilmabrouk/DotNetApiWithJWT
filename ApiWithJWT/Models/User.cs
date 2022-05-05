using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ApiWithJWT.Models
{
    public class User : IdentityUser
    {
        [Required, MaxLength(128)]
        public string FirstName { get; set; }

        [Required, MaxLength(128)]
        public string LastName { get; set; }
    }
}
