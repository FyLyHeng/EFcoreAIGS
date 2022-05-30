using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class AssetCategory
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Abbr { get; set; }
        public string? DepreMethod { get; set; }
        public string? Description { get; set; }
        public double? GlDepreRate { get; set; }
        public string? Name { get; set; }
        public long GlAccuDepreId { get; set; }
        public long GlCostId { get; set; }
        public long GlDepreExpId { get; set; }
        public long GlGainId { get; set; }
        public long GlLossId { get; set; }

        public virtual ChartOfAccount GlAccuDepre { get; set; } = null!;
        public virtual ChartOfAccount GlCost { get; set; } = null!;
        public virtual ChartOfAccount GlDepreExp { get; set; } = null!;
        public virtual ChartOfAccount GlGain { get; set; } = null!;
        public virtual ChartOfAccount GlLoss { get; set; } = null!;
    }
}
