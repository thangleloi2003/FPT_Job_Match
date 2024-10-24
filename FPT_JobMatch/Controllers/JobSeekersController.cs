using FPT_JobMatch.Data;
using FPT_JobMatch.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FPT_JobMatch.Controllers
{
    public class JobSeekersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobSeekersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JobSeekers
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobSeeker.ToListAsync());
        }

        // GET: JobSeekers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSeeker = await _context.JobSeeker
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobSeeker == null)
            {
                return NotFound();
            }

            return View(jobSeeker);
        }

        // GET: JobSeekers/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobSeekers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public Task<IActionResult> Create(JobSeeker jobSeeker, IFormFile Image)
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
                    jobSeeker.Image = "/images/" + fileName;
                }
                _context.JobSeeker.Add(jobSeeker);
                _context.SaveChanges();
                return Task.FromResult<IActionResult>(RedirectToAction("Index"));
            }
            return Task.FromResult<IActionResult>(View(jobSeeker));
        }

        // GET: JobSeekers/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSeeker = await _context.JobSeeker.FindAsync(id);
            if (jobSeeker == null)
            {
                return NotFound();
            }
            return View(jobSeeker);
        }

        // POST: JobSeekers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(JobSeeker jobSeeker, IFormFile Image)
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
                    jobSeeker.Image = "/images/" + fileName;
                }
                // Use the existing image file if no new image file is uploaded
                else
                {
                    var existingJobSeeker = _context.JobSeeker.AsNoTracking().FirstOrDefault(p => p.Id == jobSeeker.Id);
                    if (existingJobSeeker != null)
                    {
                        jobSeeker.Image = existingJobSeeker.Image;
                    }
                }

                // Update product in the database
                _context.JobSeeker.Update(jobSeeker);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobSeeker);
        }

        // GET: JobSeekers/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSeeker = await _context.JobSeeker
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobSeeker == null)
            {
                return NotFound();
            }

            return View(jobSeeker);
        }

        // POST: JobSeekers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobSeeker = await _context.JobSeeker.FindAsync(id);
            _context.JobSeeker.Remove(jobSeeker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobSeekerExists(int id)
        {
            return _context.JobSeeker.Any(e => e.Id == id);
        }

    }
}
