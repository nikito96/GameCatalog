using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Rating
    {
        [Key]
        [Display(Name = "Rating")]
        public int RatingId { get; set; }

        [Required]
        [Display(Name = "Rating")]
        [StringLength(100, MinimumLength = 1)]
        public string RatingValue { get; set; }

        [Required]
        [StringLength(400, MinimumLength = 1)]
        public string Description { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
