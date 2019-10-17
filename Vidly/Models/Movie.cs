using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Microsoft.Owin.Security.DataHandler;

namespace Vidly.Models
{
    public class Movie
    {
        [Required]
        [Key]
        public byte Id { get; set; }

        [Required(ErrorMessage="Please Enter Movie Name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        [Required (ErrorMessage="Please Enter Date.")]
        [Display (Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required (ErrorMessage="Please Enter Number Of Stock.")]
        [Range(1, 20)]
        [Display(Name="Number In Stock")]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        public Genre Genre { get; set; }

        [Required (ErrorMessage="Please Selecte Your Type Of Genre.")]
        [Display(Name = "Genres Types")]
        public byte GenreId { get; set; }
    }
}