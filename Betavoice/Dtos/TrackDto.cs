using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Betavoice.Models;

namespace Betavoice.Dtos
{
    public class TrackDto
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