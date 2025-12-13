namespace WanderlustItinerary.Domain
{
    public class Package : BaseDomainModel
    {
        public string? PackageName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}
