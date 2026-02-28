namespace Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public Guid MatchId { get; set; }
        public Guid UserId { get; set; }
        public string SectorName { get; set; } = string.Empty;
        public DateTime PurchaseDate { get; set; }
    }
}
