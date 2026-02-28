using Application;

namespace Tests
{
    public class TicketServiceTests
    {
        [Fact]
        public void Purchase_Should_Create_Ticket()
        {
            var service = new TicketService();
            var ticket = service.Purchase(Guid.NewGuid(), Guid.NewGuid(), "Popular");

            Assert.NotNull(ticket);
            Assert.Equal("Popular", ticket.SectorName);
        }
    }
}