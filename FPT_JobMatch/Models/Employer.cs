using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPT_JobMatch.Models
{
    public class Employer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company name cannot be empty")]
        public string CompanyName { get; set; }

        [Range(1, 100, ErrorMessage = "Age must be from 1 to 100")]
        public int Age { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}