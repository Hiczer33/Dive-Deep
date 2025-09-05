using diveDeep.Models;
using diveDeep.Enum;

namespace diveDeep.Persistence
{
    public static class FinsRepository
    {
        private static readonly List<Fins> _fins = new()
        {
            new Fins
            {
                Brand = "Scubapro",
                Model = "Jet Fin",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 50,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"
            },

            new Fins
            {
                Brand = "Scubapro",
                Model = "GO Travel",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 50,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"

            },
            
            new Fins
            {
                Brand = "Scubapro",
                Model = "Seawing Supernova",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 60,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"

            },

            new Fins
            {
                Brand = "Seac",
                Model = "Propulsion",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 50,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"

            },

            new Fins
            {
                Brand = "Seac",
                Model = "ALA",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 50,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"
            },

            new Fins
            {
                Brand = "Fourth Element",
                Model = "Tech",
                Size = new List<SizeType> {SizeType.XS ,SizeType.S, SizeType.M, SizeType.L, SizeType.XL},
                PricePrDay = 75,
                ImageUrl = "\\Images\\Finner\\Scubapro_JetFin.jpg"

            },

            new Fins
            {
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
