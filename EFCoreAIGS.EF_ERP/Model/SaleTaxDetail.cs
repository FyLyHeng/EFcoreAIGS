using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SaleTaxDetail
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public float? Amount { get; set; }
        public float? Rate { get; set; }
        public float? Total { get; set; }
        public long? AccountId { get; set; }
        public long? SaleTaxChargeId { get; set; }
        public long? SaleTaxTypeId { get; set; }

        public virtual Account? Account { get; set; }
        public virtual SaleTaxCharge? SaleTaxCharge { get; set; }
        public virtual SaleTaxType? SaleTaxType { get; set; }
    }
}
