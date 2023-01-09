using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
  public class Book
  {
    public string Title { get;set;}
    public int BookId {get;set;}
    public List<Copy> Copies {get;set;}
  }
}
// book
  // copies
// author
// authorBooks
// checkout