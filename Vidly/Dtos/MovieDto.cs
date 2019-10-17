using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        [Required]
        [Key]
        public byte Id { get; set; }

        [Required(ErrorMessage = "Please Enter Movie Name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please Enter Date.")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please Enter Number Of Stock.")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public GenreDto Genre { get; set; }

        [Required(ErrorMessage = "Please Selecte Your Type Of Genre.")]
        public byte GenreId { get; set; }

    }
}