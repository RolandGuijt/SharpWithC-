using Shared.Dtos;
using Shared.Enums;

namespace ExperimentsWithRecords
{
    public record EventPriceDtoToo(int Id, DateTimeOffset Date, string Name, EventType EventType,
    string Venue, int PercentageSold, int TicketPrice)
    : EventPriceDto(Id, Date, Name, EventType, Venue, PercentageSold, TicketPrice);

    //Positional properties are mutable by default!
    //Adding readonly will make the properties get/init
    public readonly record struct Coordinate(int X, int Y)
    {
        public int Z { get; init; } = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTimeOffset.Now;
            EventPriceDto dto = new(1, now, "Test", EventType.Concert, "Music hall", 80, 100);
            EventPriceDtoToo dto2 = new(1, now, "Test", EventType.Concert, "Music hall", 80, 100);
            var e = dto == dto2;

            DtoBase dto3 = dto with { Name = "Concert" };
            var isEventPrice = dto3 is EventPriceDto;

            //record struct

            Coordinate c = new(12, 42) { Z = 54 };
            Coordinate d = c with { Z = 54 };
            var (x, y) = c;
            Console.WriteLine(c);
            Console.WriteLine(c == d);
        }
    }
}