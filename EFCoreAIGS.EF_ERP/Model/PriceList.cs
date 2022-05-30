using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PriceList
    {
        public PriceList()
        {
            CustomerGroups = new HashSet<CustomerGroup>();
            Customers = new HashSet<Customer>();
            ItemPrices = new HashSet<ItemPrice>();
            ItemWarehouses = new HashSet<ItemWarehouse>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            PurchaseReceipts = new HashSet<PurchaseReceipt>();
            Quotations = new HashSet<Quotation>();
            SaleOrders = new HashSet<SaleOrder>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsBuying { get; set; }
        public bool? Enable { get; set; }
        public bool? IsSelling { get; set; }
        public string PriceListName { get; set; } = null!;
        public long? CurrencyId { get; set; }

        public virtual Currency? Currency { get; set; }
        public virtual ICollection<CustomerGroup> CustomerGroups { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<ItemPrice> ItemPrices { get; set; }
        public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<PurchaseReceipt> PurchaseReceipts { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    }
}
