namespace OrderManagement.UI.Data
{
    #nullable disable
    public class VmOrder
    {
        public int ReferenceId { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string SupplierName { get; set; } = "";
        public DateTime ExpectedDate { get; set; }
        public string Remarks { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public List<VmTableValuedParameter> OrderItem { get; set; } = new List<VmTableValuedParameter>();
    }
}
