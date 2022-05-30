using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Customer
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
            CreditNotes = new HashSet<CreditNote>();
            CustomerBalances = new HashSet<CustomerBalance>();
            CustomerPaymentEntries = new HashSet<CustomerPaymentEntry>();
            CustomerPrePayments = new HashSet<CustomerPrePayment>();
            DeliveryNotes = new HashSet<DeliveryNote>();
            Glentries = new HashSet<Glentry>();
            Invoices = new HashSet<Invoice>();
            Quotations = new HashSet<Quotation>();
            Refunds = new HashSet<Refund>();
            SaleOrders = new HashSet<SaleOrder>();
            SaleReturns = new HashSet<SaleReturn>();
            SerialNos = new HashSet<SerialNo>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Address { get; set; }
        public string? Contact { get; set; }
        public int? CreditLength { get; set; }
        public double? CreditLimit { get; set; }
        public int? CustomerType { get; set; }
        public bool Disable { get; set; }
        public string? IdCard { get; set; }
        public bool? IsInternalCustomer { get; set; }
        public string? Name { get; set; }
        public string? NameKh { get; set; }
        public bool? IsPassCreditLimit { get; set; }
        public string? PaymentTerm { get; set; }
        public string? Series { get; set; }
        public string? TaxId { get; set; }
        public string? VatIn { get; set; }
        public long? CurrencyId { get; set; }
        public long CustomerGroupId { get; set; }
        public long? GenderId { get; set; }
        public long? PriceListId { get; set; }
        public long? SalePersonId { get; set; }
        public long? SalutationId { get; set; }
        public long? TerritoryId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual CustomerGroup CustomerGroup { get; set; } = null!;
        public virtual Gender? Gender { get; set; }
        public virtual PriceList? PriceList { get; set; }
        public virtual SalePerson? SalePerson { get; set; }
        public virtual Salutation? Salutation { get; set; }
        public virtual Territory? Territory { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CreditNote> CreditNotes { get; set; }
        public virtual ICollection<CustomerBalance> CustomerBalances { get; set; }
        public virtual ICollection<CustomerPaymentEntry> CustomerPaymentEntries { get; set; }
        public virtual ICollection<CustomerPrePayment> CustomerPrePayments { get; set; }
        public virtual ICollection<DeliveryNote> DeliveryNotes { get; set; }
        public virtual ICollection<Glentry> Glentries { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
        public virtual ICollection<Refund> Refunds { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<SaleReturn> SaleReturns { get; set; }
        public virtual ICollection<SerialNo> SerialNos { get; set; }
    }
}
