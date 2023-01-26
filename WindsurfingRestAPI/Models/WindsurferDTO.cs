namespace WindsurfingRestAPI.Models
{
    public class WindsurferDTO
    {
        public int ID { get; set;  }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;

        public DateTime Birthday { get; set; }
        public string Nationality { get; set; } = String.Empty;
    }
}
