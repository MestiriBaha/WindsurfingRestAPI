namespace WindsurfingRestAPI.Models
{
    public class SpotDTO
    {
        public string Name {  get ; set; }  
        public string country { get; set; } 
        public string Description { get; set; } 
        public int Hearts { get; set; } 
        public virtual List<WindsurferDTO> WindsurfersDTO { get; set; }  
    }
}
