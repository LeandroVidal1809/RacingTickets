namespace Domain
{
    public class Sector
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public decimal Price { get; set; }
    }
}
