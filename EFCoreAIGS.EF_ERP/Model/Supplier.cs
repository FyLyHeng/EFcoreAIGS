using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Supplier
    {
        public Supplier()
        {
            AccountBills = new HashSet<AccountBill>();
            DebitNotes = new HashSet<DebitNote>();
            Glentries = new HashSet<Glentry>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            PurchaseReceiptExpanses = new HashSet<PurchaseReceiptExpanse>();
            PurchaseReceipts = new HashSet<PurchaseReceipt>();
            PurchaseRefunds = new HashSet<PurchaseRefund>();
            PurchaseReturns = new HashSet<PurchaseReturn>();
            SerialNos = new HashSet<SerialNo>();
            SupplierPayments = new HashSet<SupplierPayment>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Address { get; set; }
        public string? Code { get; set; }
        public string? ContactName { get; set; }
        public string? ContactPhone { get; set; }
        public string? Email { get; set; }
        public double? PrepaymentBalance { get; set; }
        public string? SupplierName { get; set; }
        public int? Vat { get; set; }
        public long? SupplierGroupId { get; set; }
        public long? SupplierTypeId { get; set; }

        public virtual SupplierGroup? SupplierGroup { get; set; }
        public virtual SupplierType? SupplierType { get; set; }
        public virtual ICollection<AccountBill> AccountBills { get; set; }
        public virtual ICollection<DebitNote> DebitNotes { get; set; }
        public virtual ICollection<Glentry> Glentries { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<PurchaseReceiptExpanse> PurchaseReceiptExpanses { get; set; }
        public virtual ICollection<PurchaseReceipt> PurchaseReceipts { get; set; }
        public virtual ICollection<PurchaseRefund> PurchaseRefunds { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturns { get; set; }
        public virtual ICollection<SerialNo> SerialNos { get; set; }
        public virtual ICollection<SupplierPayment> SupplierPayments { get; set; }
    }
}
