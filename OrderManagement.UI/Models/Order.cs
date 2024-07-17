using System.ComponentModel.DataAnnotations;

namespace OrderManagement.UI.Models
{
#nullable disable
    public class Order
    {
        public int ReferenceId { get; set; } = 1;
        [Required(ErrorMessage = "Order Number is Required")]
        public string OrderNo { get; set; }
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Today;
        public string OrderDateString { get; set; }
        public string SupplierName { get; set; } = "";
        public DateTime ExpectedDate { get; set; } = DateTime.Today;
        public string ExpectedDateString { get; set; }
        public string Remarks { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public List<TableValuedParameter> OrderItem { get; set; } = new List<TableValuedParameter>();
    }
}
