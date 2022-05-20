namespace EFCoreAIGS.DataScaffold
{
    public partial class StockTransaction
    {
        public long Id { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Status { get; set; }
        public DateTime? LastUpdated { get; set; }
        public long? UpdatedById { get; set; }
        public int? Version { get; set; }
        public int? Qty { get; set; }
        public string? ReferenceNo { get; set; }
        public long? ItemId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Item? Item { get; set; }
    }
}
