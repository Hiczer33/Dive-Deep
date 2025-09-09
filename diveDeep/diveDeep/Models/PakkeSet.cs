namespace diveDeep.Models
{
    public class PakkeSet
    {
        public int PakkeSetID { get; set; }
        public string Title { get; set; }
        public double PricePrDay { get; set; }
        public string SetInformation { get; set; }

        public string ImageUrl { get; set; }

        //•	Komplette dykkersæt (BCD, dykkerdragt, regulatorsæt, tank, finner, maske, snorkel)
    }

}
