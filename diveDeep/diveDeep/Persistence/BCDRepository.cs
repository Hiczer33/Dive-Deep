using diveDeep.Models;
using diveDeep.Enum;


namespace diveDeep.Persistence
{
    public static class BCDRepository
    {
        private static readonly List<BCD> _bcd = new()
        {
            new BCD
            {
                Brand = "Scubapro",
                Model = "Navigator Lite BCD",
                Size = new List<SizeType> { SizeType.S, SizeType.M, SizeType.L },
                PricePrDay = 125
            }


        };
    }
}
