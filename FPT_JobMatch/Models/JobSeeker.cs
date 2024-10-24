using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPT_JobMatch.Models
{
    public class JobSeeker
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name cannot be empty")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Age must be from 1 to 100")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Gender cannot be empty")]
        public string Gender { get; set; }
        public string Image { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
