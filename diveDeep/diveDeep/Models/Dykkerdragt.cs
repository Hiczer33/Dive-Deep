using diveDeep.Enum;
namespace diveDeep.Models
{
    public class Dykkerdragt
    {
        public required string Brand { get; set; }
        public  required string Model { get; set; }
        public required List <SizeType> Size { get; set; }
        public required string Type { get; set; }
        public required string Gender { get; set; }
        public required double? Thickness { get; set; }
        public required double PricePrDay { get; set; }
        public required string ImageUrl { get; set; }


    }
}
