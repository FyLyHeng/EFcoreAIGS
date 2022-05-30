using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class AccountBillItem
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? Amount { get; set; }
        public string? Ref { get; set; }
        public long? AccountBillId { get; set; }
        public long? ChartOfAccountId { get; set; }

        public virtual AccountBill? AccountBill { get; set; }
        public virtual ChartOfAccount? ChartOfAccount { get; set; }
    }
}
