using diveDeep.Models;
using System.ComponentModel.DataAnnotations;

namespace diveDeep.Persistence
{
    public class RegulatorsetRepository
    {

        private static readonly List<Regulatorset> _regulartor = new()
        {
            new Regulatorset
            {
                Brand = "Scubapro",
                FirstStep = "MK25EVO",
                SecondStep = "S600",
                Octopus = "R105",
                PricePrDay = 125
            },

            new Regulatorset
            {
                Brand = "Scubapro",
                FirstStep = "MK17EVO",
                SecondStep = "C370",
                Octopus = "R095",
                PricePrDay = 100
            },

            new Regulatorset
            {
                Brand = "Scubapro",
                FirstStep = "MK25EVO BT",
                SecondStep = "A700 Carbon BT",
                Octopus = "S270",
                PricePrDay = 150
            }

        };
    }
}
