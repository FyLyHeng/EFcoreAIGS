﻿using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class SaleReturnDetail
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public double? Amount { get; set; }
        public float? Discount { get; set; }
        public float? DiscountPercentage { get; set; }
        public float? Qty { get; set; }
        public double? Rate { get; set; }
        public long? ItemId { get; set; }
        public long? ItemVariantUomId { get; set; }
        public long? SaleReturnId { get; set; }

        public virtual Item? Item { get; set; }
        public virtual ItemVarrantUom? ItemVariantUom { get; set; }
        public virtual SaleReturn? SaleReturn { get; set; }
    }
}
