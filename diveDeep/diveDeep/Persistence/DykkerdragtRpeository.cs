using diveDeep.Enum;
using diveDeep.Models;

namespace diveDeep.Persistence
{
    public static class DykkerdragtRpeository
    {
        private static readonly List<Dykkerdragt> _dykkerdragt = new()
                    {
                        new Dykkerdragt
                        {   DykkerDragtId=1,
                            Brand = "Scubapro",
                            Model = "Definition",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = new List<GenderType>{GenderType.Mand ,GenderType.Kvinde },
                            Thickness = 3,
                            PricePrDay = 100,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp",
                            Description="Den nye Definition 5.0 heldragt våddragt / semidry tilbyder mere stretch, mere komfort og flere funktioner.\r\n\r\nDragten er konstrueret med Ultraspan-panel over brystet og Stretchtec-materiale i siderne, armene, benene og brystområdet. Det betyder, at dragten – når den sidder rigtigt – slutter tæt til kroppen og dermed maksimerer din varmeisolering under dit dyk.\r\n\r\nSom ekstra varmeforstærkning har dragten infrarød indvendig isolering på brystet og ryggen, som reflekterer din kropsvarme tilbage mod kroppen. Resten af dragten er foret med sølv, hvilket også hjælper med at holde på varmen. Det gør den oplagt til dykning i danske farvande i de varme måneder.\r\n\r\nScubapro har desuden haft fokus på komfort og brugervenlighed. Lynlåsen i messing løber diagonalt hen over ryggen og trykker dermed ikke direkte mod rygraden. Samtidig er der indsyede puder i ryggen, som reducerer presset fra din BCD og tank.\r\n\r\nOg ingen lugt af kemikalier! Neoprenen er baseret på kalksten og har derfor ikke den typiske petroleumslugt. Kalkstensbaseret neopren er også mere hudvenligt, og vi har ikke oplevet irritation eller udslæt, som man ellers kan få fra traditionelle neoprendragter.\r\nMiljømæssigt er kalkstens-neopren også et grønnere valg – det udleder mindre CO₂ under produktion og påvirker havmiljøet i mindre grad.\r\n\r\nDe mest udsatte områder som skuldre, bagdel, knæ og albuer er forstærket med ekstra slidstærkt materiale, hvilket forlænger dragtens levetid. Derudover medfølger to I-Safe®-stropper – én på hver arm – som holder udstyr som dykkerur eller dykkercomputer sikkert på plads under dybe dyk, hvor dragten komprimeres."
    },
                        new Dykkerdragt
                        {   DykkerDragtId = 2,
                            Brand = "Scubapro",
                            Model = "Definition",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = new List<GenderType>{GenderType.Mand ,GenderType.Kvinde},
                            Thickness = 5,
                            PricePrDay = 100,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {
                            DykkerDragtId =3,
                            Brand = "Scubapro",
                            Model = "Definition",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = new List < GenderType > { GenderType.Mand, GenderType.Kvinde },
                            Thickness = 7,
                            PricePrDay = 100,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {   DykkerDragtId=4,
                            Brand = "Waterproof",
                            Model = "W5",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = new List < GenderType > { GenderType.Mand, GenderType.Kvinde },
                            Thickness = 3.5,
                            PricePrDay = 100,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"


                        },
                        new Dykkerdragt
                        {   DykkerDragtId =5,
                            Brand = "Fourth Element",
                            Model = "Proteus",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Våddragt",
                            Gender = new List < GenderType > { GenderType.Mand, GenderType.Kvinde },
                            Thickness = 5,
                            PricePrDay = 120,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {   DykkerDragtId=6,
                            Brand = "Scubapro",
                            Model = "Exodry 4.0",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Tørdragt",
                            Gender = new List < GenderType > { GenderType.Mand, GenderType.Kvinde },
                            Thickness = null,
                            PricePrDay = 300,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {   DykkerDragtId=7,
                            Brand = "Waterproof",
                            Model = "D7 Evo",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Tørdragt",
                            Gender = new List < GenderType > { GenderType.Mand, GenderType.Kvinde },
                            Thickness = null,
                            PricePrDay = 320,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        },
                        new Dykkerdragt
                        {   DykkerDragtId = 8,
                            Brand = "Santi",
                            Model = "E.Lite Plus",
                            Size = new List<SizeType> { SizeType.XS, SizeType.S, SizeType.M, SizeType.L, SizeType.XL },
                            Type = "Tørdragt",
                            Gender = new List < GenderType > { GenderType.Mand, GenderType.Kvinde },
                            Thickness = null,
                            PricePrDay = 350,
                            ImageUrl = "\\Images\\Dykkerdragter\\Scubapro_Difinition3mm.webp"

                        }
                    };
        public static IEnumerable<Dykkerdragt> GetAll() => _dykkerdragt;
        public static Dykkerdragt? GetById(int id)
        {
            return _dykkerdragt.FirstOrDefault(x => x.DykkerDragtId == id);
        }
    }
}
