using diveDeep.Models;
using diveDeep.Enum;

namespace diveDeep.Persistence
{
    public static class DykkerdragtRpeository
    {
        private static readonly List<Dykkerdragt> _dykkerdragt = new()
                    {
                        new Dykkerdragt
                        {
                            Brand = "Scubapro",
                            Model = "Definition",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 3,
                            PricePrDay = 100,
                        },
                        new Dykkerdragt
                        {
                            Brand = "Scubapro",
                            Model = "Definition",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 5,
                            PricePrDay = 100,
                        },
                        new Dykkerdragt
                        {
                            Brand = "Scubapro",
                            Model = "Definition",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 7,
                            PricePrDay = 100,
                        },
                        new Dykkerdragt
                        {
                            Brand = "Waterproof",
                            Model = "W5",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 3.5,
                            PricePrDay = 100,
                        },
                        new Dykkerdragt
                        {
                            Brand = "Fourth Element",
                            Model = "Proteus",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 5,
                            PricePrDay = 120,
                        },
                        new Dykkerdragt
                        {
                            Brand = "Scubapro",
                            Model = "Exodry 4.0",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Tørdragt",
                            Gender = "Herre/Dame",
                            Thickness = null,
                            PricePrDay = 300,
                        },
                        new Dykkerdragt
                        {
                            Brand = "Waterproof",
                            Model = "D7 Evo",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Tørdragt",
                            Gender = "Herre/Dame",
                            Thickness = null,
                            PricePrDay = 320,
                        },
                        new Dykkerdragt
                        {
                            Brand = "Santi",
                            Model = "E.Lite Plus",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Tørdragt",
                            Gender = "Herre/Dame",
                            Thickness = null,
                            PricePrDay = 350,
                        }
                    };
    }
}
