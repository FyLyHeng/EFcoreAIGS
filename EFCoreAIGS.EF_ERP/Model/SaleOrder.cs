using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SaleOrder
    {
        public SaleOrder()
        {
            AddressBillingAddresses = new HashSet<Address>();
            AddressShippingAddresses = new HashSet<Address>();
            CustomerPrePaymentReferences = new HashSet<CustomerPrePaymentReference>();
            DeliveryNotes = new HashSet<DeliveryNote>();
            Invoices = new HashSet<Invoice>();
            Quotations = new HashSet<Quotation>();
            SaleOrderDetails = new HashSet<SaleOrderDetail>();
            SaleReturns = new HashSet<SaleReturn>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public float? AdditionalDisAmount { get; set; }
        public float? AdditionalDisPer { get; set; }
        public string? AdditionalNote { get; set; }
        public string? BilledStatus { get; set; }
        public string? BillingAddress { get; set; }
        public int? BillingAddressId { get; set; }
        public string? BillingTitle { get; set; }
        public int? CusPurchaseOrder { get; set; }
        public string? CustomStatus { get; set; }
        public string? DeliveryStatus { get; set; }
        public DateTime? EstimateDeliveryDate { get; set; }
        public string? FirstProcessFlow { get; set; }
        public float? GrandTotal { get; set; }
        public bool? IsDeposit { get; set; }
        public bool? IsIncludeVat { get; set; }
        public float? PerBilled { get; set; }
        public float? PerDelivered { get; set; }
        public DateTime? PostDate { get; set; }
        public double? PrepaymentAmount { get; set; }
        public double? PrepaymentBalance { get; set; }
        public string? Series { get; set; }
        public string? ShippingAddress { get; set; }
        public int? ShippingAddressId { get; set; }
        public string? ShippingTitle { get; set; }
        public double? Total { get; set; }
        public double? TotalCost { get; set; }
        public int? TotalQty { get; set; }
        public float? TotalTaxCharge { get; set; }
        public double? VatAmount { get; set; }
        public float? VatPer { get; set; }
        public long? CurrencyId { get; set; }
        public long? CustomerId { get; set; }
        public long? PriceListId { get; set; }
        public long? QuotationId { get; set; }
        public long? SalePersonId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual PriceList? PriceList { get; set; }
        public virtual Quotation? Quotation { get; set; }
        public virtual SalePerson? SalePerson { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<Address> AddressBillingAddresses { get; set; }
        public virtual ICollection<Address> AddressShippingAddresses { get; set; }
        public virtual ICollection<CustomerPrePaymentReference> CustomerPrePaymentReferences { get; set; }
        public virtual ICollection<DeliveryNote> DeliveryNotes { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
        public virtual ICollection<SaleReturn> SaleReturns { get; set; }
    }
}
