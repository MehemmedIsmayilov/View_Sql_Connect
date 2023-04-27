using Connect_Data_Task.Contexts;
using Connect_Data_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Connect_Data_Task.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDbContext _context;

        public HomeController (AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<ContactAbout> contactAbouts = _context.contactAbouts.ToList();

            return View(contactAbouts);
        }
    }
}
