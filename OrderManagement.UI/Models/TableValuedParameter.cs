namespace OrderManagement.UI.Models
{
    public class TableValuedParameter
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
    }
}
