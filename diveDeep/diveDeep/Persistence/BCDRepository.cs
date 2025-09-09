using diveDeep.Enum;
using diveDeep.Models;


namespace diveDeep.Persistence
{
    public static class BCDRepository
    {
        private static readonly List<BCD> _bcd = new()
        {
            new BCD
            {   BCDId = 1,
                Brand = "Scubapro",
                Model = "Navigator Lite BCD",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 125,
                ImageUrl = "\\Images\\BCD_Pictures\\Scubapro_Navigator Lite BCD.webp"
            },

            new BCD
            {   BCDId=2,
                Brand = "Scubapro",
                Model = "BCD Glide",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 140,
                ImageUrl ="\\Images\\BCD_Pictures\\scubapro_bcdglide.webp"
            },
            new BCD
            {
                BCDId=3,
                Brand = "Scubapro",
                Model = "BCD Hydros Pro",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 200,
                ImageUrl ="\\Images\\BCD_Pictures\\Scubapro_BCDHydrosPro.webp"
            },

            new BCD
            {   BCDId=4,
                Brand = "Seac",
                Model = "BCD Modular",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 145,
                ImageUrl ="\\Images\\BCD_Pictures\\SEAC_BCDModular.webp"
            }
        };

        public static BCD? GetById(int id)
        {
            return _bcd.FirstOrDefault(x => x.BCDId == id);
        }
        public static IEnumerable<BCD> GetAll() => _bcd;
        public static BCD GetByModel(string model) => _bcd.Find(b => b.Model == model);
    }

}
