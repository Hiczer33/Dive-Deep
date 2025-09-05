using diveDeep.Models;
namespace diveDeep.Persistence

{
    public static class TankRepository
    {
        private static readonly List<Tank> _tank = new()
        {
            new Tank
            {
                Brand = "Scubapro",
                Volume = 5,
                PricePrDay = 150,
                ImageUrl ="\\Images\\Tanke\\Scubapro_15L.webp"

            },
            new Tank
            {
                Brand = "Scubapro",
                Volume = 10,
                PricePrDay = 160,
                ImageUrl ="\\Images\\Tanke\\Scubapro_15L.webp"

            },
            new Tank
            {
                Brand = "Scubapro",
                Volume = 12,
                PricePrDay = 170,
                ImageUrl ="\\Images\\Tanke\\Scubapro_15L.webp"


            },new Tank
            {
                Brand = "Scubapro",
                Volume = 15,
                PricePrDay = 170,
                ImageUrl ="\\Images\\Tanke\\Scubapro_15L.webp"

            },



        };

        public static IEnumerable<Tank> GetAll() => _tank;

    }
}
