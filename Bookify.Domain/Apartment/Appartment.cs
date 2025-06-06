﻿

namespace Bookify.Domain.Apartment
{
    public sealed class Appartment
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public string Description { get; private set; }

        public string Country { get; private set; }
        public string state { get; private set; }
        public string ZipCode { get; private set; }
        public string City  { get; private set; }

        public string Street { get; private set; }
        public decimal PriceAmount { get; private set; }

        public string PriceCurrency { get; private set; }

        public decimal CleaningFeeAmount { get; private set; }
        public  string CleaningFeeCurrency { get;  private set; }

        public DateTime? LastBookedOnUtc { get; private set; }
    }
}
