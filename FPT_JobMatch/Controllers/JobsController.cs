using FPT_JobMatch.Data;
using FPT_JobMatch.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FPT_JobMatch.Controllers
{
    public class JobsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Jobs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Job.Include(j => j.Employer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Jobs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job
                .Include(j => j.Employer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // GET: Jobs/Create
        [Authorize(Roles = "Admin, Employer")]
        public IActionResult Create()
        {
            ViewData["JobId"] = new SelectList(_context.Job, "Id", "Title");
            ViewData["JobSeekerId"] = new SelectList(_context.JobSeeker, "Id", "Name");

            var job = new Job
            {
                PostedDate = DateTime.Now // Thiết lập giá trị mặc định là thời gian hiện tại
            };
            return View(job);
        }

        // POST: Jobs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public Task<IActionResult> Create(Job job, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                //check if a new image file is uploaded or not
                if (Image != null && Image.Length > 0)
                {
                    //set image file name
                    //Note: should add a prefix to make sure the file name is unique
                    var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(Image.FileName);
                    //set image file location
                    //Note: should create a subfolder named "images" in "wwwroot" to store all images
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        //copy (upload) image file from orignal location to project folder
                        Image.CopyTo(stream);
                    }

                    //set image file name for book cover
                    job.Image = "/images/" + fileName;
                }
                _context.Job.Add(job);
                _context.SaveChanges();
                return Task.FromResult<IActionResult>(RedirectToAction("Index"));
            }
            return Task.FromResult<IActionResult>(View(job));
        }

        // GET: Jobs/Edit/5
        [Authorize(Roles = "Admin, Employer")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }

            job.PostedDate = DateTime.Now;
            ViewData["EmployerId"] = new SelectList(_context.Employer, "Id", "Name", job.EmployerId);
            return View(job);
        }

        // POST: Jobs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Job job, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                // Check if a new image file is uploaded
                if (Image != null && Image.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(Image.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        // Copy (upload) image file from original folder to project folder
                        Image.CopyTo(stream);
                    }

                    // Update product image path
                    job.Image = "/images/" + fileName;
                }
                // Use the existing image file if no new image file is uploaded
                else
                {
                    var existingJob = _context.Job.AsNoTracking().FirstOrDefault(p => p.Id == job.Id);
                    if (existingJob != null)
                    {
                        job.Image = existingJob.Image;

                    }
                }

                // Update product in the database
                _context.Job.Update(job);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(job);
        }

        // GET: Jobs/Delete/5
        [Authorize(Roles = "Admin, Employer")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = await _context.Job
                .Include(j => j.Employer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (job == null)
            {
                return NotFound();
            }

            return View(job);
        }

        // POST: Jobs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var job = await _context.Job.FindAsync(id);
            _context.Job.Remove(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobExists(int id)
        {
            return _context.Job.Any(e => e.Id == id);
        }

        //search function
        public IActionResult Search(string keyword)
        {
            var jobs = _context.Job.Where(p => p.Title.Contains(keyword)).ToList();
            return View("Index", jobs);
        }
    }
}

//public IActionResult SortByAsc()
//{
//    var jobs = _context.Job.OrderBy(p => p.Title).ToList();
//    return View("Index", jobs);
//}

//public IActionResult SortByDesc()
//{
//    var jobs = _context.Job.OrderByDescending(p => p.Title).ToList();
//    return View("Index", jobs);
//}
