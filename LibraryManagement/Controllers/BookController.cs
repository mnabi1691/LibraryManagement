using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;

namespace LibraryManagement.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryManagementContext _context;

        public BookController(LibraryManagementContext context)
        {
            _context = context;
        }

        // GET: Book
        public async Task<IActionResult> Index()
        {
            var libraryManagementContext = _context.Book.Include(b => b.Auth).Include(b => b.Pub);

            return View(await libraryManagementContext.ToListAsync());
        }

        // GET: Book/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var username = HttpContext.Session.GetString("UserName");
            var userID = HttpContext.Session.GetString("UserID");

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(userID))
            {
                var book = await _context.Book
                    .Include(b => b.Auth)
                    .Include(b => b.Pub)
                    .FirstOrDefaultAsync(m => m.BookId == id);
                if (book == null)
                {
                    return NotFound();
                }

                return View(book);
            }
            else
            {
                ViewBag.Message = "You are not loggedin. Please Login to check book details";
                ViewBag.LoggedIn = false;
                return View();
            }
        }
    }
}
