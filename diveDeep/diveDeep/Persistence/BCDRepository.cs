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
                ImageUrl = "\\Images\\BCD_Pictures\\Scubapro_Navigator Lite BCD.webp",
                Description = "Scubapro Navigator Lite er en ny, letvægts ryginflations-BCD, designet specielt til den rekreative rejse-dykker. Den kombinerer en enkel, men slidstærk konstruktion med et unikt, modulært design og muligheden for at personliggøre udstyret med forskellige farvekombinationer. Med sin foldbare Airnet®-rygplade, robust materialevalg og udskiftelige komponenter er Navigator Lite ideel til rejser og dykning under mange forskellige forhold"
            },

            new BCD
            {   BCDId=2,
                Brand = "Scubapro",
                Model = "BCD Glide",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 140,
                ImageUrl ="\\Images\\BCD_Pictures\\scubapro_bcdglide.webp",
                Description = "Glide BCD'en fra Scubapro er en front-justerbar BCD i traditionel stil, primært rettet til det mandlige køn. Den kvindelige model findes også her på siden under navnet Bella.\r\n\r\nBåde Glide og Bella er designet til at yde maksimal komfort og performance, hvilket tydeligt ses i den velpolstrede og bløde inderside, samt det robuste ydre med mange d-ringe, lommer og Scubapro's power-inflator. Begge BCD'er kommer med y-formede skulderstropper der sidder optimalt over bryst og skulder, og samtidig øger rækkevide og bevægelighed i skulderleddet. Bella BCD'en er her optimeret til kvinder med større brystparti. \r\n\r\nPå BCD'en er monteret 3 velfungerende dump-ventiler, der tilladder dykkeren at dumpe luften, uanset hvilken position denne måtte have i vandet. Desuden kommer denne type BCD med integrede blylommer, der snildt kan rumme op mod 4 kg i hver side, samt to trimlommer på ryggen der hver kan holde 1 kg."

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
