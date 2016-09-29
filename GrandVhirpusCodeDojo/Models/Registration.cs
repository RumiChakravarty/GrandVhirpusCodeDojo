using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GrandVhirpusCodeDojo.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Please enter your First name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your Last name")]
        public string LastName { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please select Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Please enter your Zipcode")]
        public string Zipcode { get; set; }
        [Required(ErrorMessage = "Please select course option")]
        public string Course { get; set; }
    }
}