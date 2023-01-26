using System.ComponentModel.DataAnnotations;

namespace WindsurfingRestAPI.Entities
{
    public class Spot
    {
        public Spot(string name , string country , string description)
        {
            this.Name = name;
            this.country = country;
            this.Description= description;  

        }
        [Key]
        public string Name { get; set; }
        [Required]
        public string country { get; set; }
        [StringLength(30, MinimumLength = 7)]
        public string Description { get; set; }
        public int Hearts { get; set; }
        //if you forget the objective of the virtual ! you have to remember that 3rd table that will let us create this Ienumerable ! 
        public virtual List<Windsurfer> Windsurfers { get; set; }
    }
}
