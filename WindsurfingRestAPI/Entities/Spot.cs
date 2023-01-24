namespace WindsurfingRestAPI.Entities
{
    public class Spot
    {
        public string Name { get; set; }
        public string country { get; set; }
        public string Description { get; set; }
        public int Hearts { get; set; }
        public virtual List<Windsurfer> Windsurfers { get; set; }
    }
}
