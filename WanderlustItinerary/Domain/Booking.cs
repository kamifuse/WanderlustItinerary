namespace WanderlustItinerary.Domain
{
    public class Booking : BaseDomainModel
    {
        public string? UserId { get; set; }   
        public int PackageId { get; set; }    

        public DateTime Date { get; set; }
        public int NumPax { get; set; }
        public string? Status { get; set; }

        
        public Package? Package { get; set; }
    }
}
