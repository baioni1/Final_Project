using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Julie_Project.Models
{
    [MetadataType(typeof(AuthorBuddy))]
    public partial class Author
    {
        
        sealed class AuthorBuddy
        {
            [Display(Name = "Author")]
            public int AuthorId { get; set; }

            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "First Name")]
            public string FirstName { get; set; }

        }
    }
}