namespace CollectionViewChallenge.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string ISO { get; set; }
        public string CapitalCity { get => $"Capital: {Capital}"; }
        public string Capital { get; set;}
    }

}
