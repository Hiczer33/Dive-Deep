using diveDeep.Models;

namespace diveDeep.Persistence
{
    public class RegulatorsetRepository
    {

        private static readonly List<Regulatorset> _regulartor = new()
        {
            new Regulatorset
            {
                RegulatorsetID = 1,
                Brand = "Scubapro",
                FirstStep = "MK25EVO",
                SecondStep = "S600",
                Octopus = "R105",
                PricePrDay = 125,
                ImageUrl = "\\Images\\Regulatorsæt\\Scubapro_MK25EVO.webp"
            },

            new Regulatorset
            {   RegulatorsetID=2,
                Brand = "Scubapro",
                FirstStep = "MK17EVO",
                SecondStep = "C370",
                Octopus = "R095",
                PricePrDay = 100,
                ImageUrl = "\\Images\\Regulatorsæt\\Scubapro_MK25EVO.webp"

            },

            new Regulatorset
            {
                RegulatorsetID = 3,
                Brand = "Scubapro",
                FirstStep = "MK25EVO BT",
                SecondStep = "A700 Carbon BT",
                Octopus = "S270",
                PricePrDay = 150,
                ImageUrl = "\\Images\\Regulatorsæt\\Scubapro_MK25EVO.webp"

            }

        };

        public static IEnumerable<Regulatorset> GetAll() => _regulartor;

    }
}
