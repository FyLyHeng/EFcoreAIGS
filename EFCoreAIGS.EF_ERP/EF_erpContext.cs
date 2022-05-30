using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreAIGS.EF_ERP
{
    public partial class EF_erpContext : DbContext
    {
        public EF_erpContext()
        {
        }

        public EF_erpContext(DbContextOptions<EF_erpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AccountBill> AccountBills { get; set; } = null!;
        public virtual DbSet<AccountBillItem> AccountBillItems { get; set; } = null!;
        public virtual DbSet<AccountClass> AccountClasses { get; set; } = null!;
        public virtual DbSet<AccountMapping> AccountMappings { get; set; } = null!;
        public virtual DbSet<AccountSetupPayable> AccountSetupPayables { get; set; } = null!;
        public virtual DbSet<AccountSubClass> AccountSubClasses { get; set; } = null!;
        public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<AddressType> AddressTypes { get; set; } = null!;
        public virtual DbSet<AssetCategory> AssetCategories { get; set; } = null!;
        public virtual DbSet<Balance> Balances { get; set; } = null!;
        public virtual DbSet<BalanceSide> BalanceSides { get; set; } = null!;
        public virtual DbSet<BarcodeItem> BarcodeItems { get; set; } = null!;
        public virtual DbSet<BarcodeType> BarcodeTypes { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<ChartOfAccount> ChartOfAccounts { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<ClearBill> ClearBills { get; set; } = null!;
        public virtual DbSet<CoaBalance> CoaBalances { get; set; } = null!;
        public virtual DbSet<Commune> Communes { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<CreditNote> CreditNotes { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerBalance> CustomerBalances { get; set; } = null!;
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; } = null!;
        public virtual DbSet<CustomerPaymentEntry> CustomerPaymentEntries { get; set; } = null!;
        public virtual DbSet<CustomerPaymentEntryReference> CustomerPaymentEntryReferences { get; set; } = null!;
        public virtual DbSet<CustomerPrePayment> CustomerPrePayments { get; set; } = null!;
        public virtual DbSet<CustomerPrePaymentReference> CustomerPrePaymentReferences { get; set; } = null!;
        public virtual DbSet<DataSourceConfig> DataSourceConfigs { get; set; } = null!;
        public virtual DbSet<DebitNote> DebitNotes { get; set; } = null!;
        public virtual DbSet<DeliveryNote> DeliveryNotes { get; set; } = null!;
        public virtual DbSet<DeliveryNoteDetail> DeliveryNoteDetails { get; set; } = null!;
        public virtual DbSet<DeliveryType> DeliveryTypes { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<DocumentSetting> DocumentSettings { get; set; } = null!;
        public virtual DbSet<Domain> Domains { get; set; } = null!;
        public virtual DbSet<Driver> Drivers { get; set; } = null!;
        public virtual DbSet<DriverStatus> DriverStatuses { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; } = null!;
        public virtual DbSet<ExpanseCategory> ExpanseCategories { get; set; } = null!;
        public virtual DbSet<Feature> Features { get; set; } = null!;
        public virtual DbSet<FinanceBook> FinanceBooks { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Glentry> Glentries { get; set; } = null!;
        public virtual DbSet<GlobalSearch> GlobalSearches { get; set; } = null!;
        public virtual DbSet<HealthInsurance> HealthInsurances { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<ItemAttribute> ItemAttributes { get; set; } = null!;
        public virtual DbSet<ItemAttributeDetail> ItemAttributeDetails { get; set; } = null!;
        public virtual DbSet<ItemAttributeValue> ItemAttributeValues { get; set; } = null!;
        public virtual DbSet<ItemBrand> ItemBrands { get; set; } = null!;
        public virtual DbSet<ItemGroup> ItemGroups { get; set; } = null!;
        public virtual DbSet<ItemImage> ItemImages { get; set; } = null!;
        public virtual DbSet<ItemInventory> ItemInventories { get; set; } = null!;
        public virtual DbSet<ItemItem> ItemItems { get; set; } = null!;
        public virtual DbSet<ItemPrice> ItemPrices { get; set; } = null!;
        public virtual DbSet<ItemTax> ItemTaxes { get; set; } = null!;
        public virtual DbSet<ItemVarrantUom> ItemVarrantUoms { get; set; } = null!;
        public virtual DbSet<ItemWarehouse> ItemWarehouses { get; set; } = null!;
        public virtual DbSet<JournalEntry> JournalEntries { get; set; } = null!;
        public virtual DbSet<LetterHead> LetterHeads { get; set; } = null!;
        public virtual DbSet<MaterialRequestType> MaterialRequestTypes { get; set; } = null!;
        public virtual DbSet<MenuItem> MenuItems { get; set; } = null!;
        public virtual DbSet<Miscellaneou> Miscellaneous { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<Permission> Permissions { get; set; } = null!;
        public virtual DbSet<PriceList> PriceLists { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<PurchaseHoldInvoice> PurchaseHoldInvoices { get; set; } = null!;
        public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; } = null!;
        public virtual DbSet<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; } = null!;
        public virtual DbSet<PurchaseInvoicePurchaseInvoiceDetail> PurchaseInvoicePurchaseInvoiceDetails { get; set; } = null!;
        public virtual DbSet<PurchaseItem> PurchaseItems { get; set; } = null!;
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; } = null!;
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; } = null!;
        public virtual DbSet<PurchaseReceipt> PurchaseReceipts { get; set; } = null!;
        public virtual DbSet<PurchaseReceiptDetail> PurchaseReceiptDetails { get; set; } = null!;
        public virtual DbSet<PurchaseReceiptExpanse> PurchaseReceiptExpanses { get; set; } = null!;
        public virtual DbSet<PurchaseRefund> PurchaseRefunds { get; set; } = null!;
        public virtual DbSet<PurchaseReturn> PurchaseReturns { get; set; } = null!;
        public virtual DbSet<PurchaseReturnDetail> PurchaseReturnDetails { get; set; } = null!;
        public virtual DbSet<Quotation> Quotations { get; set; } = null!;
        public virtual DbSet<QuotationDetail> QuotationDetails { get; set; } = null!;
        public virtual DbSet<Refund> Refunds { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleMenu> RoleMenus { get; set; } = null!;
        public virtual DbSet<RolePermission> RolePermissions { get; set; } = null!;
        public virtual DbSet<SaleOrder> SaleOrders { get; set; } = null!;
        public virtual DbSet<SaleOrderDetail> SaleOrderDetails { get; set; } = null!;
        public virtual DbSet<SalePerson> SalePeople { get; set; } = null!;
        public virtual DbSet<SaleReturn> SaleReturns { get; set; } = null!;
        public virtual DbSet<SaleReturnDetail> SaleReturnDetails { get; set; } = null!;
        public virtual DbSet<SaleTaxCharge> SaleTaxCharges { get; set; } = null!;
        public virtual DbSet<SaleTaxDetail> SaleTaxDetails { get; set; } = null!;
        public virtual DbSet<SaleTaxType> SaleTaxTypes { get; set; } = null!;
        public virtual DbSet<Salutation> Salutations { get; set; } = null!;
        public virtual DbSet<SerialNo> SerialNos { get; set; } = null!;
        public virtual DbSet<StockBalance> StockBalances { get; set; } = null!;
        public virtual DbSet<StockLedgerEntry> StockLedgerEntries { get; set; } = null!;
        public virtual DbSet<StockMove> StockMoves { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<SupplierGroup> SupplierGroups { get; set; } = null!;
        public virtual DbSet<SupplierPayment> SupplierPayments { get; set; } = null!;
        public virtual DbSet<SupplierPaymentReference> SupplierPaymentReferences { get; set; } = null!;
        public virtual DbSet<SupplierType> SupplierTypes { get; set; } = null!;
        public virtual DbSet<TermCondition> TermConditions { get; set; } = null!;
        public virtual DbSet<Territory> Territories { get; set; } = null!;
        public virtual DbSet<TransactionJournal> TransactionJournals { get; set; } = null!;
        public virtual DbSet<TransactionType> TransactionTypes { get; set; } = null!;
        public virtual DbSet<Uom> Uoms { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<ValuationMethod> ValuationMethods { get; set; } = null!;
        public virtual DbSet<Village> Villages { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=P@ssw0rd;Database=erp");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .HasColumnName("account_name");

                entity.Property(e => e.AccountTypeId).HasColumnName("account_type_id");

                entity.Property(e => e.BalanceId).HasColumnName("balance_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.AccountType)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("fkgw84mgpacw9htdxcs2j1p7u6j");

                entity.HasOne(d => d.Balance)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.BalanceId)
                    .HasConstraintName("fk6qc52gy2x227bjs1exltnye4i");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("fkyx9qhair86pc6tnbh322xjg4");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fk316pn109iutn6yqoxrqp09cpc");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fkef5lfvm7tliuagpl8wibmrqd0");
            });

            modelBuilder.Entity<AccountBill>(entity =>
            {
                entity.ToTable("account_bill");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountBillId).HasColumnName("account_bill_id");

                entity.Property(e => e.BillDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("bill_date");

                entity.Property(e => e.BillRef)
                    .HasMaxLength(255)
                    .HasColumnName("bill_ref");

                entity.Property(e => e.BillStatus).HasColumnName("bill_status");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.ChartOfAccountId).HasColumnName("chart_of_account_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.DueDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("due_date");

                entity.Property(e => e.JournalEntryId).HasColumnName("journal_entry_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.TotalBillAmount).HasColumnName("total_bill_amount");

                entity.Property(e => e.TransactionTypeId).HasColumnName("transaction_type_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.AccountBillNavigation)
                    .WithMany(p => p.AccountBills)
                    .HasForeignKey(d => d.AccountBillId)
                    .HasConstraintName("fkhio30fgynlx7l0y2unnh32183");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AccountBills)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("fkrhj3j3h9htss5jb0sexiv62mx");

                entity.HasOne(d => d.ChartOfAccount)
                    .WithMany(p => p.AccountBills)
                    .HasForeignKey(d => d.ChartOfAccountId)
                    .HasConstraintName("fkscjv73cmmlbvws3syb0h2sy9i");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.AccountBills)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fkbc9eca5khrmslb057wogk0at6");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.AccountBills)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fkfr49i4ptk84ac9op8f1ib1vmy");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.AccountBills)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("fk934gx2tluclloegv07uscpwh4");
            });

            modelBuilder.Entity<AccountBillItem>(entity =>
            {
                entity.ToTable("account_bill_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountBillId).HasColumnName("account_bill_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ChartOfAccountId).HasColumnName("chart_of_account_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Ref)
                    .HasMaxLength(255)
                    .HasColumnName("ref");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.AccountBill)
                    .WithMany(p => p.AccountBillItems)
                    .HasForeignKey(d => d.AccountBillId)
                    .HasConstraintName("fkhs2gbpt46mm38pn4hnwups77p");

                entity.HasOne(d => d.ChartOfAccount)
                    .WithMany(p => p.AccountBillItems)
                    .HasForeignKey(d => d.ChartOfAccountId)
                    .HasConstraintName("fk5xs5s5pn9w08ocie851r34qj9");
            });

            modelBuilder.Entity<AccountClass>(entity =>
            {
                entity.ToTable("account_class");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BalanceSideId).HasColumnName("balance_side_id");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(255)
                    .HasColumnName("class_name");

                entity.HasOne(d => d.BalanceSide)
                    .WithMany(p => p.AccountClasses)
                    .HasForeignKey(d => d.BalanceSideId)
                    .HasConstraintName("fk5vw2hd45fnso4weofdq950s1l");
            });

            modelBuilder.Entity<AccountMapping>(entity =>
            {
                entity.ToTable("account_mapping");

                entity.HasIndex(e => e.Name, "uk_2xqbaypwpr0ho131uh6me1st9")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChartOfAccId).HasColumnName("chart_of_acc_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TrxnTypeId).HasColumnName("trxn_type_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.ChartOfAcc)
                    .WithMany(p => p.AccountMappings)
                    .HasForeignKey(d => d.ChartOfAccId)
                    .HasConstraintName("fkjv10nysl8rtcd011k6shm644p");

                entity.HasOne(d => d.TrxnType)
                    .WithMany(p => p.AccountMappings)
                    .HasForeignKey(d => d.TrxnTypeId)
                    .HasConstraintName("fkon5k51nce6l8bkuxdo1xmqrlm");
            });

            modelBuilder.Entity<AccountSetupPayable>(entity =>
            {
                entity.ToTable("account_setup_payable");
            
                entity.Property(e => e.Id).HasColumnName("id");
            
                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");
            
                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");
            
                entity.Property(e => e.GlAccountPayable)
                    .HasMaxLength(255)
                    .HasColumnName("gl_account_payable");
            
                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");
            
                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");
            
                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");
            
                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<AccountSubClass>(entity =>
            {
                entity.ToTable("account_sub_class");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountClassId).HasColumnName("account_class_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SubClassName)
                    .HasMaxLength(255)
                    .HasColumnName("sub_class_name");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.AccountSubClasses)
                    .HasForeignKey(d => d.AccountClassId)
                    .HasConstraintName("fk6fwg2pv06thu73nu3wam9s6qo");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.ToTable("account_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountType1)
                    .HasMaxLength(50)
                    .HasColumnName("account_type");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.AddressTypeId).HasColumnName("address_type_id");

                entity.Property(e => e.BillingAddressId).HasColumnName("billing_address_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CommuneId).HasColumnName("commune_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.HouseNo)
                    .HasMaxLength(255)
                    .HasColumnName("house_no");

                entity.Property(e => e.IsBillingAddress).HasColumnName("is_billing_address");

                entity.Property(e => e.IsDefaultBillingAdd).HasColumnName("is_default_billing_add");

                entity.Property(e => e.IsDefaultShippingAdd).HasColumnName("is_default_shipping_add");

                entity.Property(e => e.IsShippingAddress).HasColumnName("is_shipping_address");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .HasColumnName("postal_code");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.ShippingAddressId).HasColumnName("shipping_address_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StreetNo)
                    .HasMaxLength(255)
                    .HasColumnName("street_no");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.VillageId).HasColumnName("village_id");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressTypeId)
                    .HasConstraintName("fkkkjn52mg1vha4yjpm0douso7f");

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.AddressBillingAddresses)
                    .HasForeignKey(d => d.BillingAddressId)
                    .HasConstraintName("fkoithnn5ny5u7dvmxjpi3n2h25");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("fkpo044ng5x4gynb291cv24vtea");

                entity.HasOne(d => d.Commune)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CommuneId)
                    .HasConstraintName("fkrgjcv55f47qp01ul9ilqpp1jm");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("fke54x81nmccsk5569hsjg1a6ka");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk93c3js0e22ll1xlu21nvrhqgg");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("fkqbjwfi50pdenou8j14knnffrh");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("fkf8x0jfwoo94op8u88og1ohdcn");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.AddressShippingAddresses)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .HasConstraintName("fkefu76h3fpowk5ng2bdsdjh9hc");

                entity.HasOne(d => d.Village)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.VillageId)
                    .HasConstraintName("fkgufu9edl0iiai9gwjs84iwmgb");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.ToTable("address_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<AssetCategory>(entity =>
            {
                entity.ToTable("asset_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abbr)
                    .HasMaxLength(255)
                    .HasColumnName("abbr");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DepreMethod)
                    .HasMaxLength(255)
                    .HasColumnName("depre_method");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.GlAccuDepreId).HasColumnName("gl_accu_depre_id");

                entity.Property(e => e.GlCostId).HasColumnName("gl_cost_id");

                entity.Property(e => e.GlDepreExpId).HasColumnName("gl_depre_exp_id");

                entity.Property(e => e.GlDepreRate).HasColumnName("gl_depre_rate");

                entity.Property(e => e.GlGainId).HasColumnName("gl_gain_id");

                entity.Property(e => e.GlLossId).HasColumnName("gl_loss_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.GlAccuDepre)
                    .WithMany(p => p.AssetCategoryGlAccuDepres)
                    .HasForeignKey(d => d.GlAccuDepreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkitvmc8cb391xfpr5k76n55640");

                entity.HasOne(d => d.GlCost)
                    .WithMany(p => p.AssetCategoryGlCosts)
                    .HasForeignKey(d => d.GlCostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkgipci61w74vdt6mhvmpefsdh6");

                entity.HasOne(d => d.GlDepreExp)
                    .WithMany(p => p.AssetCategoryGlDepreExps)
                    .HasForeignKey(d => d.GlDepreExpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkt4wvplrq32ma9rplku5y2qleg");

                entity.HasOne(d => d.GlGain)
                    .WithMany(p => p.AssetCategoryGlGains)
                    .HasForeignKey(d => d.GlGainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkmu8qlkcx64ql2g9fsi84c79f3");

                entity.HasOne(d => d.GlLoss)
                    .WithMany(p => p.AssetCategoryGlLosses)
                    .HasForeignKey(d => d.GlLossId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk8bso12kxoyruf5d3e99kmcq4t");
            });

            modelBuilder.Entity<Balance>(entity =>
            {
                entity.ToTable("balance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BalanceName)
                    .HasMaxLength(50)
                    .HasColumnName("balance_name");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<BalanceSide>(entity =>
            {
                entity.ToTable("balance_side");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<BarcodeItem>(entity =>
            {
                entity.ToTable("barcode_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .HasColumnName("barcode");

                entity.Property(e => e.BarcodeTypeId).HasColumnName("barcode_type_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.BarcodeType)
                    .WithMany(p => p.BarcodeItems)
                    .HasForeignKey(d => d.BarcodeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkag1r3x54g4011fd73rsse0hp4");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.BarcodeItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkguxlr06grt0vq0kxe00w7q9v8");
            });

            modelBuilder.Entity<BarcodeType>(entity =>
            {
                entity.ToTable("barcode_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BarcodeTypeName)
                    .HasMaxLength(100)
                    .HasColumnName("barcode_type_name");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("branch");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abbr)
                    .HasMaxLength(255)
                    .HasColumnName("abbr");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(255)
                    .HasColumnName("branch_code");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(255)
                    .HasColumnName("branch_name");

                entity.Property(e => e.BranchNameKh)
                    .HasMaxLength(255)
                    .HasColumnName("branch_name_kh");

                entity.Property(e => e.CityProvince)
                    .HasMaxLength(255)
                    .HasColumnName("city_province");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<ChartOfAccount>(entity =>
            {
                entity.ToTable("chart_of_account");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountClassId).HasColumnName("account_class_id");

                entity.Property(e => e.AccountSubClassId).HasColumnName("account_sub_class_id");

                entity.Property(e => e.AllowNegative).HasColumnName("allow_negative");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(255)
                    .HasColumnName("gl_code");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.LeafAccount).HasColumnName("leaf_account");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.AccountClass)
                    .WithMany(p => p.ChartOfAccounts)
                    .HasForeignKey(d => d.AccountClassId)
                    .HasConstraintName("fkchnxkh169tc4p2mvgjwk6wem0");

                entity.HasOne(d => d.AccountSubClass)
                    .WithMany(p => p.ChartOfAccounts)
                    .HasForeignKey(d => d.AccountSubClassId)
                    .HasConstraintName("fkdq4k1slnqurdocfji02kjx9xl");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fki15llbslked3px8fhpu9wmeyv");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<ClearBill>(entity =>
            {
                entity.ToTable("clear_bill");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BillClearStatus)
                    .HasMaxLength(10)
                    .HasColumnName("bill_clear_status");

                entity.Property(e => e.BillRef)
                    .HasMaxLength(255)
                    .HasColumnName("bill_ref");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.ChartOfAccountId).HasColumnName("chart_of_account_id");

                entity.Property(e => e.Checks)
                    .HasMaxLength(255)
                    .HasColumnName("checks");

                entity.Property(e => e.ClearAmount).HasColumnName("clear_amount");

                entity.Property(e => e.ClearDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("clear_date");

                entity.Property(e => e.ClearRef)
                    .HasMaxLength(255)
                    .HasColumnName("clear_ref");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.JournalEntryId).HasColumnName("journal_entry_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PaymentMethodId).HasColumnName("payment_method_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TransactionTypeId).HasColumnName("transaction_type_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ClearBills)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("fkcxv7b1s6vpgn18fjkq1dr9k8c");

                entity.HasOne(d => d.ChartOfAccount)
                    .WithMany(p => p.ClearBills)
                    .HasForeignKey(d => d.ChartOfAccountId)
                    .HasConstraintName("fk8pj436wro0loy9unwj652sfup");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.ClearBills)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fkr68himos2hsvmxa3ijrfqo42c");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.ClearBills)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("fkd5yjowqgyt5mkwg2gq22qu1v");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.ClearBills)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("fk9t8ys3m5xd0c47r4jrim84jh0");
            });

            modelBuilder.Entity<CoaBalance>(entity =>
            {
                entity.ToTable("coa_balance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.ChartOfAccountId).HasColumnName("chart_of_account_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(255)
                    .HasColumnName("gl_code");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CoaBalances)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("fkjxfa7dai3h6b325lv6lhi18c2");

                entity.HasOne(d => d.ChartOfAccount)
                    .WithMany(p => p.CoaBalances)
                    .HasForeignKey(d => d.ChartOfAccountId)
                    .HasConstraintName("fkeloeomrdnfddh2ifk3c4lr8q7");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CoaBalances)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fkgptqjaslktx3wlrqupc5cbsri");
            });

            modelBuilder.Entity<Commune>(entity =>
            {
                entity.ToTable("commune");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Commid)
                    .HasMaxLength(255)
                    .HasColumnName("commid");

                entity.Property(e => e.Commune1)
                    .HasMaxLength(255)
                    .HasColumnName("commune");

                entity.Property(e => e.CommuneKh)
                    .HasMaxLength(255)
                    .HasColumnName("commune_kh");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DistrictCode)
                    .HasMaxLength(255)
                    .HasColumnName("district_code");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Communes)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkjhf1rxvyl4a736j0xjyuqywdr");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abbr)
                    .HasMaxLength(50)
                    .HasColumnName("abbr");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.AddressKh)
                    .HasMaxLength(255)
                    .HasColumnName("address_kh");

                entity.Property(e => e.CompanyDesc)
                    .HasMaxLength(255)
                    .HasColumnName("company_desc");

                entity.Property(e => e.CompanyLogo)
                    .HasMaxLength(255)
                    .HasColumnName("company_logo");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .HasColumnName("company_name");

                entity.Property(e => e.CompanyNameKh)
                    .HasMaxLength(255)
                    .HasColumnName("company_name_kh");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DateOfEstablishment)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_of_establishment");

                entity.Property(e => e.DeductStockSetting)
                    .HasMaxLength(255)
                    .HasColumnName("deduct_stock_setting");

                entity.Property(e => e.DomainId).HasColumnName("domain_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FinanceBookId).HasColumnName("finance_book_id");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.LetterHeadId).HasColumnName("letter_head_id");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(255)
                    .HasColumnName("tax_id");

                entity.Property(e => e.TermConditionId).HasColumnName("term_condition_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.VatIn)
                    .HasMaxLength(255)
                    .HasColumnName("vat_in");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("fkaa85rotlnir4w4xlj1nkilnws");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fk6ukoma5ydy94w070ewmn7udfy");

                entity.HasOne(d => d.Domain)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.DomainId)
                    .HasConstraintName("fkrxopcubjl5kvrx8fwf9vv9mom");

                entity.HasOne(d => d.FinanceBook)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.FinanceBookId)
                    .HasConstraintName("fkejx9exwuci0durwyeu04e3rw5");

                entity.HasOne(d => d.LetterHead)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.LetterHeadId)
                    .HasConstraintName("fkq0oaas2qxv289cnkadhq1b6y8");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fkgsxt4pb7gewmc5v44h53lu1bn");

                entity.HasOne(d => d.TermCondition)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.TermConditionId)
                    .HasConstraintName("fk44tv95tmlycg04ocoab73f8gy");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fkb6r1lhl3xmxagt26dpo5rta");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(20)
                    .HasColumnName("mobile_no");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.SalutationId).HasColumnName("salutation_id");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(255)
                    .HasColumnName("shipping_address");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierAddress)
                    .HasMaxLength(255)
                    .HasColumnName("supplier_address");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("fkgmv5ta5o5sa1hcsjgjkm8r3c6");

                entity.HasOne(d => d.Salutation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.SalutationId)
                    .HasConstraintName("fk2acklccxwjo1rgr6is2ih6ig6");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .HasColumnName("country_name");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<CreditNote>(entity =>
            {
                entity.ToTable("credit_note");

                entity.HasIndex(e => e.Series, "idx1i51elups6i8kk8ht3kgyr5cb");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CreditNoteAmount).HasColumnName("credit_note_amount");

                entity.Property(e => e.CustomStatus).HasColumnName("custom_status");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.InvoiceAmount).HasColumnName("invoice_amount");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.IsIncludeVat).HasColumnName("is_include_vat");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CreditNotes)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fkjnm35f89ygl7dry1owswglhqm");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.CreditNotes)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("fk89mv8mrynbjxoc6khjkbfibeb");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("currency");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.Currency1)
                    .HasMaxLength(255)
                    .HasColumnName("currency");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(255)
                    .HasColumnName("currency_code");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.IsUsed).HasColumnName("is_used");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.Contact)
                    .HasMaxLength(255)
                    .HasColumnName("contact");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CreditLength).HasColumnName("credit_length");

                entity.Property(e => e.CreditLimit).HasColumnName("credit_limit");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.CustomerType).HasColumnName("customer_type");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Disable).HasColumnName("disable");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.IdCard)
                    .HasMaxLength(100)
                    .HasColumnName("id_card");

                entity.Property(e => e.IsInternalCustomer).HasColumnName("is_internal_customer");

                entity.Property(e => e.IsPassCreditLimit).HasColumnName("is_pass_credit_limit");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.NameKh)
                    .HasMaxLength(100)
                    .HasColumnName("name_kh");

                entity.Property(e => e.PaymentTerm)
                    .HasMaxLength(255)
                    .HasColumnName("payment_term");

                entity.Property(e => e.PriceListId).HasColumnName("price_list_id");

                entity.Property(e => e.SalePersonId).HasColumnName("sale_person_id");

                entity.Property(e => e.SalutationId).HasColumnName("salutation_id");

                entity.Property(e => e.Series)
                    .HasMaxLength(100)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TaxId)
                    .HasMaxLength(255)
                    .HasColumnName("tax_id");

                entity.Property(e => e.TerritoryId).HasColumnName("territory_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.VatIn)
                    .HasMaxLength(255)
                    .HasColumnName("vat_in");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fk3fqcpx7dko5slv9s6m31cm4g1");

                entity.HasOne(d => d.CustomerGroup)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk9ogndo8hll7edx5iloyu2uegy");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("fk1lt23ie2trgs1r42hqyhliedv");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PriceListId)
                    .HasConstraintName("fkdy9yo0g543vri6m5ev1aj2d5");

                entity.HasOne(d => d.SalePerson)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.SalePersonId)
                    .HasConstraintName("fkhmrknj1oisejx0n7kqagqnesc");

                entity.HasOne(d => d.Salutation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.SalutationId)
                    .HasConstraintName("fknax78wl40ln4p5jm32scouq0w");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.TerritoryId)
                    .HasConstraintName("fkaamb70smwnslvwf80j4bc50c4");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fki95uujr0h5h486a8pbshc7vmw");
            });

            modelBuilder.Entity<CustomerBalance>(entity =>
            {
                entity.ToTable("customer_balance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TotalAmountar).HasColumnName("total_amountar");

                entity.Property(e => e.TotalBalancear).HasColumnName("total_balancear");

                entity.Property(e => e.TotalPrepayment).HasColumnName("total_prepayment");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerBalances)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fkf9n8fwyfughgs7taql4xunicf");
            });

            modelBuilder.Entity<CustomerGroup>(entity =>
            {
                entity.ToTable("customer_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CreditLimit).HasColumnName("credit_limit");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .HasColumnName("group_name");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.PriceListId).HasColumnName("price_list_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TermConditionId).HasColumnName("term_condition_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fkcpbibhc11a9caqc66e8vl4ka8");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.CustomerGroups)
                    .HasForeignKey(d => d.PriceListId)
                    .HasConstraintName("fk8s2k6mrko7c9ejj19f6ld47gd");

                entity.HasOne(d => d.TermCondition)
                    .WithMany(p => p.CustomerGroups)
                    .HasForeignKey(d => d.TermConditionId)
                    .HasConstraintName("fk2cwn4lsofnxxbj1b46lrlpwqx");
            });

            modelBuilder.Entity<CustomerPaymentEntry>(entity =>
            {
                entity.ToTable("customer_payment_entry");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GlAccountId).HasColumnName("gl_account_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PayBy)
                    .HasMaxLength(255)
                    .HasColumnName("pay_by");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("payment_date");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(255)
                    .HasColumnName("ref_no");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.TotalPrepayment).HasColumnName("total_prepayment");

                entity.Property(e => e.TotalReceive).HasColumnName("total_receive");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPaymentEntries)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk57sy5m9sf7dd7yaf3gf16atr2");

                entity.HasOne(d => d.GlAccount)
                    .WithMany(p => p.CustomerPaymentEntries)
                    .HasForeignKey(d => d.GlAccountId)
                    .HasConstraintName("fkh22nmln0o6nj96uc5xpevh79q");
            });

            modelBuilder.Entity<CustomerPaymentEntryReference>(entity =>
            {
                entity.ToTable("customer_payment_entry_reference");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountToReceive).HasColumnName("amount_to_receive");

                entity.Property(e => e.ApplyPrepayment).HasColumnName("apply_prepayment");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerPaymentEntryId).HasColumnName("customer_payment_entry_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Invamount).HasColumnName("invamount");

                entity.Property(e => e.Invid).HasColumnName("invid");

                entity.Property(e => e.Invoutstanding).HasColumnName("invoutstanding");

                entity.Property(e => e.Invseries)
                    .HasMaxLength(255)
                    .HasColumnName("invseries");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Soid).HasColumnName("soid");

                entity.Property(e => e.Soseries)
                    .HasMaxLength(255)
                    .HasColumnName("soseries");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.CustomerPaymentEntry)
                    .WithMany(p => p.CustomerPaymentEntryReferences)
                    .HasForeignKey(d => d.CustomerPaymentEntryId)
                    .HasConstraintName("fks7foprukq05ox9qs8iu7rvvo");
            });

            modelBuilder.Entity<CustomerPrePayment>(entity =>
            {
                entity.ToTable("customer_pre_payment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GlAccountId).HasColumnName("gl_account_id");

                entity.Property(e => e.IsByso).HasColumnName("is_byso");

                entity.Property(e => e.LastPrepaymentBalance).HasColumnName("last_prepayment_balance");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PayBy)
                    .HasMaxLength(255)
                    .HasColumnName("pay_by");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("payment_date");

                entity.Property(e => e.PaymentOption)
                    .HasMaxLength(255)
                    .HasColumnName("payment_option");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(255)
                    .HasColumnName("ref_no");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPrePayments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk5do5kmq9ptjkx0gfhh9925gtr");

                entity.HasOne(d => d.GlAccount)
                    .WithMany(p => p.CustomerPrePayments)
                    .HasForeignKey(d => d.GlAccountId)
                    .HasConstraintName("fk8e4mhvbv2tkwp6m8vhxexa8aj");
            });

            modelBuilder.Entity<CustomerPrePaymentReference>(entity =>
            {
                entity.ToTable("customer_pre_payment_reference");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerPrePaymentId).HasColumnName("customer_pre_payment_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.SaleOrderId).HasColumnName("sale_order_id");

                entity.Property(e => e.Soid).HasColumnName("soid");

                entity.Property(e => e.SooutstandingAmount).HasColumnName("sooutstanding_amount");

                entity.Property(e => e.SoprepaymentAmount).HasColumnName("soprepayment_amount");

                entity.Property(e => e.Soseries)
                    .HasMaxLength(255)
                    .HasColumnName("soseries");

                entity.Property(e => e.SototalAmount).HasColumnName("sototal_amount");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.CustomerPrePayment)
                    .WithMany(p => p.CustomerPrePaymentReferences)
                    .HasForeignKey(d => d.CustomerPrePaymentId)
                    .HasConstraintName("fk4a13ldm66l93qnhp6qktcwev5");

                entity.HasOne(d => d.SaleOrder)
                    .WithMany(p => p.CustomerPrePaymentReferences)
                    .HasForeignKey(d => d.SaleOrderId)
                    .HasConstraintName("fk3gy7lieq388f2f6tx7awlmima");
            });

            modelBuilder.Entity<DataSourceConfig>(entity =>
            {
                entity.ToTable("data_source_config");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.IsActive)
                    .HasColumnType("bit(1)")
                    .HasColumnName("is_active");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<DebitNote>(entity =>
            {
                entity.ToTable("debit_note");

                entity.HasIndex(e => e.Series, "idxl8yek74ethrix13a64pt5y7tt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");

                entity.Property(e => e.DiscountPercentage).HasColumnName("discount_percentage");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.IsIncludeVat).HasColumnName("is_include_vat");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PurchaseReturnId).HasColumnName("purchase_return_id");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SubTotal).HasColumnName("sub_total");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.VatAmount).HasColumnName("vat_amount");

                entity.Property(e => e.VatPercentage).HasColumnName("vat_percentage");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.PurchaseReturn)
                    .WithMany(p => p.DebitNotes)
                    .HasForeignKey(d => d.PurchaseReturnId)
                    .HasConstraintName("fkfugvyrn4myafsc8akbdqakt6r");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.DebitNotes)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fkqxg5f0dimqahtdr2oncw9c1t");
            });

            modelBuilder.Entity<DeliveryNote>(entity =>
            {
                entity.ToTable("delivery_note");

                entity.HasIndex(e => e.Series, "idxeu5ex12ndxk13mda3sq5dfe34");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalDisAmount).HasColumnName("additional_dis_amount");

                entity.Property(e => e.AdditionalDisPer).HasColumnName("additional_dis_per");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(1000)
                    .HasColumnName("billing_address");

                entity.Property(e => e.BillingAddressId).HasColumnName("billing_address_id");

                entity.Property(e => e.BillingTitle)
                    .HasMaxLength(255)
                    .HasColumnName("billing_title");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DateDone)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_done");

                entity.Property(e => e.DeliveryTypeId).HasColumnName("delivery_type_id");

                entity.Property(e => e.DriverId).HasColumnName("driver_id");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.ImmediateTransfer).HasColumnName("immediate_transfer");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.SaleOrderId).HasColumnName("sale_order_id");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(1000)
                    .HasColumnName("shipping_address");

                entity.Property(e => e.ShippingAddressId).HasColumnName("shipping_address_id");

                entity.Property(e => e.ShippingTitle)
                    .HasMaxLength(255)
                    .HasColumnName("shipping_title");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalQty).HasColumnName("total_qty");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.VatAmount).HasColumnName("vat_amount");

                entity.Property(e => e.VatPer).HasColumnName("vat_per");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseAddress)
                    .HasMaxLength(255)
                    .HasColumnName("warehouse_address");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DeliveryNotes)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fkseacucm0oxv4jc7r2gnyumn63");

                entity.HasOne(d => d.DeliveryType)
                    .WithMany(p => p.DeliveryNotes)
                    .HasForeignKey(d => d.DeliveryTypeId)
                    .HasConstraintName("fkaiucygc91ane0529jku2xmf1d");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.DeliveryNotes)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("fk17mxrj7yugeib8lnlqhc8cd9w");

                entity.HasOne(d => d.SaleOrder)
                    .WithMany(p => p.DeliveryNotes)
                    .HasForeignKey(d => d.SaleOrderId)
                    .HasConstraintName("fka23892al36fcn71e9bcok898e");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.DeliveryNotes)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fkkwdm71exscpr91q9nij9ldfnb");
            });

            modelBuilder.Entity<DeliveryNoteDetail>(entity =>
            {
                entity.ToTable("delivery_note_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ConversionFactor).HasColumnName("conversion_factor");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DeliveryNoteId).HasColumnName("delivery_note_id");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.HasSerialNo).HasColumnName("has_serial_no");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemVariantUomId).HasColumnName("item_variant_uom_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.SerialNo).HasColumnName("serial_no");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StockQty).HasColumnName("stock_qty");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.DeliveryNote)
                    .WithMany(p => p.DeliveryNoteDetails)
                    .HasForeignKey(d => d.DeliveryNoteId)
                    .HasConstraintName("fkblpd8dld5cwhkldgkadcmgmwf");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.DeliveryNoteDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk3i76varnkfb5q1dcslgrmw2ps");

                entity.HasOne(d => d.ItemVariantUom)
                    .WithMany(p => p.DeliveryNoteDetails)
                    .HasForeignKey(d => d.ItemVariantUomId)
                    .HasConstraintName("fk5yeex2kdj183yd3nx3sc2ayom");
            });

            modelBuilder.Entity<DeliveryType>(entity =>
            {
                entity.ToTable("delivery_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("district");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Distid)
                    .HasMaxLength(255)
                    .HasColumnName("distid");

                entity.Property(e => e.District1)
                    .HasMaxLength(255)
                    .HasColumnName("district");

                entity.Property(e => e.DistrictKh)
                    .HasMaxLength(255)
                    .HasColumnName("district_kh");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(255)
                    .HasColumnName("province_code");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk276utu38g5lgqeth6pwfm3rw2");
            });

            modelBuilder.Entity<DocumentSetting>(entity =>
            {
                entity.ToTable("document_setting");

                entity.HasIndex(e => e.Name, "idx8vql0es88p6virsa77nqnot1y");

                entity.HasIndex(e => e.NonVatPrefix, "uk_34ksnj6rogabks5ux36aexjfv")
                    .IsUnique();

                entity.HasIndex(e => e.Prefix, "uk_59vl05p8a1g8vknuiv7jobj8c")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "uk_8vql0es88p6virsa77nqnot1y")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.IsDifferentPrefix).HasColumnName("is_different_prefix");

                entity.Property(e => e.IsDifferentSequence).HasColumnName("is_different_sequence");

                entity.Property(e => e.LastCode).HasColumnName("last_code");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NonVatLastCode).HasColumnName("non_vat_last_code");

                entity.Property(e => e.NonVatPrefix)
                    .HasMaxLength(255)
                    .HasColumnName("non_vat_prefix");

                entity.Property(e => e.NonVatSuffix)
                    .HasMaxLength(255)
                    .HasColumnName("non_vat_suffix");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(255)
                    .HasColumnName("prefix");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Suffix)
                    .HasMaxLength(255)
                    .HasColumnName("suffix");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Domain>(entity =>
            {
                entity.ToTable("domain");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Domain1)
                    .HasMaxLength(255)
                    .HasColumnName("domain");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("drivers");

                entity.HasIndex(e => e.Series, "idxm51sy2i8dqhonkl6sixli37he");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CellphoneNumber)
                    .HasMaxLength(255)
                    .HasColumnName("cellphone_number");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(255)
                    .HasColumnName("driver_name");

                entity.Property(e => e.DriverStatusId).HasColumnName("driver_status_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expiry_date");

                entity.Property(e => e.IssuingDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("issuing_date");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.LicenseNumber)
                    .HasMaxLength(255)
                    .HasColumnName("license_number");

                entity.Property(e => e.Series)
                    .HasMaxLength(100)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.DriverStatus)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.DriverStatusId)
                    .HasConstraintName("fk90r4l5ytsw0lku0pyj5m9k1nc");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("fkq2af0erpwyy7ubrwn7hoo23t");
            });

            modelBuilder.Entity<DriverStatus>(entity =>
            {
                entity.ToTable("driver_status");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DataOfJoining)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("data_of_joining");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Dob)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("dob");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("employee_type_id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .HasColumnName("first_name");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.HealthInsuranceId).HasColumnName("health_insurance_id");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .HasColumnName("last_name");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(30)
                    .HasColumnName("middle_name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .HasColumnName("phone");

                entity.Property(e => e.SalutationId).HasColumnName("salutation_id");

                entity.Property(e => e.Series)
                    .HasMaxLength(20)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("fk5v50ed2bjh60n1gc7ifuxmgf4");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .HasConstraintName("fkks0jnjwhw9tjwa2b1l0klv1fb");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("fke0w26qjedr99vwno4pqauw9i9");

                entity.HasOne(d => d.HealthInsurance)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.HealthInsuranceId)
                    .HasConstraintName("fk4ndp9leoqaddrmvfl6w90oefe");

                entity.HasOne(d => d.Salutation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.SalutationId)
                    .HasConstraintName("fks2cicw7ryjpxendgeb5bxqhld");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("employee_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.EmployeeType1)
                    .HasMaxLength(255)
                    .HasColumnName("employee_type");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<ExpanseCategory>(entity =>
            {
                entity.ToTable("expanse_category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.ToTable("feature");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.FeatureName)
                    .HasMaxLength(100)
                    .HasColumnName("feature_name");

                entity.Property(e => e.FeatureOrder).HasColumnName("feature_order");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<FinanceBook>(entity =>
            {
                entity.ToTable("finance_book");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Gender1)
                    .HasMaxLength(255)
                    .HasColumnName("gender");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Glentry>(entity =>
            {
                entity.ToTable("glentry");

                entity.HasIndex(e => e.PostingDate, "idx1drhu9i7fqp05eg7bh43lndep");

                entity.HasIndex(e => e.VoucherNo, "idxpvlt0snlbaku13ra2tt5i256y");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChartOfAccId).HasColumnName("chart_of_acc_id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("posting_date");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(255)
                    .HasColumnName("voucher_no");

                entity.Property(e => e.VoucherType)
                    .HasMaxLength(255)
                    .HasColumnName("voucher_type");

                entity.HasOne(d => d.ChartOfAcc)
                    .WithMany(p => p.Glentries)
                    .HasForeignKey(d => d.ChartOfAccId)
                    .HasConstraintName("fkgaus8fntma0p3c8qbhut19hrq");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Glentries)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("fkrwsauigc92o8nmet06v3tdahx");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Glentries)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fkqyejgrlqjbvb5i6s9pcif0a1l");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Glentries)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fkddkiafnm6b7943wkm27ga05cp");
            });

            modelBuilder.Entity<GlobalSearch>(entity =>
            {
                entity.ToTable("global_search");

                entity.HasIndex(e => e.Title, "idxr8y2erlq5c9s7pkspmg3ebpdc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DocType)
                    .HasMaxLength(255)
                    .HasColumnName("doc_type");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Routing)
                    .HasMaxLength(255)
                    .HasColumnName("routing");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<HealthInsurance>(entity =>
            {
                entity.ToTable("health_insurance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.HealthInsuranceName)
                    .HasMaxLength(255)
                    .HasColumnName("health_insurance_name");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("holiday");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.HolidayDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("holiday_date");

                entity.Property(e => e.HolidayName)
                    .HasMaxLength(255)
                    .HasColumnName("holiday_name");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("invoice");

                entity.HasIndex(e => e.Series, "idxc3ftrohmw09g5yfr4liliy02v");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalDisAmount).HasColumnName("additional_dis_amount");

                entity.Property(e => e.AdditionalDisPer).HasColumnName("additional_dis_per");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DeliveryNoteId).HasColumnName("delivery_note_id");

                entity.Property(e => e.DueDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("due_date");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.InvoiceAmount).HasColumnName("invoice_amount");

                entity.Property(e => e.InvoicePer).HasColumnName("invoice_per");

                entity.Property(e => e.IsIncludeVat).HasColumnName("is_include_vat");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.SaleOrderId).HasColumnName("sale_order_id");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(255)
                    .HasColumnName("shipping_address");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalCost).HasColumnName("total_cost");

                entity.Property(e => e.TotalQty).HasColumnName("total_qty");

                entity.Property(e => e.UnpaidAmount).HasColumnName("unpaid_amount");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.VatAmount).HasColumnName("vat_amount");

                entity.Property(e => e.VatPer).HasColumnName("vat_per");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseAddress)
                    .HasMaxLength(255)
                    .HasColumnName("warehouse_address");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk5e32ukwo9uknwhylogvta4po6");

                entity.HasOne(d => d.DeliveryNote)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.DeliveryNoteId)
                    .HasConstraintName("fk6g33jwwe19ep5yl3p2cfpy40j");

                entity.HasOne(d => d.SaleOrder)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.SaleOrderId)
                    .HasConstraintName("fkt7avycfyg7220eq428hogylmw");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fk9ssjinbkdd04ccgtua4tjy5n9");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.ToTable("invoice_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ConversionFactor).HasColumnName("conversion_factor");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemVariantUomId).HasColumnName("item_variant_uom__id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.SaleInvoiceId).HasColumnName("sale_invoice_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk4kdkykjwo7h7hj6qgs8cxtf3b");

                entity.HasOne(d => d.ItemVariantUom)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.ItemVariantUomId)
                    .HasConstraintName("fkqdciiqn3rbn01conu2cpcpo3k");

                entity.HasOne(d => d.SaleInvoice)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.SaleInvoiceId)
                    .HasConstraintName("fk3kqpm1vs7me9627k0v69yrhxf");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("item");

                entity.HasIndex(e => e.ItemCode, "idx4xwxmd7c5scggdhewiue7fopp");

                entity.HasIndex(e => e.ItemName, "idxmqo9xeh2a6fvb17cqpmo1q72n");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(255)
                    .HasColumnName("barcode");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DeliveryFee).HasColumnName("delivery_fee");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndOfLife)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("end_of_life");

                entity.Property(e => e.HasBatchNo).HasColumnName("has_batch_no");

                entity.Property(e => e.HasSerialNo).HasColumnName("has_serial_no");

                entity.Property(e => e.IsDisable).HasColumnName("is_disable");

                entity.Property(e => e.IsFixAsset).HasColumnName("is_fix_asset");

                entity.Property(e => e.IsMaintainStock).HasColumnName("is_maintain_stock");

                entity.Property(e => e.IsSaleItem).HasColumnName("is_sale_item");

                entity.Property(e => e.IsUsed).HasColumnName("is_used");

                entity.Property(e => e.ItemBrandId).HasColumnName("item_brand_id");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(255)
                    .HasColumnName("item_code");

                entity.Property(e => e.ItemGroupId).HasColumnName("item_group_id");

                entity.Property(e => e.ItemImageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("item_image_url");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasColumnName("item_name");

                entity.Property(e => e.LastPurchaseRate).HasColumnName("last_purchase_rate");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.ManufacturePartNumber).HasColumnName("manufacture_part_number");

                entity.Property(e => e.MaxDiscount).HasColumnName("max_discount");

                entity.Property(e => e.OpeningStock).HasColumnName("opening_stock");

                entity.Property(e => e.SaleUnitOfMeasure).HasColumnName("sale_unit_of_measure");

                entity.Property(e => e.SelfLifeInDay).HasColumnName("self_life_in_day");

                entity.Property(e => e.StandardBuyingRate).HasColumnName("standard_buying_rate");

                entity.Property(e => e.StandardSellingRate).HasColumnName("standard_selling_rate");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UomId).HasColumnName("uom_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.ValuationMethodId).HasColumnName("valuation_method_id");

                entity.Property(e => e.ValuationRate).HasColumnName("valuation_rate");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarrantyPeriod).HasColumnName("warranty_period");

                entity.Property(e => e.WeightPerUnit).HasColumnName("weight_per_unit");

                entity.Property(e => e.WeightUom)
                    .HasMaxLength(255)
                    .HasColumnName("weight_uom");

                entity.Property(e => e.WeightUomId).HasColumnName("weight_uom_id");

                entity.HasOne(d => d.ItemBrand)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemBrandId)
                    .HasConstraintName("fkk5mprfnrchdrqapx2sjpydncx");

                entity.HasOne(d => d.ItemGroup)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("fkr4fbv7293k0b5v1qjk5lm6md");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.UomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk5aoeq4pcgvoaqjlyhbokvkg8v");

                entity.HasOne(d => d.ValuationMethod)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ValuationMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkryv8p97mmc5q7dcbupht6w480");
            });

            modelBuilder.Entity<ItemAttribute>(entity =>
            {
                entity.ToTable("item_attribute");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(255)
                    .HasColumnName("attribute_name");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<ItemAttributeDetail>(entity =>
            {
                entity.ToTable("item_attribute_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(100)
                    .HasColumnName("abbreviation");

                entity.Property(e => e.AttributeValue)
                    .HasMaxLength(100)
                    .HasColumnName("attribute_value");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ItemAttributeId).HasColumnName("item_attribute_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.ItemAttribute)
                    .WithMany(p => p.ItemAttributeDetails)
                    .HasForeignKey(d => d.ItemAttributeId)
                    .HasConstraintName("fkceojhsp72n0ex7mpjx0k6074");
            });

            modelBuilder.Entity<ItemAttributeValue>(entity =>
            {
                entity.ToTable("item_attribute_value");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ItemAttributeDetailId).HasColumnName("item_attribute_detail_id");

                entity.Property(e => e.ItemAttributeId).HasColumnName("item_attribute_id");

                entity.Property(e => e.ItemItemId).HasColumnName("item_item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.ItemAttributeDetail)
                    .WithMany(p => p.ItemAttributeValues)
                    .HasForeignKey(d => d.ItemAttributeDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkt9b6s94x0po7n5elu68pt02il");

                entity.HasOne(d => d.ItemAttribute)
                    .WithMany(p => p.ItemAttributeValues)
                    .HasForeignKey(d => d.ItemAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkc3m663h01tr58i97ageb3q1b2");

                entity.HasOne(d => d.ItemItem)
                    .WithMany(p => p.ItemAttributeValues)
                    .HasForeignKey(d => d.ItemItemId)
                    .HasConstraintName("fkp1k0ionspjil7j8ba6xti00op");
            });

            modelBuilder.Entity<ItemBrand>(entity =>
            {
                entity.ToTable("item_brand");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .HasColumnName("brand_name");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.ToTable("item_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(30)
                    .HasColumnName("group_name");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fkh0gygywjj17k1o53qhp4xf30r");
            });

            modelBuilder.Entity<ItemImage>(entity =>
            {
                entity.ToTable("item_image");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemImageName)
                    .HasMaxLength(255)
                    .HasColumnName("item_image_name");

                entity.Property(e => e.ItemImagePath)
                    .HasMaxLength(255)
                    .HasColumnName("item_image_path");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemImages)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkta6kqet3u8mv95y7jwtgwqpys");
            });

            modelBuilder.Entity<ItemInventory>(entity =>
            {
                entity.ToTable("item_inventory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.EndOfLife)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("end_of_life");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.MaterialRequestTypeId).HasColumnName("material_request_type_id");

                entity.Property(e => e.SelfLifeInDay).HasColumnName("self_life_in_day");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UomId).HasColumnName("uom_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.ValuationMethodId).HasColumnName("valuation_method_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarrantyPeriod).HasColumnName("warranty_period");

                entity.Property(e => e.WeightPerUnit).HasColumnName("weight_per_unit");

                entity.Property(e => e.WeightUom)
                    .HasMaxLength(255)
                    .HasColumnName("weight_uom");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemInventories)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkis34mg9pc892kd0968g1rb9pt");

                entity.HasOne(d => d.MaterialRequestType)
                    .WithMany(p => p.ItemInventories)
                    .HasForeignKey(d => d.MaterialRequestTypeId)
                    .HasConstraintName("fkj76kdqef8gk747i5cfbedl6ws");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.ItemInventories)
                    .HasForeignKey(d => d.UomId)
                    .HasConstraintName("fk6oelp1ry3gkt32xvtqexgxuvp");

                entity.HasOne(d => d.ValuationMethod)
                    .WithMany(p => p.ItemInventories)
                    .HasForeignKey(d => d.ValuationMethodId)
                    .HasConstraintName("fkdiceow5ur2ts2ltn134gx1wmu");
            });

            modelBuilder.Entity<ItemItem>(entity =>
            {
                entity.ToTable("item_items");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(255)
                    .HasColumnName("barcode");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ExtraCost).HasColumnName("extra_cost");

                entity.Property(e => e.ExtraPrice).HasColumnName("extra_price");

                entity.Property(e => e.ExtraPriceList).HasColumnName("extra_price_list");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemQtyForecast).HasColumnName("item_qty_forecast");

                entity.Property(e => e.ItemQtyOnHand).HasColumnName("item_qty_on_hand");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkff1l0bmjpu0195wgbbvxpuxl1");
            });

            modelBuilder.Entity<ItemPrice>(entity =>
            {
                entity.ToTable("item_price");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.IsBuying).HasColumnName("is_buying");

                entity.Property(e => e.IsSelling).HasColumnName("is_selling");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.MinimumQty).HasColumnName("minimum_qty");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note");

                entity.Property(e => e.PriceListId).HasColumnName("price_list_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.StandardBuying).HasColumnName("standard_buying");

                entity.Property(e => e.StandardSelling).HasColumnName("standard_selling");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.ItemPrices)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fk4p9i8tsrcavtdhnwekx7pghxn");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemPrices)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fke6ivp7ms01x65oq2amsv5hrl0");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.ItemPrices)
                    .HasForeignKey(d => d.PriceListId)
                    .HasConstraintName("fkj0rvvgppk8fl8iqyoaw2kgwcr");
            });

            modelBuilder.Entity<ItemTax>(entity =>
            {
                entity.ToTable("item_tax");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TaxRate).HasColumnName("tax_rate");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ItemTaxes)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkpcr0c4d5h8jy2wmulevnlfcj5");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemTaxes)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fksj5f0qcjcyy39lcqhrxw7ovd0");
            });

            modelBuilder.Entity<ItemVarrantUom>(entity =>
            {
                entity.ToTable("item_varrant_uom");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConversionFactor).HasColumnName("conversion_factor");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UomId).HasColumnName("uom_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemVarrantUoms)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkhkhuhqacy55nhm70lfwv12x95");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.ItemVarrantUoms)
                    .HasForeignKey(d => d.UomId)
                    .HasConstraintName("fkji7fvit04ksijrmfcdnln04hw");
            });

            modelBuilder.Entity<ItemWarehouse>(entity =>
            {
                entity.ToTable("item_warehouse");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PriceListId).HasColumnName("price_list_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ItemWarehouses)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkbytqw7u56ln8ib2g0wymfrwa0");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemWarehouses)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk68qrrw32tlahocw3luuxmo9lt");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.ItemWarehouses)
                    .HasForeignKey(d => d.PriceListId)
                    .HasConstraintName("fkc4ouc0dxe9v9c157njyn4782u");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ItemWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fktb7uwg7judhe1j4kcw9hpgqcd");
            });

            modelBuilder.Entity<JournalEntry>(entity =>
            {
                entity.ToTable("journal_entry");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adjusting).HasColumnName("adjusting");

                entity.Property(e => e.BStatus).HasColumnName("b_status");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CanReverse).HasColumnName("can_reverse");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.EntryNo)
                    .HasMaxLength(255)
                    .HasColumnName("entry_no");

                entity.Property(e => e.JournalDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("journal_date");

                entity.Property(e => e.JournalType).HasColumnName("journal_type");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TotalCredit).HasColumnName("total_credit");

                entity.Property(e => e.TotalDebit).HasColumnName("total_debit");

                entity.Property(e => e.TrxnTypeId).HasColumnName("trxn_type_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("fkbnb3pu15kojh5fnvt4sg1h6xs");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fk9vvudw1ifwc61ur2wq6sg8kso");

                entity.HasOne(d => d.TrxnType)
                    .WithMany(p => p.JournalEntries)
                    .HasForeignKey(d => d.TrxnTypeId)
                    .HasConstraintName("fkcfyxo2h09ja6mfhua00pxu47i");
            });

            modelBuilder.Entity<LetterHead>(entity =>
            {
                entity.ToTable("letter_head");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.LetterHeadName)
                    .HasMaxLength(255)
                    .HasColumnName("letter_head_name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<MaterialRequestType>(entity =>
            {
                entity.ToTable("material_request_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(255)
                    .HasColumnName("type_name");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.ToTable("menu_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Closable).HasColumnName("closable");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ExternalLink)
                    .HasMaxLength(50)
                    .HasColumnName("external_link");

                entity.Property(e => e.IconBg)
                    .HasMaxLength(50)
                    .HasColumnName("icon_bg");

                entity.Property(e => e.IconClass)
                    .HasMaxLength(50)
                    .HasColumnName("icon_class");

                entity.Property(e => e.IconColor)
                    .HasMaxLength(50)
                    .HasColumnName("icon_color");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.IsDisable).HasColumnName("is_disable");

                entity.Property(e => e.IsGroupTitle).HasColumnName("is_group_title");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.MenuOrder).HasColumnName("menu_order");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Routing)
                    .HasMaxLength(50)
                    .HasColumnName("routing");

                entity.Property(e => e.Selected).HasColumnName("selected");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Miscellaneou>(entity =>
            {
                entity.ToTable("miscellaneous");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("payment_method");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Method)
                    .HasMaxLength(255)
                    .HasColumnName("method");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("permission");

                entity.HasIndex(e => e.FeatureId, "uk_m63q3sk9p3gt4wteto2ckc5sg")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.FeatureId).HasColumnName("feature_id");

                entity.Property(e => e.FunctionName)
                    .HasMaxLength(100)
                    .HasColumnName("function_name");

                entity.Property(e => e.FunctionOrder).HasColumnName("function_order");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Feature)
                    .WithOne(p => p.Permission)
                    .HasForeignKey<Permission>(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkjgkobdkd3ujnxlvrtpf19x68j");
            });

            modelBuilder.Entity<PriceList>(entity =>
            {
                entity.ToTable("price_list");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Enable).HasColumnName("enable");

                entity.Property(e => e.IsBuying).HasColumnName("is_buying");

                entity.Property(e => e.IsSelling).HasColumnName("is_selling");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PriceListName)
                    .HasMaxLength(255)
                    .HasColumnName("price_list_name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PriceLists)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fkc06v5ro9p64ywvhc589nhaygn");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("province");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Provid)
                    .HasMaxLength(255)
                    .HasColumnName("provid");

                entity.Property(e => e.Province1)
                    .HasMaxLength(255)
                    .HasColumnName("province");

                entity.Property(e => e.ProvinceKh)
                    .HasMaxLength(255)
                    .HasColumnName("province_kh");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<PurchaseHoldInvoice>(entity =>
            {
                entity.ToTable("purchase_hold_invoice");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("release_date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<PurchaseInvoice>(entity =>
            {
                entity.ToTable("purchase_invoice");

                entity.HasIndex(e => e.Series, "idx7wn0qc6932b6uhmf1ke9iw635");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DateDone)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_done");

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.IsPaid).HasColumnName("is_paid");

                entity.Property(e => e.IsRawMaterial).HasColumnName("is_raw_material");

                entity.Property(e => e.IsReturn).HasColumnName("is_return");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Noted).HasColumnName("noted");

                entity.Property(e => e.OutstandingAmount).HasColumnName("outstanding_amount");

                entity.Property(e => e.PrepaidAmount).HasColumnName("prepaid_amount");

                entity.Property(e => e.PrepaymentAmount).HasColumnName("prepayment_amount");

                entity.Property(e => e.PurchaseOrderDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("purchase_order_date");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("purchase_order_id");

                entity.Property(e => e.PurchaseOrderSeries)
                    .HasMaxLength(255)
                    .HasColumnName("purchase_order_series");

                entity.Property(e => e.PurchaseReceiptId).HasColumnName("purchase_receipt_id");

                entity.Property(e => e.PurchaseReceiptSeries)
                    .HasMaxLength(255)
                    .HasColumnName("purchase_receipt_series");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierAddress)
                    .HasMaxLength(255)
                    .HasColumnName("supplier_address");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(255)
                    .HasColumnName("supplier_name");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.TotalQty).HasColumnName("total_qty");

                entity.Property(e => e.TotalWeight).HasColumnName("total_weight");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fknq1hm13475eygvfhocnu7gubi");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("fkqv5xl4xgrxpd7fk8kjhlj3wo0");

                entity.HasOne(d => d.PurchaseReceipt)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.PurchaseReceiptId)
                    .HasConstraintName("fkcakafkke1058qmmjpqlpvrajn");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fkqtx4kjstn77n9v4wowt0mlxkx");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PurchaseInvoices)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fktmqydvbl95w50omj8h8fe3xge");
            });

            modelBuilder.Entity<PurchaseInvoiceDetail>(entity =>
            {
                entity.ToTable("purchase_invoice_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualQty).HasColumnName("actual_qty");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ConversionFactor).HasColumnName("conversion_factor");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemVariantUomId).HasColumnName("item_variant_uom__id");

                entity.Property(e => e.LastPurchaseRate).HasColumnName("last_purchase_rate");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PurchaseInvoiceId).HasColumnName("purchase_invoice_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.ReceivedQty).HasColumnName("received_qty");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StockQty).HasColumnName("stock_qty");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WeightUom).HasColumnName("weight_uom");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PurchaseInvoiceDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk4yll33q6jlrhfi6fykxer4qrv");

                entity.HasOne(d => d.ItemVariantUom)
                    .WithMany(p => p.PurchaseInvoiceDetails)
                    .HasForeignKey(d => d.ItemVariantUomId)
                    .HasConstraintName("fknutdjywmxf8dtyfjfm5fd9bbq");

                entity.HasOne(d => d.PurchaseInvoice)
                    .WithMany(p => p.PurchaseInvoiceDetails)
                    .HasForeignKey(d => d.PurchaseInvoiceId)
                    .HasConstraintName("fkdc7bo3dg79p1cmcr0vwf3kxsy");
            });

            modelBuilder.Entity<PurchaseInvoicePurchaseInvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("purchase_invoice_purchase_invoice_detail");

                entity.HasIndex(e => e.PurchaseInvoiceDetailId, "uk_523pbs526qoeltrrbiqqmm2m3")
                    .IsUnique();

                entity.Property(e => e.PurchaseInvoiceDetailId).HasColumnName("purchase_invoice_detail_id");

                entity.Property(e => e.PurchaseInvoiceId).HasColumnName("purchase_invoice_id");

                entity.HasOne(d => d.PurchaseInvoiceDetail)
                    .WithOne()
                    .HasForeignKey<PurchaseInvoicePurchaseInvoiceDetail>(d => d.PurchaseInvoiceDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkama1ihgl41btxcmihmo9to459");

                entity.HasOne(d => d.PurchaseInvoice)
                    .WithMany()
                    .HasForeignKey(d => d.PurchaseInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkrbcchir06n1vkv4shy0ep16bj");
            });

            modelBuilder.Entity<PurchaseItem>(entity =>
            {
                entity.ToTable("purchase_item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.IsPurchaseItem).HasColumnName("is_purchase_item");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.LeadTimeInDay).HasColumnName("lead_time_in_day");

                entity.Property(e => e.MinimumOrderQty).HasColumnName("minimum_order_qty");

                entity.Property(e => e.SafetyStock).HasColumnName("safety_stock");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UomId).HasColumnName("uom_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PurchaseItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk4voj5rjjn6ofwsp9qk70w2tga");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.PurchaseItems)
                    .HasForeignKey(d => d.UomId)
                    .HasConstraintName("fk9cikvj5nf90g3t18gkt7r7jju");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.ToTable("purchase_order");

                entity.HasIndex(e => e.Series, "idx5ny4s4qvd5lg0q2fydgxcv6ow");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.OutstandingAmount).HasColumnName("outstanding_amount");

                entity.Property(e => e.PrePaidAmount).HasColumnName("pre_paid_amount");

                entity.Property(e => e.PriceListId).HasColumnName("price_list_id");

                entity.Property(e => e.RequiredDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("required_date");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.TotalCharge).HasColumnName("total_charge");

                entity.Property(e => e.TotalPrepayment).HasColumnName("total_prepayment");

                entity.Property(e => e.TotalQty).HasColumnName("total_qty");

                entity.Property(e => e.TotalWeight).HasColumnName("total_weight");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("fkkqescxsvxsm2o454b36rlmdax");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fkijpaw9ak0pnsorfdl9dej85kx");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.PriceListId)
                    .HasConstraintName("fkil76wgv3woyccv917kxd0yakh");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fk4traogu3jriq9u7e8rvm86k7i");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fkfn0kri8xb0mi8bkb2swlnv581");
            });

            modelBuilder.Entity<PurchaseOrderDetail>(entity =>
            {
                entity.ToTable("purchase_order_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualQty).HasColumnName("actual_qty");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ConversionFactor).HasColumnName("conversion_factor");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemVariantUomId).HasColumnName("item_variant_uom__id");

                entity.Property(e => e.LastPurchaseRate).HasColumnName("last_purchase_rate");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("purchase_order_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.ReceivedQty).HasColumnName("received_qty");

                entity.Property(e => e.RequiredDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("required_date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StockQty).HasColumnName("stock_qty");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WeightUom).HasColumnName("weight_uom");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PurchaseOrderDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkkl3w9bo79qh9eat9qyxkvvchs");

                entity.HasOne(d => d.ItemVariantUom)
                    .WithMany(p => p.PurchaseOrderDetails)
                    .HasForeignKey(d => d.ItemVariantUomId)
                    .HasConstraintName("fkmwllceinbhnwsao7ggvu95ju");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderDetails)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("fki6xlnsg9o9ght6xcwl51ooa4k");
            });

            modelBuilder.Entity<PurchaseReceipt>(entity =>
            {
                entity.ToTable("purchase_receipt");

                entity.HasIndex(e => e.Series, "idx23c88ptlr39apyxyx6p6w4u6m");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactId).HasColumnName("contact_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DateDone)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_done");

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.IsReturn).HasColumnName("is_return");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Noted).HasColumnName("noted");

                entity.Property(e => e.PriceListId).HasColumnName("price_list_id");

                entity.Property(e => e.ProrateBy)
                    .HasMaxLength(255)
                    .HasColumnName("prorate_by");

                entity.Property(e => e.ProrateById).HasColumnName("prorate_by_id");

                entity.Property(e => e.PurchaseOrderDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("purchase_order_date");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("purchase_order_id");

                entity.Property(e => e.PurchaseOrderSeries)
                    .HasMaxLength(255)
                    .HasColumnName("purchase_order_series");

                entity.Property(e => e.RawMaterial).HasColumnName("raw_material");

                entity.Property(e => e.RequiredDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("required_date");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(255)
                    .HasColumnName("shipping_address");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierAddress)
                    .HasMaxLength(255)
                    .HasColumnName("supplier_address");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.TotalAdditionalAmount).HasColumnName("total_additional_amount");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.Property(e => e.TotalCharge).HasColumnName("total_charge");

                entity.Property(e => e.TotalQty).HasColumnName("total_qty");

                entity.Property(e => e.TotalWeight).HasColumnName("total_weight");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.PurchaseReceipts)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("fk2c6a1tn7eyhgxc5wxfy1s3co5");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.PurchaseReceipts)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fkay0iqp4vpc99mulfa52pecte8");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.PurchaseReceipts)
                    .HasForeignKey(d => d.PriceListId)
                    .HasConstraintName("fknljtk7avkhubpn0rhctnbu971");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseReceipts)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("fkfmwniv5hy3skbyhslnff7o0bj");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseReceipts)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fk1i0giyt54cl1nege2tj2f3nlu");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PurchaseReceipts)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fkp6wbcrpolpl8r94tupe2doi70");
            });

            modelBuilder.Entity<PurchaseReceiptDetail>(entity =>
            {
                entity.ToTable("purchase_receipt_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualQty).HasColumnName("actual_qty");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BatchNo).HasColumnName("batch_no");

                entity.Property(e => e.ConversionFactor).HasColumnName("conversion_factor");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemVariantUomId).HasColumnName("item_variant_uom__id");

                entity.Property(e => e.LastPurchaseRate).HasColumnName("last_purchase_rate");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PurchaseReceiptId).HasColumnName("purchase_receipt_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.ReceivedQty).HasColumnName("received_qty");

                entity.Property(e => e.SerialNo).HasColumnName("serial_no");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StockQty).HasColumnName("stock_qty");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.Property(e => e.WeightUom)
                    .HasMaxLength(255)
                    .HasColumnName("weight_uom");

                entity.Property(e => e.WeightUomId).HasColumnName("weight_uom_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PurchaseReceiptDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkutom30tugx82jmgrw8d953q0");

                entity.HasOne(d => d.ItemVariantUom)
                    .WithMany(p => p.PurchaseReceiptDetails)
                    .HasForeignKey(d => d.ItemVariantUomId)
                    .HasConstraintName("fk61w97fs23xjv2jnhtwsjsuj4t");

                entity.HasOne(d => d.PurchaseReceipt)
                    .WithMany(p => p.PurchaseReceiptDetails)
                    .HasForeignKey(d => d.PurchaseReceiptId)
                    .HasConstraintName("fk94l1gahvt7cxj9ydlakm1dh83");
            });

            modelBuilder.Entity<PurchaseReceiptExpanse>(entity =>
            {
                entity.ToTable("purchase_receipt_expanse");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ExpanseCategoryId).HasColumnName("expanse_category_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PurchaseReceiptId).HasColumnName("purchase_receipt_id");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.ExpanseCategory)
                    .WithMany(p => p.PurchaseReceiptExpanses)
                    .HasForeignKey(d => d.ExpanseCategoryId)
                    .HasConstraintName("fkh0gj7cyw3k5s97i7gqouunkbo");

                entity.HasOne(d => d.PurchaseReceipt)
                    .WithMany(p => p.PurchaseReceiptExpanses)
                    .HasForeignKey(d => d.PurchaseReceiptId)
                    .HasConstraintName("fkikgyhuxjxb5h9jpifv3inoipa");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseReceiptExpanses)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fk7g5xfebu7c91mmkmhpgst18ml");
            });

            modelBuilder.Entity<PurchaseRefund>(entity =>
            {
                entity.ToTable("purchase_refund");

                entity.HasIndex(e => e.Series, "idxfabjy9hw2uq2hsh64icyg45dp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DebitNoteAmount).HasColumnName("debit_note_amount");

                entity.Property(e => e.DebitNoteId).HasColumnName("debit_note_id");

                entity.Property(e => e.GlAccountId).HasColumnName("gl_account_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PaymentOption)
                    .HasMaxLength(255)
                    .HasColumnName("payment_option");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(255)
                    .HasColumnName("reference_no");

                entity.Property(e => e.RefundAmount).HasColumnName("refund_amount");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.DebitNote)
                    .WithMany(p => p.PurchaseRefunds)
                    .HasForeignKey(d => d.DebitNoteId)
                    .HasConstraintName("fkkckiis3148kh5byh03ox71ckp");

                entity.HasOne(d => d.GlAccount)
                    .WithMany(p => p.PurchaseRefunds)
                    .HasForeignKey(d => d.GlAccountId)
                    .HasConstraintName("fkb5qwcr5so9wu5ht0sll55gvj2");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseRefunds)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fkqfd8ae7ltgilf1p828iln5170");
            });

            modelBuilder.Entity<PurchaseReturn>(entity =>
            {
                entity.ToTable("purchase_return");

                entity.HasIndex(e => e.Series, "idxgfj7vg4hkcyfrnhkk8reeei7p");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SubTotal).HasColumnName("sub_total");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.VatAmount).HasColumnName("vat_amount");

                entity.Property(e => e.VatPercent).HasColumnName("vat_percent");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseReturns)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fk9w5jqdyl12gvwaxagisj6u3gk");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PurchaseReturns)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fkt2k98i6ounmgnvoexk2rlpugp");
            });

            modelBuilder.Entity<PurchaseReturnDetail>(entity =>
            {
                entity.ToTable("purchase_return_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemVariantUomId).HasColumnName("item_variant_uom_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PurchaseReturnId).HasColumnName("purchase_return_id");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PurchaseReturnDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkios10qt5oav8wfckvrk4b9qn1");

                entity.HasOne(d => d.ItemVariantUom)
                    .WithMany(p => p.PurchaseReturnDetails)
                    .HasForeignKey(d => d.ItemVariantUomId)
                    .HasConstraintName("fkpqo3sxgfygnr4ptgo1qp0xdpf");

                entity.HasOne(d => d.PurchaseReturn)
                    .WithMany(p => p.PurchaseReturnDetails)
                    .HasForeignKey(d => d.PurchaseReturnId)
                    .HasConstraintName("fkey1pgajbkxxdumqifvfpu3x55");
            });

            modelBuilder.Entity<Quotation>(entity =>
            {
                entity.ToTable("quotation");

                entity.HasIndex(e => e.Series, "idxg7n3afp81sr8t1hxo2meu3aj1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalDisAmount).HasColumnName("additional_dis_amount");

                entity.Property(e => e.AdditionalDisPer).HasColumnName("additional_dis_per");

                entity.Property(e => e.AdditionalNote)
                    .HasMaxLength(255)
                    .HasColumnName("additional_note");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(255)
                    .HasColumnName("billing_address");

                entity.Property(e => e.BillingAddressId).HasColumnName("billing_address_id");

                entity.Property(e => e.BillingTitle)
                    .HasMaxLength(255)
                    .HasColumnName("billing_title");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CusPurchaseOrder).HasColumnName("cus_purchase_order");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.EstimateDeliveryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("estimate_delivery_date");

                entity.Property(e => e.ExpiredDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("expired_date");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.IsIncludeVat).HasColumnName("is_include_vat");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PostDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("post_date");

                entity.Property(e => e.PriceListId).HasColumnName("price_list_id");

                entity.Property(e => e.SaleOrderId).HasColumnName("sale_order_id");

                entity.Property(e => e.SalePersonId).HasColumnName("sale_person_id");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(255)
                    .HasColumnName("shipping_address");

                entity.Property(e => e.ShippingAddressId).HasColumnName("shipping_address_id");

                entity.Property(e => e.ShippingTitle)
                    .HasMaxLength(255)
                    .HasColumnName("shipping_title");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TermConditionId).HasColumnName("term_condition_id");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalCost).HasColumnName("total_cost");

                entity.Property(e => e.TotalQty).HasColumnName("total_qty");

                entity.Property(e => e.TotalTaxCharge).HasColumnName("total_tax_charge");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.VatAmount).HasColumnName("vat_amount");

                entity.Property(e => e.VatPer).HasColumnName("vat_per");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fkriqr781i8uaks8kw4hipfejmu");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fklf5ti8fw77uew5ivt1rh1dlrd");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.PriceListId)
                    .HasConstraintName("fkqw4us6raa0axrfll4utr2jyyh");

                entity.HasOne(d => d.SaleOrder)
                    .WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.SaleOrderId)
                    .HasConstraintName("fk8a34ncoptrruc4powlgob0yc5");

                entity.HasOne(d => d.SalePerson)
                    .WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.SalePersonId)
                    .HasConstraintName("fkpjff3qs6do3e4423n7583n4oh");

                entity.HasOne(d => d.TermCondition)
                    .WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.TermConditionId)
                    .HasConstraintName("fknyfnm3d1yknkkxg43x23k96va");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Quotations)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fk5n98enejkc4c61wvjendapyeb");
            });

            modelBuilder.Entity<QuotationDetail>(entity =>
            {
                entity.ToTable("quotation_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ConversionFactor).HasColumnName("conversion_factor");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("delivery_date");

                entity.Property(e => e.DeliveryFee).HasColumnName("delivery_fee");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemVariantUomId).HasColumnName("item_variant_uom_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.QuotationId).HasColumnName("quotation_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StockQty).HasColumnName("stock_qty");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.QuotationDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk35aokq9ogjh42ekkv5n6n78o");

                entity.HasOne(d => d.ItemVariantUom)
                    .WithMany(p => p.QuotationDetails)
                    .HasForeignKey(d => d.ItemVariantUomId)
                    .HasConstraintName("fkt222p3ii54d1qstkcymb0osch");

                entity.HasOne(d => d.Quotation)
                    .WithMany(p => p.QuotationDetails)
                    .HasForeignKey(d => d.QuotationId)
                    .HasConstraintName("fk5uhuhl4i0dvr1lqwn3cv35wl");
            });

            modelBuilder.Entity<Refund>(entity =>
            {
                entity.ToTable("refund");

                entity.HasIndex(e => e.Series, "idxiaf0hxc896ewo9xorfwsfhaij");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CreditNoteId).HasColumnName("credit_note_id");

                entity.Property(e => e.CreditNotedAmount).HasColumnName("credit_noted_amount");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GlAccountId).HasColumnName("gl_account_id");

                entity.Property(e => e.InvoiceAmount).HasColumnName("invoice_amount");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(255)
                    .HasColumnName("invoice_no");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PaymentOption)
                    .HasMaxLength(255)
                    .HasColumnName("payment_option");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(255)
                    .HasColumnName("reference_no");

                entity.Property(e => e.RefundAmount).HasColumnName("refund_amount");

                entity.Property(e => e.Remark).HasColumnName("remark");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.Refunds)
                    .HasForeignKey(d => d.CreditNoteId)
                    .HasConstraintName("fkmj8r0hapy9gevko3ioskaolcl");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Refunds)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk4g7imna3evv9fxup6kdhbm5hu");

                entity.HasOne(d => d.GlAccount)
                    .WithMany(p => p.Refunds)
                    .HasForeignKey(d => d.GlAccountId)
                    .HasConstraintName("fkhw0lummngd0f8k4qloc90rpxg");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Refunds)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("fk4ny5ywx78sgoir4c4gifedx7e");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("role");

                entity.HasIndex(e => e.RoleName, "uk_iubw515ff0ugtm28p8g3myt0h")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(255)
                    .HasColumnName("role_name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<RoleMenu>(entity =>
            {
                entity.ToTable("role_menu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.MenuItemId).HasColumnName("menu_item_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.RoleMenus)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk6829se8jshcx4di58icvqvh9q");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleMenus)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkqyvxw2gg2qk0wld3bqfcb58vq");
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.ToTable("role_permission");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PermissionId).HasColumnName("permission_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkf8yllw1ecvwqy3ehyxawqa1qp");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fka6jx8n8xkesmjmv6jqug6bg68");
            });

            modelBuilder.Entity<SaleOrder>(entity =>
            {
                entity.ToTable("sale_order");

                entity.HasIndex(e => e.Series, "idxqbmft4q1dmjlerprud17m172k");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalDisAmount).HasColumnName("additional_dis_amount");

                entity.Property(e => e.AdditionalDisPer).HasColumnName("additional_dis_per");

                entity.Property(e => e.AdditionalNote)
                    .HasMaxLength(255)
                    .HasColumnName("additional_note");

                entity.Property(e => e.BilledStatus)
                    .HasMaxLength(255)
                    .HasColumnName("billed_status");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(1000)
                    .HasColumnName("billing_address");

                entity.Property(e => e.BillingAddressId).HasColumnName("billing_address_id");

                entity.Property(e => e.BillingTitle)
                    .HasMaxLength(255)
                    .HasColumnName("billing_title");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CusPurchaseOrder).HasColumnName("cus_purchase_order");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DeliveryStatus)
                    .HasMaxLength(255)
                    .HasColumnName("delivery_status");

                entity.Property(e => e.EstimateDeliveryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("estimate_delivery_date");

                entity.Property(e => e.FirstProcessFlow)
                    .HasMaxLength(255)
                    .HasColumnName("first_process_flow");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.IsDeposit).HasColumnName("is_deposit");

                entity.Property(e => e.IsIncludeVat).HasColumnName("is_include_vat");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PerBilled).HasColumnName("per_billed");

                entity.Property(e => e.PerDelivered).HasColumnName("per_delivered");

                entity.Property(e => e.PostDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("post_date");

                entity.Property(e => e.PrepaymentAmount).HasColumnName("prepayment_amount");

                entity.Property(e => e.PrepaymentBalance).HasColumnName("prepayment_balance");

                entity.Property(e => e.PriceListId).HasColumnName("price_list_id");

                entity.Property(e => e.QuotationId).HasColumnName("quotation_id");

                entity.Property(e => e.SalePersonId).HasColumnName("sale_person_id");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(1000)
                    .HasColumnName("shipping_address");

                entity.Property(e => e.ShippingAddressId).HasColumnName("shipping_address_id");

                entity.Property(e => e.ShippingTitle)
                    .HasMaxLength(255)
                    .HasColumnName("shipping_title");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalCost).HasColumnName("total_cost");

                entity.Property(e => e.TotalQty).HasColumnName("total_qty");

                entity.Property(e => e.TotalTaxCharge).HasColumnName("total_tax_charge");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.VatAmount).HasColumnName("vat_amount");

                entity.Property(e => e.VatPer).HasColumnName("vat_per");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SaleOrders)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fk6e9jxg1jpu3b8dro6diuphdn8");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SaleOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fkfe1q5gxqihxkop8uycrfuxg5j");

                entity.HasOne(d => d.PriceList)
                    .WithMany(p => p.SaleOrders)
                    .HasForeignKey(d => d.PriceListId)
                    .HasConstraintName("fk66ivraj759yed1m8bow8o2q6l");

                entity.HasOne(d => d.Quotation)
                    .WithMany(p => p.SaleOrders)
                    .HasForeignKey(d => d.QuotationId)
                    .HasConstraintName("fkgk5vd2s6eqpcd2lxwu5miocao");

                entity.HasOne(d => d.SalePerson)
                    .WithMany(p => p.SaleOrders)
                    .HasForeignKey(d => d.SalePersonId)
                    .HasConstraintName("fk8bf2b8po4cpyc8jew5ve43ohm");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SaleOrders)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fkntbtuvtqepg0h1tb05joy0l4s");
            });

            modelBuilder.Entity<SaleOrderDetail>(entity =>
            {
                entity.ToTable("sale_order_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ConversionFactor).HasColumnName("conversion_factor");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("delivery_date");

                entity.Property(e => e.DeliveryQty).HasColumnName("delivery_qty");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.HasSerialNo).HasColumnName("has_serial_no");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemVariantUomId).HasColumnName("item_variant_uom_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.RemainQty).HasColumnName("remain_qty");

                entity.Property(e => e.SaleOrderId).HasColumnName("sale_order_id");

                entity.Property(e => e.SerialNo).HasColumnName("serial_no");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.StockQty).HasColumnName("stock_qty");

                entity.Property(e => e.TotalCost).HasColumnName("total_cost");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.ValuationRate).HasColumnName("valuation_rate");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SaleOrderDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkeeka85wbcfp5b70e8479j8c4f");

                entity.HasOne(d => d.ItemVariantUom)
                    .WithMany(p => p.SaleOrderDetails)
                    .HasForeignKey(d => d.ItemVariantUomId)
                    .HasConstraintName("fk9anlq0du5k2322fcpofmsarvl");

                entity.HasOne(d => d.SaleOrder)
                    .WithMany(p => p.SaleOrderDetails)
                    .HasForeignKey(d => d.SaleOrderId)
                    .HasConstraintName("fk1isrkdb4ekuoeo7dsbyw1s9u0");
            });

            modelBuilder.Entity<SalePerson>(entity =>
            {
                entity.ToTable("sale_person");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommissionRate).HasColumnName("commission_rate");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SalePersonName)
                    .HasMaxLength(100)
                    .HasColumnName("sale_person_name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SalePeople)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("fke1u58xw55ol3s4rc87svsfe8q");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fkflejc15b52ujrc08i883407cg");
            });

            modelBuilder.Entity<SaleReturn>(entity =>
            {
                entity.ToTable("sale_return");

                entity.HasIndex(e => e.Series, "idxix1ctilkl2tb93ca3mjm8ucyj");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Date)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DeliveryNoteId).HasColumnName("delivery_note_id");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.GrandTotal).HasColumnName("grand_total");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark");

                entity.Property(e => e.ReturnFrom)
                    .HasMaxLength(255)
                    .HasColumnName("return_from");

                entity.Property(e => e.SaleOrderId).HasColumnName("sale_order_id");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.TotalQty).HasColumnName("total_qty");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SaleReturns)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("fk68j2wpxymba2ile9k5lq8x5cv");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SaleReturns)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fkra8c7dye3yyej114bpakbjk8n");

                entity.HasOne(d => d.DeliveryNote)
                    .WithMany(p => p.SaleReturns)
                    .HasForeignKey(d => d.DeliveryNoteId)
                    .HasConstraintName("fk6tbidj5qv83lp9btbv15yf2mm");

                entity.HasOne(d => d.SaleOrder)
                    .WithMany(p => p.SaleReturns)
                    .HasForeignKey(d => d.SaleOrderId)
                    .HasConstraintName("fk7bxrucp94ndc7snxo8dhav0ce");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SaleReturns)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fklysn5lt6og1g77kqw54sshy1s");
            });

            modelBuilder.Entity<SaleReturnDetail>(entity =>
            {
                entity.ToTable("sale_return_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.DiscountPercentage).HasColumnName("discount_percentage");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemVariantUomId).HasColumnName("item_variant_uom__id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.SaleReturnId).HasColumnName("sale_return_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SaleReturnDetails)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkfxgvy4ow09mqstbro5sax7g17");

                entity.HasOne(d => d.ItemVariantUom)
                    .WithMany(p => p.SaleReturnDetails)
                    .HasForeignKey(d => d.ItemVariantUomId)
                    .HasConstraintName("fkpqhbwdicpcl4ag79s35ua001t");

                entity.HasOne(d => d.SaleReturn)
                    .WithMany(p => p.SaleReturnDetails)
                    .HasForeignKey(d => d.SaleReturnId)
                    .HasConstraintName("fkg35ss7j8mod4vc6w2hgpgooce");
            });

            modelBuilder.Entity<SaleTaxCharge>(entity =>
            {
                entity.ToTable("sale_tax_charge");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Disable).HasColumnName("disable");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SaleTaxCharges)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("fkbt8g92toapbsl1elxgjt77fqf");
            });

            modelBuilder.Entity<SaleTaxDetail>(entity =>
            {
                entity.ToTable("sale_tax_detail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.SaleTaxChargeId).HasColumnName("sale_tax_charge_id");

                entity.Property(e => e.SaleTaxTypeId).HasColumnName("sale_tax_type_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.SaleTaxDetails)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("fkkqgdffk6oaepnpjsden2u5bm6");

                entity.HasOne(d => d.SaleTaxCharge)
                    .WithMany(p => p.SaleTaxDetails)
                    .HasForeignKey(d => d.SaleTaxChargeId)
                    .HasConstraintName("fkby4kj0dhqm4f2kntq6ieo8mao");

                entity.HasOne(d => d.SaleTaxType)
                    .WithMany(p => p.SaleTaxDetails)
                    .HasForeignKey(d => d.SaleTaxTypeId)
                    .HasConstraintName("fka7i73g2fd1adm4pla4w0lxif5");
            });

            modelBuilder.Entity<SaleTaxType>(entity =>
            {
                entity.ToTable("sale_tax_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Salutation>(entity =>
            {
                entity.ToTable("salutation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GenderId).HasColumnName("gender_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Salutation1)
                    .HasMaxLength(50)
                    .HasColumnName("salutation");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Salutations)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk1vf62tr3xbb80r9r7wvnacqts");
            });

            modelBuilder.Entity<SerialNo>(entity =>
            {
                entity.ToTable("serial_no");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Asset)
                    .HasMaxLength(255)
                    .HasColumnName("asset");

                entity.Property(e => e.AssetStatus)
                    .HasMaxLength(255)
                    .HasColumnName("asset_status");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(255)
                    .HasColumnName("batch_no");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("delivery_date");

                entity.Property(e => e.DeliverySeries)
                    .HasMaxLength(255)
                    .HasColumnName("delivery_series");

                entity.Property(e => e.Employee)
                    .HasMaxLength(255)
                    .HasColumnName("employee");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.MaintenanceStatus)
                    .HasMaxLength(255)
                    .HasColumnName("maintenance_status");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("purchase_date");

                entity.Property(e => e.PurchaseSeries)
                    .HasMaxLength(255)
                    .HasColumnName("purchase_series");

                entity.Property(e => e.SerialNo1).HasColumnName("serial_no");

                entity.Property(e => e.SerialNoDetail).HasColumnName("serial_no_detail");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.Property(e => e.WarrantyExpireDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("warranty_expire_date");

                entity.Property(e => e.WarrantyPeriod).HasColumnName("warranty_period");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SerialNos)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fk12whkb1ay28e7tb5gtyrvf7al");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SerialNos)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk6lj6wh3asrk2hko0svbdt35rl");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SerialNos)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fkrq4108andi458n7l5m2scxjj7");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SerialNos)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fk82emfq13asu8nd6f6k38vc3d9");
            });

            modelBuilder.Entity<StockBalance>(entity =>
            {
                entity.ToTable("stock_balance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BalanceQty).HasColumnName("balance_qty");

                entity.Property(e => e.BalanceValue).HasColumnName("balance_value");

                entity.Property(e => e.Cogs).HasColumnName("cogs");

                entity.Property(e => e.CompanyId).HasColumnName("company_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.InQty).HasColumnName("in_qty");

                entity.Property(e => e.InValue).HasColumnName("in_value");

                entity.Property(e => e.IsAbsoluteValue).HasColumnName("is_absolute_value");

                entity.Property(e => e.ItemBrandId).HasColumnName("item_brand_id");

                entity.Property(e => e.ItemGroupId).HasColumnName("item_group_id");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.OutQty).HasColumnName("out_qty");

                entity.Property(e => e.OutValue).HasColumnName("out_value");

                entity.Property(e => e.ReservedQty).HasColumnName("reserved_qty");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UomId).HasColumnName("uom_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.ValuationRate).HasColumnName("valuation_rate");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WaitingQty).HasColumnName("waiting_qty");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StockBalances)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("fktgjh58semjd1j5or2c2wwwsbb");

                entity.HasOne(d => d.ItemBrand)
                    .WithMany(p => p.StockBalances)
                    .HasForeignKey(d => d.ItemBrandId)
                    .HasConstraintName("fk6rl1ityt6rj170agffi8y1s0w");

                entity.HasOne(d => d.ItemGroup)
                    .WithMany(p => p.StockBalances)
                    .HasForeignKey(d => d.ItemGroupId)
                    .HasConstraintName("fkt3lfdsnlyvsmvricin7gq4weu");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StockBalances)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkkx446h9kl3uhwk4aik8mf7txy");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.StockBalances)
                    .HasForeignKey(d => d.UomId)
                    .HasConstraintName("fktncstwbue2v1tk2uu8dhv1mly");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.StockBalances)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fk8r5c5n53qfm24rbnloy0352fx");
            });

            modelBuilder.Entity<StockLedgerEntry>(entity =>
            {
                entity.ToTable("stock_ledger_entry");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActualQty).HasColumnName("actual_qty");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.QtyAfterTranx).HasColumnName("qty_after_tranx");

                entity.Property(e => e.SerialNo).HasColumnName("serial_no");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UomId).HasColumnName("uom_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.ValuationRate).HasColumnName("valuation_rate");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.VoucherNo)
                    .HasMaxLength(255)
                    .HasColumnName("voucher_no");

                entity.Property(e => e.VoucherType)
                    .HasMaxLength(255)
                    .HasColumnName("voucher_type");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StockLedgerEntries)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkgd0tsaayq87j3kc1fkxyf4826");

                entity.HasOne(d => d.Uom)
                    .WithMany(p => p.StockLedgerEntries)
                    .HasForeignKey(d => d.UomId)
                    .HasConstraintName("fk1xb8wim7g2yis2kfet61xewm4");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.StockLedgerEntries)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fk92dind6o2qd7h1gvpbhe43dv7");
            });

            modelBuilder.Entity<StockMove>(entity =>
            {
                entity.ToTable("stock_move");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.IsRefund).HasColumnName("is_refund");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemQty).HasColumnName("item_qty");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note");

                entity.Property(e => e.StateStockMove).HasColumnName("state_stock_move");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.StockMoves)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fkod2pcvaos1am5wtio2rapiuxa");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.StockMoves)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fka1n7nvnm1y225ioj500iu0jgp");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("supplier");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(255)
                    .HasColumnName("contact_name");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(255)
                    .HasColumnName("contact_phone");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PrepaymentBalance).HasColumnName("prepayment_balance");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierGroupId).HasColumnName("supplier_group_id");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(255)
                    .HasColumnName("supplier_name");

                entity.Property(e => e.SupplierTypeId).HasColumnName("supplier_type_id");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Vat).HasColumnName("vat");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.SupplierGroup)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.SupplierGroupId)
                    .HasConstraintName("fkesu19c23q6lq24pou4hk02fxl");

                entity.HasOne(d => d.SupplierType)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.SupplierTypeId)
                    .HasConstraintName("fki8frtsnt5d9v8bljvk9ce7e49");
            });

            modelBuilder.Entity<SupplierGroup>(entity =>
            {
                entity.ToTable("supplier_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(30)
                    .HasColumnName("group_name");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fk7n6ugl6r3fnvug1li4j75yiai");
            });

            modelBuilder.Entity<SupplierPayment>(entity =>
            {
                entity.ToTable("supplier_payment");

                entity.HasIndex(e => e.Series, "idxj2xgusphcaj5mq9u9obuh6o4v");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.CustomStatus)
                    .HasMaxLength(255)
                    .HasColumnName("custom_status");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.GlAccountId).HasColumnName("gl_account_id");

                entity.Property(e => e.IsSettleCredit).HasColumnName("is_settle_credit");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PaidAmount).HasColumnName("paid_amount");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("payment_date");

                entity.Property(e => e.PaymentOption)
                    .HasMaxLength(255)
                    .HasColumnName("payment_option");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(255)
                    .HasColumnName("payment_type");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(255)
                    .HasColumnName("ref_no");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark");

                entity.Property(e => e.Series)
                    .HasMaxLength(255)
                    .HasColumnName("series");

                entity.Property(e => e.SettlementAmount).HasColumnName("settlement_amount");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierId).HasColumnName("supplier_id");

                entity.Property(e => e.TotalPaidAmount).HasColumnName("total_paid_amount");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.GlAccount)
                    .WithMany(p => p.SupplierPayments)
                    .HasForeignKey(d => d.GlAccountId)
                    .HasConstraintName("fk37powsao54q2lixsdroi931s2");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierPayments)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("fkqy7og5c3psvi8j5yn2lmrki7x");
            });

            modelBuilder.Entity<SupplierPaymentReference>(entity =>
            {
                entity.ToTable("supplier_payment_reference");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.PaidAmount).HasColumnName("paid_amount");

                entity.Property(e => e.PiAmount).HasColumnName("pi_amount");

                entity.Property(e => e.PiNo)
                    .HasMaxLength(255)
                    .HasColumnName("pi_no");

                entity.Property(e => e.PoAmount).HasColumnName("po_amount");

                entity.Property(e => e.PoNo)
                    .HasMaxLength(255)
                    .HasColumnName("po_no");

                entity.Property(e => e.PrePaidAmount).HasColumnName("pre_paid_amount");

                entity.Property(e => e.PrepaymentAmount).HasColumnName("prepayment_amount");

                entity.Property(e => e.PurchaseInvoiceId).HasColumnName("purchase_invoice_id");

                entity.Property(e => e.PurchaseOrderId).HasColumnName("purchase_order_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.SupplierPaymentId).HasColumnName("supplier_payment_id");

                entity.Property(e => e.UnpaidAmount).HasColumnName("unpaid_amount");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.SupplierPayment)
                    .WithMany(p => p.SupplierPaymentReferences)
                    .HasForeignKey(d => d.SupplierPaymentId)
                    .HasConstraintName("fk6d3jm63jygvlx10hevm5xt9h5");
            });

            modelBuilder.Entity<SupplierType>(entity =>
            {
                entity.ToTable("supplier_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .HasColumnName("type");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<TermCondition>(entity =>
            {
                entity.ToTable("term_condition");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IsDisable).HasColumnName("is_disable");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Territory>(entity =>
            {
                entity.ToTable("territory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TerritoryName)
                    .HasMaxLength(255)
                    .HasColumnName("territory_name");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fk7nloh1mltgwne5y78ttnr31s1");
            });

            modelBuilder.Entity<TransactionJournal>(entity =>
            {
                entity.ToTable("transaction_journal");

                entity.HasIndex(e => e.GlCode, "uk_cbtgke7cl0j68qi8ufskdk013")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BStatus).HasColumnName("b_status");

                entity.Property(e => e.ChartOfAccId).HasColumnName("chart_of_acc_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Debit).HasColumnName("debit");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(255)
                    .HasColumnName("gl_code");

                entity.Property(e => e.JournalEntryId).HasColumnName("journal_entry_id");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Ref)
                    .HasMaxLength(255)
                    .HasColumnName("ref");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.ChartOfAcc)
                    .WithMany(p => p.TransactionJournals)
                    .HasForeignKey(d => d.ChartOfAccId)
                    .HasConstraintName("fknnqnwmbgyqav3myhdcqs2pb0r");

                entity.HasOne(d => d.JournalEntry)
                    .WithMany(p => p.TransactionJournals)
                    .HasForeignKey(d => d.JournalEntryId)
                    .HasConstraintName("fk6ii7t9iwrqgpvarphfooha64v");
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("transaction_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .HasColumnName("code");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TrxnName)
                    .HasMaxLength(255)
                    .HasColumnName("trxn_name");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Uom>(entity =>
            {
                entity.ToTable("uom");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.IsUsed).HasColumnName("is_used");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(255)
                    .HasColumnName("image_path");

                entity.Property(e => e.IsAdmin).HasColumnName("is_admin");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("fkixo09sv3j1j6hfox3cx6d2ggg");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("user_role");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fka68196081fvovjhkek5m97n3y");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkj345gk1bovqvfame88rcx7yyx");
            });

            modelBuilder.Entity<ValuationMethod>(entity =>
            {
                entity.ToTable("valuation_method");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.MethodName)
                    .HasMaxLength(255)
                    .HasColumnName("method_name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Village>(entity =>
            {
                entity.ToTable("village");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommuneCode)
                    .HasMaxLength(255)
                    .HasColumnName("commune_code");

                entity.Property(e => e.CommuneId).HasColumnName("commune_id");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.Village1)
                    .HasMaxLength(255)
                    .HasColumnName("village");

                entity.Property(e => e.VillageKh)
                    .HasMaxLength(255)
                    .HasColumnName("village_kh");

                entity.Property(e => e.Villid)
                    .HasMaxLength(255)
                    .HasColumnName("villid");

                entity.HasOne(d => d.Commune)
                    .WithMany(p => p.Villages)
                    .HasForeignKey(d => d.CommuneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkcrrurypoayljvp4qlwqxkivvl");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("warehouse");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("account_id");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(255)
                    .HasColumnName("address_line1");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(255)
                    .HasColumnName("address_line2");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.CreatedById).HasColumnName("created_by_id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_created");

                entity.Property(e => e.IsDisable).HasColumnName("is_disable");

                entity.Property(e => e.IsGroup).HasColumnName("is_group");

                entity.Property(e => e.IsUsed).HasColumnName("is_used");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("last_updated");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.UpdatedById).HasColumnName("updated_by_id");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.Property(e => e.WarehouseName)
                    .HasMaxLength(255)
                    .HasColumnName("warehouse_name");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Warehouses)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("fk70sqwlljiffsgp99br2hxtrkf");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fklfiv9cjr48uvfjtw9knmnqpl0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
