using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class CustomerPrePaymentReference
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public long? Soid { get; set; }
        public double? SooutstandingAmount { get; set; }
        public double? SoprepaymentAmount { get; set; }
        public string? Soseries { get; set; }
        public double? SototalAmount { get; set; }
        public double? Amount { get; set; }
        public string? CustomStatus { get; set; }
        public long? CustomerPrePaymentId { get; set; }
        public long? SaleOrderId { get; set; }

        public virtual CustomerPrePayment? CustomerPrePayment { get; set; }
        public virtual SaleOrder? SaleOrder { get; set; }
    }
}
