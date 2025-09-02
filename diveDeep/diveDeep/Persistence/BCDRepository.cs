using diveDeep.Models;
using diveDeep.Enum;


namespace diveDeep.Persistence
{
    public static class BCDRepository
    {
        private static readonly List<BCD> _bcd = new()
        {
            new BCD
            {
                Brand = "Scubapro",
                Model = "Navigator Lite BCD",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 125
            },

            new BCD
            {
                Brand = "Scubapro",
                Model = "BCD Glide",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 140
            },
            new BCD
            {
                Brand = "Scubapro",
                Model = "BCD Hydros Pro",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 200
            },

            new BCD
            {
                Brand = "Seac",
                Model = "BCD Modular",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 145
            }
        };
       
        //public static IEnumerable<BCD> GetAll() => _bcd;
        //public static BCD GetByModel(string model) => _bcd.Find(b => b.Model == model);
    }

}
