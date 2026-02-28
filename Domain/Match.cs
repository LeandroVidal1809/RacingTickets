namespace Domain
{
    public class Match
    {
        public Guid Id { get; set; }
        public string Opponent { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public bool IsSoldOut { get; set; }

        public List<Sector> Sectors { get; set; } = new();
    }
}
