using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LibraryBookManagementSystem.Models;

namespace LibraryBookManagementSystem.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repo;
        public BookController(IBookRepository repo)
        {
            _repo = repo;
        }


        // GET: BookController
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                var books = _repo.GetAllBooks();
                return View(books);
            }
            var book = _repo.GetBookById(id.Value);

            if (book == null)
                return View(new List<Book>());

            return View(new List<Book> { book });
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var book = _repo.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                _repo.AddBook(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _repo.DeleteBook(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
