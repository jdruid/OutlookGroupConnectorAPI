using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace startupconnector.Models
{
  
    public class StartupCard
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string ContactName { get; set; }

        [Required]
        [StringLength(128, MinimumLength = 3)]
        public string ContactEmail { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Category { get; set; }

        [Required]
        [StringLength(512, MinimumLength = 3)]
        public string Inquiry { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Location { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

    }

}