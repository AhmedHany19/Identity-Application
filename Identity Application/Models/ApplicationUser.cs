using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using System.Diagnostics.CodeAnalysis;

namespace Identity_Application.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [AllowNull]
        [Display(Name ="Profile Picture")]
        public byte[]? ProfilePicture { get; set; }

    }
}
