using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class PurchaseInvoicePurchaseInvoiceDetail
    {
        public long PurchaseInvoiceId { get; set; }
        public long PurchaseInvoiceDetailId { get; set; }

        public virtual PurchaseInvoice PurchaseInvoice { get; set; } = null!;
        public virtual PurchaseInvoiceDetail PurchaseInvoiceDetail { get; set; } = null!;
    }
}
