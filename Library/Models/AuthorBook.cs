using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Library.Models;

namespace Library.Models
{
  public class AuthorBook
  {
    public int AuthorBookId {get;set;}
    public int AuthorId {get;set;}
    public Author Author {get;set;}
    public int BookId {get;set;}
    public Book Book {get;set;}
  }
}
// book
  // copies
// author
// authorBooks
// checkout