namespace Payments.Domain.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; } // e.g., Pending, Completed, Failed
        public Payment() { 
            Amount = 0.0m;
            Currency = "USD"; // Default currency
            Status = "Pending"; // Default status
        }

    }
}
