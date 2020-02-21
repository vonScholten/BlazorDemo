using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations; // validation of forms

namespace BlazorDemo.Shared
{
    public class PersonModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is mandatory")]
        [StringLength(10, ErrorMessage = "First name is too long.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is mandatory")]
        [StringLength(10, ErrorMessage = "Last name is too long.")]
        public string LastName { get; set; }
        public decimal AccountBalance { get; set; }
        public string FullName => $"{FirstName} {LastName}";

    }
}
