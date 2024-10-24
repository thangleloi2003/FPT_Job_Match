using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPT_JobMatch.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title cannot be empty")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description cannot be empty")]
        public string Description { get; set; }

        [Range(100, 3000, ErrorMessage = "Salary must be from 100 to 3000")]
        public decimal Salary { get; set; }
        public DateTime PostedDate { get; set; }
        public string Image { get; set; }
        public int EmployerId { get; set; }
        public Employer Employer { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}