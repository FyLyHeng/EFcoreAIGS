using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            Companies = new HashSet<Company>();
            Customers = new HashSet<Customer>();
            DeliveryNotes = new HashSet<DeliveryNote>();
            InverseParent = new HashSet<Warehouse>();
            Invoices = new HashSet<Invoice>();
            ItemWarehouses = new HashSet<ItemWarehouse>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            PurchaseReceipts = new HashSet<PurchaseReceipt>();
            PurchaseReturns = new HashSet<PurchaseReturn>();
            Quotations = new HashSet<Quotation>();
            SaleOrders = new HashSet<SaleOrder>();
            SaleReturns = new HashSet<SaleReturn>();
            SerialNos = new HashSet<SerialNo>();
            StockBalances = new HashSet<StockBalance>();
            StockLedgerEntries = new HashSet<StockLedgerEntry>();
            StockMoves = new HashSet<StockMove>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsDisable { get; set; }
        public bool? IsGroup { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public bool? IsUsed { get; set; }
        public string? WarehouseName { get; set; }
        public long? AccountId { get; set; }
        public long? ParentId { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Warehouse? Parent { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<DeliveryNote> DeliveryNotes { get; set; }
        public virtual ICollection<Warehouse> InverseParent { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<PurchaseReceipt> PurchaseReceipts { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturns { get; set; }
        public virtual ICollection<Quotation> Quotations { get; set; }
        public virtual ICollection<SaleOrder> SaleOrders { get; set; }
        public virtual ICollection<SaleReturn> SaleReturns { get; set; }
        public virtual ICollection<SerialNo> SerialNos { get; set; }
        public virtual ICollection<StockBalance> StockBalances { get; set; }
        public virtual ICollection<StockLedgerEntry> StockLedgerEntries { get; set; }
        public virtual ICollection<StockMove> StockMoves { get; set; }
    }
}
