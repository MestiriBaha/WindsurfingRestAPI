namespace WindsurfingRestAPI.Models
{
    public class WindsurferDTO
    {
        public int ID { get; set;  }
        public string Name { get; set;  } 
        public string Age { get; set; }
        public string Nationality { get; set; }    
        public virtual List<SpotDTO> SpotsDTO { get; set; }
    }
}
