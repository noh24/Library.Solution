using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Library.Models
{
  public class Author
  {
    [Required(ErrorMessage = "Author must have a name")]
    [RegularExpression("^[a-zA-Z .]+$", ErrorMessage = "Invalid Author Name")]
    public string Name {get;set;}
    public int AuthorId {get;set;}
    public List<AuthorBook> AuthorBooks { get; }
  }
}
// book
  // copies
// author
// authorBooks
// checkout