using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Contact
    {
        public Contact()
        {
            PurchaseOrders = new HashSet<PurchaseOrder>();
            PurchaseReceipts = new HashSet<PurchaseReceipt>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MobileNo { get; set; }
        public string? Phone { get; set; }
        public string? ShippingAddress { get; set; }
        public string? SupplierAddress { get; set; }
        public long? GenderId { get; set; }
        public long? SalutationId { get; set; }

        public virtual Gender? Gender { get; set; }
        public virtual Salutation? Salutation { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<PurchaseReceipt> PurchaseReceipts { get; set; }
    }
}
