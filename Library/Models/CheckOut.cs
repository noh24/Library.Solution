using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Library.Models;

namespace Library.Models
{
  public class CheckOut
  {
    public int CheckOutId { get; set; }
    // public int UserId {get;set;}
    // public IdentityUser User {get;set;}
    public int CopyId { get; set; }
    public Copy Copy { get; set; }
    public Nullable<DateOnly> DueDate { get; set; }
    // [Required(ErrorMessage = "Must include date checked out")]
    // [DataType(DataType.Date)]
    public Nullable<DateOnly> CheckOutDate { get; set; }
    public bool IsOverdue { get; set; }
    public ApplicationUser User { get; set; }
  }
}