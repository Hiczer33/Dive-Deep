using diveDeep.Enum;
namespace diveDeep.Models
{
    public class Dykkerdragt
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public List <SizeType> Size { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public double? Thickness { get; set; }
        public double PricePrDay { get; set; }
        
    }
}
