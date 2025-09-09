using diveDeep.Enum;

namespace diveDeep.Models
{
    public class CartItem
    {
        public ProductType ProductType { get; set; }
        public int ProductId { get; set; }
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";

    }
}
