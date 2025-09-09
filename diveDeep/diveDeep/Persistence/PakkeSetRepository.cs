using diveDeep.Models;

namespace diveDeep.Persistence
{
    public static class PakkeSetRepository
    {

        private static readonly List<PakkeSet> _pakkeset = new()
        {

            new PakkeSet
            {
                PakkeSetID = 1,
                Title = "Komplet Dykkersæt",
                PricePrDay = 500,
                SetInformation = "BCD, Dykkerdragt, Regulatorsæt, Tank, Finner, Maske, Snorkel",
                ImageUrl = "\\Images\\DykkerSet\\kompletdykkerset.webp"
            },

           new PakkeSet
           {
               PakkeSetID = 2,
               Title="Komplet Snorkelsæt",
               PricePrDay=400,
               SetInformation ="Maske/Snorkel,Finner",
               ImageUrl="\\Images\\DykkerSet\\kompletMaskeFInner.jpg"

           }
        };
        public static IEnumerable<PakkeSet> GetAll() => _pakkeset;

    }
}
