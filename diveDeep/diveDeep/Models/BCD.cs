using diveDeep.Enum;
namespace diveDeep.Models

{
    public class BCD
    {
        public required string Brand { get; set; }
        public required string Model { get; set; }
        public required List<SizeType> Size { get; set; }
        public required double PricePrDay { get; set; }
        public required string ImageUrl { get; set; }
    }
}
