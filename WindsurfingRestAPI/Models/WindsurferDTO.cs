namespace WindsurfingRestAPI.Models
{
    public class WindsurferDTO
    {
        public string FullName { get; set; } = String.Empty;
        
        // tell me why the hell you are using birthday while you can use the age !! come on this data transfer object !! BE MORE SPECIFIC !!! 
        public int Age { get; set; }    
        public string Nationality { get; set; } = String.Empty;
    }
}
