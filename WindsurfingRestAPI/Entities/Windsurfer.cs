namespace WindsurfingRestAPI.Entities
{
    public class Windsurfer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Nationality { get; set; }
        public virtual List<Spot> Spots { get; set; }
    }
}
