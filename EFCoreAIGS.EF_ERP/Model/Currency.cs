using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Currency
    {
        public Currency()
        {
            AccountBills = new HashSet<AccountBill>();
            Accounts = new HashSet<Account>();
            ClearBills = new HashSet<ClearBill>();
            CoaBalances = new HashSet<CoaBalance>();
            Companies = new HashSet<Company>();
            Customers = new HashSet<Customer>();
            ItemPrices = new HashSet<ItemPrice>();
            JournalEntries = new HashSet<JournalEntry>();
            PriceLists = new HashSet<PriceList>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            PurchaseReceipts = new HashSet<PurchaseReceipt>();
            Quotations = new HashSet<Quotation>();
            SaleOrders = new HashSet<SaleOrder>();
            SaleReturns = new HashSet<SaleReturn>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Currency1 { get; set; }
        public string? CurrencyCode { get; set; }
        public bool? IsUsed { get; set; }

        public virtual ICollection<AccountBill> AccountBills { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<ClearBill> ClearBills { get; set; }
        public virtual ICollection<CoaBalance> CoaBalances { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<ItemPrice> ItemPrices { get; set; }
        public virtual ICollection<JournalEntry> JournalEntries { get; set; }
        public virtual ICollection<PriceList> PriceLists { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<PurchaseReceipt> PurchaseReceipts { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<SaleReturn> SaleReturns { get; set; }
    }
}
