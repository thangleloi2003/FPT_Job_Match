using System;
using System.ComponentModel.DataAnnotations;

namespace FPT_JobMatch.Models
{
    public class Application
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Latter cannot be empty")]
        public string ApplicationLatter { get; set; }
        public DateTime ApplicationDate { get; set; }

        public int JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}