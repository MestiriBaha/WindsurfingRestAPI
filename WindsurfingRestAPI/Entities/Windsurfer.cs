using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindsurfingRestAPI.Entities
{
    public class Windsurfer
    {
      
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]

        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
         
        [Required]
         public string password { get; set;  }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]

        public string Nationality { get; set; }
        public virtual List<Spot> Spots { get; set; }
    }
}
