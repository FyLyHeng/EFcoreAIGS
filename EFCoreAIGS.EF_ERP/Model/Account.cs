﻿using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Account
    {
        public Account()
        {
            InverseParent = new HashSet<Account>();
            ItemTaxes = new HashSet<ItemTax>();
            SaleTaxDetails = new HashSet<SaleTaxDetail>();
            Warehouses = new HashSet<Warehouse>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? IsGroup { get; set; }
        public string? AccountName { get; set; }
        public float? Rate { get; set; }
        public long? AccountTypeId { get; set; }
        public long? BalanceId { get; set; }
        public long? CompanyId { get; set; }
        public long? CurrencyId { get; set; }
        public long? ParentId { get; set; }

        public virtual AccountType? AccountType { get; set; }
        public virtual Balance? Balance { get; set; }
        public virtual Company? Company { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Account? Parent { get; set; }
        public virtual ICollection<Account> InverseParent { get; set; }
        public virtual ICollection<ItemTax> ItemTaxes { get; set; }
        public virtual ICollection<SaleTaxDetail> SaleTaxDetails { get; set; }
        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
