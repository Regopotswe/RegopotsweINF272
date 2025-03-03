using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegopotsweStudyGroup.Models
{
    public class StudyGroupMembers
    {

        [Display (Name = "Student number")]
        [Required]
        public string StudentNumber { get; set; }

        [Display (Name = "NAME")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "SURNAME")]
        [Required]
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}

