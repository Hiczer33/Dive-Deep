using diveDeep.Models;

namespace diveDeep.Persistence
{
    public static class PakkeSetRepository
    {

        private static readonly List<PakkeSet> _pakkeset = new()
        {

            new PakkeSet
            {
                Title = "Komplet Dykkersæt",
                PricePrDay = 500,
                SetInformation = "BCD, Dykkerdragt, Regulatorsæt, Tank, Finner, Maske, Snorkel",
                ImageUrl = "\\Images\\DykkerSet\\kompletdykkerset.webp"
            }

           
        };
        public static IEnumerable<PakkeSet> GetAll() => _pakkeset;

    }
}
