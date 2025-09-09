using diveDeep.Enum;
using diveDeep.Models;

namespace diveDeep.Persistence
{
    public static class FinsRepository
    {
        private static readonly List<Fins> _fins = new()
        {
            new Fins
            {
                FinsID =1,
                Brand = "Scubapro",
                Model = "Jet Fin",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 50,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"
            },

            new Fins
            {   FinsID =2,
                Brand = "Scubapro",
                Model = "GO Travel",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 50,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"

            },

            new Fins
            {   FinsID=3,
                Brand = "Scubapro",
                Model = "Seawing Supernova",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 60,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"

            },

            new Fins
            {   FinsID=4,
                Brand = "Seac",
                Model = "Propulsion",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 50,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"

            },

            new Fins
            {
                FinsID=5,
                Brand = "Seac",
                Model = "ALA",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 50,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"
            },

            new Fins
            {   FinsID=6,
                Brand = "Fourth Element",
                Model = "Tech",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 75,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"

            },

            new Fins
            {
                FinsID=7,
                Brand = "Fourth Element",
                Model = "Rec Fin",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 80,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"

            }

        };
        public static IEnumerable<Fins> GetAll() => _fins;

    }
}
