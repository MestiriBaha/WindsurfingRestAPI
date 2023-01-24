using System.ComponentModel.DataAnnotations;

namespace WindsurfingRestAPI.Entities
{
    public class Windsurfer
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]

        public string Nationality { get; set; }
        public virtual List<Spot> Spots { get; set; }
    }
}
