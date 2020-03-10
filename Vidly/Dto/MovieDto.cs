using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the movie name")]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime RelaseDate { get; set; }

        public DateTime CreatedAt { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public GenreDto GenreMovie { get; set; }
    }
}