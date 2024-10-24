using FPT_JobMatch.Data;
using FPT_JobMatch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace FPT_JobMatch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // Check if the user is an Employer
            if (User.Identity.IsAuthenticated && User.IsInRole("Employer"))
            {
                // Redirect to Employers page
                return RedirectToAction("Index", "Employers");
            }

            // Retrieve job listings from the database
            var jobListings = _context.Job.ToList(); // Fetch jobs from the database

            // Pass the job listings to the view
            return View(jobListings); // Always pass job listings to view
        }


        public IActionResult About()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}