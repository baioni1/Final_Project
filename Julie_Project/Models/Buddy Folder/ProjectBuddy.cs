using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Julie_Project.Models
{
    [MetadataType(typeof(ProjectBuddy))]
    public partial class Project
    {
    }
    sealed class ProjectBuddy
    {
        public int ProjectId { get; set; }

        [Display(Name = "Author's Last Name")]
        public int AuthorId { get; set; }

        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        public string Description { get; set; }

        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

        [Display(Name = "GitHub Url")]
        public string GitHubUrl { get; set; }

       
    }
    
}