using ecommerce_mvc.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce_mvc.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }
        [Display(Name = "Movie Description")]
        public string MovieDescription { get; set; }
        public double Price { get; set; }
        [Display(Name = "Movie Logo")]
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        // Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        // Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
