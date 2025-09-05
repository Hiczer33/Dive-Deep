using diveDeep.Models;

namespace diveDeep.Persistence
{
    public static class MaskSnorkelRepository
    {
        private static readonly List<MaskSnorkel> _mask = new()
        {

            new MaskSnorkel
            {
                Brand = "Scubapro",
                Model = "Ghost",
                PricePrDay = 50,
                ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {
                Brand = "Scubapro",
                Model = "D-Mask",
                PricePrDay = 60,
                ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {
                Brand = "Scubapro",
                Model = "Spectra Mini",
                PricePrDay = 50,
                ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {
                Brand = "Scubapro",
                Model = "Crystal VU",
                PricePrDay = 75,
               ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {
                Brand = "Fourth Element",
                Model = "Scout Kontrast",
                PricePrDay = 75,
              ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {
                Brand = "Fourth Element",
                Model = "Scout Enhance",
                PricePrDay = 75,
                ImageUrl = "\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            },

            new MaskSnorkel
            {
                Brand = "Tusa",
                Model = "Element",
                PricePrDay = 75,
                ImageUrl ="\\Images\\MakseSnorkel\\Scubapro_Ghost.jpg"
            }

        };

        public static IEnumerable<MaskSnorkel> GetAll() => _mask;

    }

}

