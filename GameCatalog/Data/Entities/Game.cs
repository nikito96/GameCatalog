using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release year")]
        public string ReleaseYear { get; set; }

        [Display(Name = "Genre")]
        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        [Display(Name = "Rating")]
        public int? RatingId { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
