using diveDeep.Models;

namespace diveDeep.Persistence
{
    public static class MaskSnorkelRepository
    {
        private static readonly List<MaskSnorkel> _mask = new()
        {

            new MaskSnorkel
            {   MaskSnorkelID =1,
                Brand = "Scubapro",
                Model = "Ghost",
                PricePrDay = 50,
                ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {   MaskSnorkelID=2,
                Brand = "Scubapro",
                Model = "D-Mask",
                PricePrDay = 60,
                ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {
                MaskSnorkelID=3,
                Brand = "Scubapro",
                Model = "Spectra Mini",
                PricePrDay = 50,
                ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {   MaskSnorkelID=4,
                Brand = "Scubapro",
                Model = "Crystal VU",
                PricePrDay = 75,
               ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {
                MaskSnorkelID=5,
                Brand = "Fourth Element",
                Model = "Scout Kontrast",
                PricePrDay = 75,
              ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {   MaskSnorkelID=6,
                Brand = "Fourth Element",
                Model = "Scout Enhance",
                PricePrDay = 75,
                ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {
                MaskSnorkelID=7,
                Brand = "Tusa",
                Model = "Element",
                PricePrDay = 75,
                ImageUrl ="\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            }

        };

        public static IEnumerable<MaskSnorkel> GetAll() => _mask;

    }

}

