using System.ComponentModel.DataAnnotations;

namespace ecommerce_mvc.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        [Display(Name = "Cinema Logo")]
        public string CinemaLogoURL { get; set; }
        [Display(Name = "Cinema Name")]
        public string CinemaName { get; set; }
        [Display(Name = "Cinema Description")]
        public string CinemaDescription { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
