using diveDeep.Enum;

namespace diveDeep.Models
{
    public class Fins
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<SizeType> Size { get; set; }
        public double PricePrDay { get; set; }
        public string ImageUrl { get; set; }



    }
}
