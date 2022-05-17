using System;
using System.Collections.Generic;

namespace EFCoreAIGS.DataScaffold
{
    public partial class Item
    {
        public Item()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
            StockTransactions = new HashSet<StockTransaction>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public long? AccountId { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public long? CategoryId { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<StockTransaction> StockTransactions { get; set; }
    }
}
