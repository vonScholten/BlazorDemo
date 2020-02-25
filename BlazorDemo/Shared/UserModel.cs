using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations; // validation of forms

namespace BlazorDemo.Shared
{
  public class UserModel
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "Username is mandatory")]
    [StringLength(10, ErrorMessage = "username is too long")]
    public string Username { get; set; }
    [Required(ErrorMessage = "First name is mandatory")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Last name is mandatory")]
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public DateTime Birthday { get; set; }
    public string Email { get; set; }
    public string Img { get; set; }

  }
}
