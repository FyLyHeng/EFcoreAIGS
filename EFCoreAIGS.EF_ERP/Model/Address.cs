using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Address
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsBillingAddress { get; set; }
        public bool? IsShippingAddress { get; set; }
        public string? Address1 { get; set; }
        public string? Email { get; set; }
        public string? HouseNo { get; set; }
        public bool? IsDefaultBillingAdd { get; set; }
        public bool? IsDefaultShippingAdd { get; set; }
        public string? Phone { get; set; }
        public string? PostalCode { get; set; }
        public string? StreetNo { get; set; }
        public string? Title { get; set; }
        public long? AddressTypeId { get; set; }
        public long? BillingAddressId { get; set; }
        public long? CityId { get; set; }
        public long? CommuneId { get; set; }
        public long? CountryId { get; set; }
        public long? CustomerId { get; set; }
        public long? DistrictId { get; set; }
        public long? ProvinceId { get; set; }
        public long? ShippingAddressId { get; set; }
        public long? VillageId { get; set; }

        public virtual AddressType? AddressType { get; set; }
        public virtual SaleOrder? BillingAddress { get; set; }
        public virtual City? City { get; set; }
        public virtual Commune? Commune { get; set; }
        public virtual Country? Country { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual District? District { get; set; }
        public virtual Province? Province { get; set; }
        public virtual SaleOrder? ShippingAddress { get; set; }
        public virtual Village? Village { get; set; }
    }
}
