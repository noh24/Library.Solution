using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
  public class Book
  {
    [Required(ErrorMessage = "Book must have a title")]
    public string Title { get;set;}
    public int BookId {get;set;}
    public List<AuthorBook> AuthorBooks { get; }
    public List<Copy> Copies {get;set;}
  }
}
// book
  // copies
// author
// authorBooks
// checkout