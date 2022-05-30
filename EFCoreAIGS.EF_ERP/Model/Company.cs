using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Company
    {
        public Company()
        {
            Accounts = new HashSet<Account>();
            Employees = new HashSet<Employee>();
            Glentries = new HashSet<Glentry>();
            InverseParent = new HashSet<Company>();
            ItemWarehouses = new HashSet<ItemWarehouse>();
            SaleTaxCharges = new HashSet<SaleTaxCharge>();
            StockBalances = new HashSet<StockBalance>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public string? Abbr { get; set; }
        public string? Address { get; set; }
        public string? AddressKh { get; set; }
        public string? CompanyDesc { get; set; }
        public string? CompanyLogo { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyNameKh { get; set; }
        public DateTime? DateOfEstablishment { get; set; }
        public string? DeductStockSetting { get; set; }
        public string? Email { get; set; }
        public bool IsGroup { get; set; }
        public string? Phone { get; set; }
        public string? TaxId { get; set; }
        public string? VatIn { get; set; }
        public long? CountryId { get; set; }
        public long? CurrencyId { get; set; }
        public long? DomainId { get; set; }
        public long? FinanceBookId { get; set; }
        public long? LetterHeadId { get; set; }
        public long? ParentId { get; set; }
        public long? TermConditionId { get; set; }
        public long? WarehouseId { get; set; }

        public virtual Country? Country { get; set; }
        public virtual Currency? Currency { get; set; }
        public virtual Domain? Domain { get; set; }
        public virtual FinanceBook? FinanceBook { get; set; }
        public virtual LetterHead? LetterHead { get; set; }
        public virtual Company? Parent { get; set; }
        public virtual TermCondition? TermCondition { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Glentry> Glentries { get; set; }
        public virtual ICollection<Company> InverseParent { get; set; }
        public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; }
        public virtual ICollection<SaleTaxCharge> SaleTaxCharges { get; set; }
        public virtual ICollection<StockBalance> StockBalances { get; set; }
    }
}
