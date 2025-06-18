using Payments.Domain.Contracts;

namespace Payments.Domain.Events
{
    public class PaymentUpdatedEvent : IDomainEvent
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime OccurredOn { get; } = DateTime.UtcNow;
        public string EventType { get; } = nameof(PaymentUpdatedEvent);
        public int Version { get; } = 1;

        // Additional properties specific to the PaymentUpdatedEvent can be added here
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }

        // Constructor to initialize the event with necessary data
        public PaymentUpdatedEvent(int paymentId, decimal amount, string currency, string status)
        {
            PaymentId = paymentId;
            Amount = amount;
            Currency = currency;
            Status = status;
        }
    }
}
