using diveDeep.Models;

namespace diveDeep.Persistence
{
    public static class Mask_SnorkelRepository
    {
        private static readonly List<Mask_Snorkel> _mask = new()
        {

            new Mask_Snorkel
            {
                Brand = "Scubapro",
                Model = "Ghost",
                PricePrDay = 50
            },

            new Mask_Snorkel
            {
                Brand = "Scubapro",
                Model = "D-Mask",
                PricePrDay = 60
            },

            new Mask_Snorkel
            {
                Brand = "Scubapro",
                Model = "Spectra Mini",
                PricePrDay = 50
            },

            new Mask_Snorkel
            {
                Brand = "Scubapro",
                Model = "Crystal VU",
                PricePrDay = 75
            },

            new Mask_Snorkel
            {
                Brand = "Fourth Element",
                Model = "Scout Kontrast",
                PricePrDay = 75
            },

            new Mask_Snorkel
            {
                Brand = "Fourth Element",
                Model = "Scout Enhance",
                PricePrDay = 75
            },

            new Mask_Snorkel
            {
                Brand = "Tusa",
                Model = "Element",
                PricePrDay = 75
            }

        };

        public static IEnumerable<Mask_Snorkel> GetAll() => _mask;

    }

}

