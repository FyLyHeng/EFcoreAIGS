using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class ChartOfAccount
    {
        public ChartOfAccount()
        {
            AccountBillItems = new HashSet<AccountBillItem>();
            AccountBills = new HashSet<AccountBill>();
            AccountMappings = new HashSet<AccountMapping>();
            AssetCategoryGlAccuDepres = new HashSet<AssetCategory>();
            AssetCategoryGlCosts = new HashSet<AssetCategory>();
            AssetCategoryGlDepreExps = new HashSet<AssetCategory>();
            AssetCategoryGlGains = new HashSet<AssetCategory>();
            AssetCategoryGlLosses = new HashSet<AssetCategory>();
            ClearBills = new HashSet<ClearBill>();
            CoaBalances = new HashSet<CoaBalance>();
            CustomerPaymentEntries = new HashSet<CustomerPaymentEntry>();
            CustomerPrePayments = new HashSet<CustomerPrePayment>();
            Glentries = new HashSet<Glentry>();
            InverseParent = new HashSet<ChartOfAccount>();
            PurchaseRefunds = new HashSet<PurchaseRefund>();
            Refunds = new HashSet<Refund>();
            SupplierPayments = new HashSet<SupplierPayment>();
            TransactionJournals = new HashSet<TransactionJournal>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? AllowNegative { get; set; }
        public string? Description { get; set; }
        public string? GlCode { get; set; }
        public bool? LeafAccount { get; set; }
        public string? Name { get; set; }
        public long? AccountClassId { get; set; }
        public long? AccountSubClassId { get; set; }
        public long? ParentId { get; set; }

        public virtual AccountClass? AccountClass { get; set; }
        public virtual AccountSubClass? AccountSubClass { get; set; }
        public virtual ChartOfAccount? Parent { get; set; }
        public virtual ICollection<AccountBillItem> AccountBillItems { get; set; }
        public virtual ICollection<AccountBill> AccountBills { get; set; }
        public virtual ICollection<AccountMapping> AccountMappings { get; set; }
        public virtual ICollection<AssetCategory> AssetCategoryGlAccuDepres { get; set; }
        public virtual ICollection<AssetCategory> AssetCategoryGlCosts { get; set; }
        public virtual ICollection<AssetCategory> AssetCategoryGlDepreExps { get; set; }
        public virtual ICollection<AssetCategory> AssetCategoryGlGains { get; set; }
        public virtual ICollection<AssetCategory> AssetCategoryGlLosses { get; set; }
        public virtual ICollection<ClearBill> ClearBills { get; set; }
        public virtual ICollection<CoaBalance> CoaBalances { get; set; }
        public virtual ICollection<CustomerPaymentEntry> CustomerPaymentEntries { get; set; }
        public virtual ICollection<CustomerPrePayment> CustomerPrePayments { get; set; }
        public virtual ICollection<Glentry> Glentries { get; set; }
        public virtual ICollection<ChartOfAccount> InverseParent { get; set; }
        public virtual ICollection<PurchaseRefund> PurchaseRefunds { get; set; }
        public virtual ICollection<Refund> Refunds { get; set; }
        public virtual ICollection<SupplierPayment> SupplierPayments { get; set; }
        public virtual ICollection<TransactionJournal> TransactionJournals { get; set; }
    }
}
