using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Library.Models;

namespace Library.Controllers
{
  public class AuthorsController : Controller
  {
    // Routes
    private readonly LibraryContext _db;
    public AuthorsController(LibraryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Author> authors = _db.Authors.ToList();
      return View(authors);
    }

    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Author author)
    {
      if(!ModelState.IsValid)
      {
        return View(author);
      }
      else 
      {     
        _db.Authors.Add(author);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }

    }
  }
}