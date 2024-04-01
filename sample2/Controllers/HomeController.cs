using Microsoft.AspNetCore.Mvc;
using sample2.Models;
using System.Diagnostics;

namespace sample2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<User> _users = new List<User>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var users = _users;
            return View(users);
        }
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // Save user to database or perform other necessary actions
                _users.Add(user);

                // Redirect to the Details action passing the ID of the created user
                return RedirectToAction("Details", new { id = user.Id });
            }
            return View();
        }
        public IActionResult Details(int id)
        {
            // Find the user with the specified id in the _users list
            var user = _users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                // If no user with the specified id is found, return a 404 Not Found response
                return NotFound();
            }

            // If a user with the specified id is found, pass the user object to the Details.cshtml view
            return View(user);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}