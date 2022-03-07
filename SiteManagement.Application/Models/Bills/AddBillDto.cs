namespace SiteManagement.Application.Models.Bills
{
    public class AddBillDto
    {
        public int FlatId { get; set; }
        public int BillTypeId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal BillPrice { get; set; }

    }
}
