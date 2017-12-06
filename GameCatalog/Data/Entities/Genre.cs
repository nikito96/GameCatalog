using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Genre
    {
        [Key]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Genre")]
        [StringLength(100, MinimumLength = 1)]
        public string GenreName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
