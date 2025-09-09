using diveDeep.Enum;
using diveDeep.Models;

namespace diveDeep.Persistence
{
    public static class DykkerdragtRpeository
    {
        private static readonly List<Dykkerdragt> _dykkerdragt = new()
                    {
                        new Dykkerdragt
                        {   DykkerDragtID=1,
                            Brand = "Scubapro",
                            Model = "Definition",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 3,
                            PricePrDay = 100,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"
                        },
                        new Dykkerdragt
                        {   DykkerDragtID = 2,
                            Brand = "Scubapro",
                            Model = "Definition",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 5,
                            PricePrDay = 100,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {
                            DykkerDragtID =3,
                            Brand = "Scubapro",
                            Model = "Definition",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 7,
                            PricePrDay = 100,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {   DykkerDragtID=4,
                            Brand = "Waterproof",
                            Model = "W5",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 3.5,
                            PricePrDay = 100,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"


                        },
                        new Dykkerdragt
                        {   DykkerDragtID =5,
                            Brand = "Fourth Element",
                            Model = "Proteus",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = "Herre/Dame",
                            Thickness = 5,
                            PricePrDay = 120,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {   DykkerDragtID=6,
                            Brand = "Scubapro",
                            Model = "Exodry 4.0",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Tørdragt",
                            Gender = "Herre/Dame",
                            Thickness = null,
                            PricePrDay = 300,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {   DykkerDragtID=7,
                            Brand = "Waterproof",
                            Model = "D7 Evo",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Tørdragt",
                            Gender = "Herre/Dame",
                            Thickness = null,
                            PricePrDay = 320,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {   DykkerDragtID = 8,
                            Brand = "Santi",
                            Model = "E.Lite Plus",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Tørdragt",
                            Gender = "Herre/Dame",
                            Thickness = null,
                            PricePrDay = 350,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        }
                    };
        public static IEnumerable<Dykkerdragt> GetAll() => _dykkerdragt;
    }
}
