using System.ComponentModel.DataAnnotations;

namespace WindsurfingRestAPI.Entities
{
    public class Spot
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string country { get; set; }
        [StringLength(30, MinimumLength = 7)]
        public string Description { get; set; }
        public int Hearts { get; set; }
        public virtual List<Windsurfer> Windsurfers { get; set; }
    }
}
