using System;
using System.Collections.Generic;

namespace EFCoreAIGS.EF_ERP
{
    public partial class Item
    {
        public Item()
        {
            BarcodeItems = new HashSet<BarcodeItem>();
            DeliveryNoteDetails = new HashSet<DeliveryNoteDetail>();
            InvoiceDetails = new HashSet<InvoiceDetail>();
            ItemImages = new HashSet<ItemImage>();
            ItemInventories = new HashSet<ItemInventory>();
            ItemItems = new HashSet<ItemItem>();
            ItemPrices = new HashSet<ItemPrice>();
            ItemTaxes = new HashSet<ItemTax>();
            ItemVarrantUoms = new HashSet<ItemVarrantUom>();
            ItemWarehouses = new HashSet<ItemWarehouse>();
            PurchaseInvoiceDetails = new HashSet<PurchaseInvoiceDetail>();
            PurchaseItems = new HashSet<PurchaseItem>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
            PurchaseReceiptDetails = new HashSet<PurchaseReceiptDetail>();
            PurchaseReturnDetails = new HashSet<PurchaseReturnDetail>();
            QuotationDetails = new HashSet<QuotationDetail>();
            SaleOrderDetails = new HashSet<SaleOrderDetail>();
            SaleReturnDetails = new HashSet<SaleReturnDetail>();
            SerialNos = new HashSet<SerialNo>();
            StockBalances = new HashSet<StockBalance>();
            StockLedgerEntries = new HashSet<StockLedgerEntry>();
            StockMoves = new HashSet<StockMove>();
        }

        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public bool? HasBatchNo { get; set; }
        public bool? HasSerialNo { get; set; }
        public string? Barcode { get; set; }
        public double? Cost { get; set; }
        public double? DeliveryFee { get; set; }
        public string? Description { get; set; }
        public DateTime? EndOfLife { get; set; }
        public bool? IsDisable { get; set; }
        public bool? IsFixAsset { get; set; }
        public bool? IsMaintainStock { get; set; }
        public bool? IsSaleItem { get; set; }
        public bool? IsUsed { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemImageUrl { get; set; }
        public string? ItemName { get; set; }
        public double? LastPurchaseRate { get; set; }
        public int? ManufacturePartNumber { get; set; }
        public double? MaxDiscount { get; set; }
        public int OpeningStock { get; set; }
        public int? SaleUnitOfMeasure { get; set; }
        public long? SelfLifeInDay { get; set; }
        public double StandardBuyingRate { get; set; }
        public double StandardSellingRate { get; set; }
        public double? ValuationRate { get; set; }
        public long? WarrantyPeriod { get; set; }
        public double? WeightPerUnit { get; set; }
        public string? WeightUom { get; set; }
        public long? WeightUomId { get; set; }
        public long? ItemBrandId { get; set; }
        public long? ItemGroupId { get; set; }
        public long UomId { get; set; }
        public long ValuationMethodId { get; set; }

        public virtual ItemBrand? ItemBrand { get; set; }
        public virtual ItemGroup? ItemGroup { get; set; }
        public virtual Uom Uom { get; set; } = null!;
        public virtual ValuationMethod ValuationMethod { get; set; } = null!;
        public virtual ICollection<BarcodeItem> BarcodeItems { get; set; }
        public virtual ICollection<DeliveryNoteDetail> DeliveryNoteDetails { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<ItemImage> ItemImages { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemItem> ItemItems { get; set; }
        public virtual ICollection<ItemPrice> ItemPrices { get; set; }
        public virtual ICollection<ItemTax> ItemTaxes { get; set; }
        public virtual ICollection<ItemVarrantUom> ItemVarrantUoms { get; set; }
        public virtual ICollection<ItemWarehouse> ItemWarehouses { get; set; }
        public virtual ICollection<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }
        public virtual ICollection<PurchaseItem> PurchaseItems { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public virtual ICollection<PurchaseReceiptDetail> PurchaseReceiptDetails { get; set; }
        public virtual ICollection<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        public virtual ICollection<QuotationDetail> QuotationDetails { get; set; }
        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
        public virtual ICollection<SaleReturnDetail> SaleReturnDetails { get; set; }
        public virtual ICollection<SerialNo> SerialNos { get; set; }
        public virtual ICollection<StockBalance> StockBalances { get; set; }
        public virtual ICollection<StockLedgerEntry> StockLedgerEntries { get; set; }
        public virtual ICollection<StockMove> StockMoves { get; set; }
    }
}
