using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class CustomerBalance
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double TotalAmountar { get; set; }
        public double TotalBalancear { get; set; }
        public double TotalPrepayment { get; set; }
        public long? CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
