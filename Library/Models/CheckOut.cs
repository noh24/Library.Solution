using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Library.Models;

namespace Library.Models
{
  public class CheckOut
  {
    public int CheckOutId {get;set;}
    // public int UserId {get;set;}
    // public IdentityUser User {get;set;}
    public int CopyId {get;set;}
    public Copy Copy {get;set;}
    public DateTime DueDate {get;set;}
    public DateTime CheckOutDate {get;set;}
    public bool IsOverdue {get;set;}

  }
}
// book
  // copies
// author
// authorBooks
// checkout