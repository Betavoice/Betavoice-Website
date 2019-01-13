using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
    
namespace Betavoice.Models
{
    public class Track
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Author { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}