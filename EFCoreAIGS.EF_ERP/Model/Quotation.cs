using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Quotation
    {
        public Quotation()
        {
            QuotationDetails = new HashSet<QuotationDetail>();
            SaleOrders = new HashSet<SaleOrder>();
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
        public string? BillingAddress { get; set; }
        public int? BillingAddressId { get; set; }
        public string? BillingTitle { get; set; }
        public int? CusPurchaseOrder { get; set; }
        public string? CustomStatus { get; set; }
        public DateTime? EstimateDeliveryDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public float? GrandTotal { get; set; }
        public bool? IsIncludeVat { get; set; }
        public DateTime? PostDate { get; set; }
        public string? Series { get; set; }
        public string? ShippingAddress { get; set; }
        public int? ShippingAddressId { get; set; }
        public string? ShippingTitle { get; set; }
        public double? Total { get; set; }
        public float? TotalCost { get; set; }
        public int? TotalQty { get; set; }
        public float? TotalTaxCharge { get; set; }
        public float? VatAmount { get; set; }
        public float? VatPer { get; set; }
        public long? CurrencyId { get; set; }
        public long? CustomerId { get; set; }
        public long? PriceListId { get; set; }
        public long? SaleOrderId { get; set; }
        public long? SalePersonId { get; set; }
        public long? TermConditionId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual PriceList? PriceList { get; set; }
        public virtual SaleOrder? SaleOrder { get; set; }
        public virtual SalePerson? SalePerson { get; set; }
        public virtual TermCondition? TermCondition { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<QuotationDetail> QuotationDetails { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
