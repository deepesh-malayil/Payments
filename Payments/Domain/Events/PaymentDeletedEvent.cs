using Payments.Domain.Contracts;

namespace Payments.Domain.Events
{
    public class PaymentDeletedEvent : IDomainEvent
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime OccurredOn { get; } = DateTime.UtcNow;
        public string EventType { get; } = nameof(PaymentDeletedEvent);
        public int Version { get; } = 1;
        // Additional properties specific to the PaymentDeletedEvent can be added here
        public int PaymentId { get; set; }
        // Constructor to initialize the event with necessary data
        public PaymentDeletedEvent(int paymentId)
        {
            PaymentId = paymentId;
        }
    }
}
