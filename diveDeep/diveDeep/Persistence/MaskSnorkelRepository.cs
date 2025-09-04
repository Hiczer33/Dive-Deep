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
                PricePrDay = 50
            },

            new MaskSnorkel
            {
                Brand = "Scubapro",
                Model = "D-Mask",
                PricePrDay = 60
            },

            new MaskSnorkel
            {
                Brand = "Scubapro",
                Model = "Spectra Mini",
                PricePrDay = 50
            },

            new MaskSnorkel
            {
                Brand = "Scubapro",
                Model = "Crystal VU",
                PricePrDay = 75
            },

            new MaskSnorkel
            {
                Brand = "Fourth Element",
                Model = "Scout Kontrast",
                PricePrDay = 75
            },

            new MaskSnorkel
            {
                Brand = "Fourth Element",
                Model = "Scout Enhance",
                PricePrDay = 75
            },

            new MaskSnorkel
            {
                Brand = "Tusa",
                Model = "Element",
                PricePrDay = 75
            }

        };

        public static IEnumerable<Mask_Snorkel> GetAll() => _mask;

    }

}

