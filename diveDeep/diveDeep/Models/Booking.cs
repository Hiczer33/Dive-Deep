using System;
using System.Collections.Generic;

namespace diveDeep.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PeopleCount { get; set; }
        public decimal PricePrDay { get; set; }
        public decimal TotalPrice
        {
            get
            {
                int days = (EndDate - StartDate).Days;
                if (days < 1) days = 1;

                decimal productSum = 0;
                foreach (var p in Products)
                {
                    productSum += p.PricePrDay;
                }

                return days * productSum * (PeopleCount > 0 ? PeopleCount : 1);
            }
        }
    }
}

